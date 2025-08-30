using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbUpdate
{
     class clsDbUpdater : DBConnection
    {
        clsCommonDb C_Common = new clsCommonDb();
       
        public bool RunUpdatesForCustomer(string customerId, string scriptsFolder, DateTime fromDate)
        {
            bool overallSuccess = true;
            DateTime lastUpdate = EnsureTableAndGetLastUpdateDate(customerId, fromDate);

            var files = SqlFileHelper.GetSqlFilesAfterDate(scriptsFolder, lastUpdate);
            var groupedFiles = files.GroupBy(f => f.Date).OrderBy(g => g.Key);

            sqlcon.Open();

            foreach (var group in groupedFiles)
            {
                DateTime currentDate = group.Key;
                var tbFiles = group.Where(f => f.Type == "TB").ToList();
                var spFiles = group.Where(f => f.Type == "SP").ToList();

                using (SqlTransaction tran = sqlcon.BeginTransaction())
                {
                    bool hasError = false;

                    foreach (var file in tbFiles.Concat(spFiles))
                    {
                        string sql = File.ReadAllText(file.Path);
                        var batches = Regex.Split(sql, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                        foreach (var batch in batches)
                        {
                            if (string.IsNullOrWhiteSpace(batch)) continue;
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(batch, sqlcon, tran))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (SqlException ex)
                            {
                                tran.Rollback();
                                LogError(ex.Message, currentDate, ex.LineNumber, Path.GetFileName(file.Path));
                                hasError = true;
                                break; // stop further execution for this group
                            }
                        }
                        if (hasError) break;
                    }

                    if (!hasError)
                    {
                        tran.Commit();
                        UpdateLastUpdateDate(customerId, currentDate);
                    }
                    else
                    {
                        overallSuccess = false;
                    }
                }
            }

            sqlcon.Close();
            return overallSuccess;
        }


        private void LogError(string message, DateTime? scriptDate,int lineNumber,string filename)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UpdateErrors.log");
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Date:{scriptDate:yyyy-MM-dd} | {message}| Line:{lineNumber} | File:{filename}";
            File.AppendAllText(logPath, logEntry + Environment.NewLine);
        }
        public void ExecuteSqlFile(string filePath)
        {
            string sqlScript = File.ReadAllText(filePath);

           
                sqlcon.Open();
                SqlTransaction transaction = sqlcon.BeginTransaction();

                try
                {
                    // Split commands by GO if your files have multiple SP/TB statements
                    string[] commands = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                    foreach (string command in commands)
                    {
                        if (string.IsNullOrWhiteSpace(command)) continue;

                        using (SqlCommand cmd = new SqlCommand(command, sqlcon, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();  // commit if all succeed
                    LogExecution(filePath, "SUCCESS");
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // rollback on error
                    LogExecution(filePath, "FAILED: " + ex.Message);
                    throw; // rethrow so calling code knows it failed
                }
            
        }
        private void LogExecution(string filePath, string status)
        {
            string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UpdateLog.txt");
            string log = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {Path.GetFileName(filePath)} | {status}";
            File.AppendAllText(logFile, log + Environment.NewLine);
        }


        private DateTime EnsureTableAndGetLastUpdateDate(string customerId, DateTime fallbackDate)
        {
            DateTime lastUpdate = fallbackDate; // default to fallback date (from DateTimePicker)

            try
            {
                sqlcon.Open();

                // Create table if not exists
                string createSql = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CustomerUpdates')
BEGIN
    CREATE TABLE CustomerUpdates (
        CustomerId INT PRIMARY KEY,
        LastUpdateDate DATE
    );
END";
                using (SqlCommand cmd = new SqlCommand(createSql, sqlcon))
                {
                    cmd.ExecuteNonQuery();
                }

                // Fetch LastUpdateDate for given customer
                using (SqlCommand getCmd = new SqlCommand(
                    "SELECT LastUpdateDate FROM CustomerUpdates WHERE CustomerId = @CustomerId", sqlcon))
                {
                    getCmd.Parameters.AddWithValue("@CustomerId", customerId);
                    object result = getCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastUpdate = Convert.ToDateTime(result);
                    }
                    else
                    {
                        // If customer not found or no date -> fallbackDate used
                        // Optionally insert a new row for the customer with fallbackDate
                        string insertSql = @"
IF NOT EXISTS (SELECT 1 FROM CustomerUpdates WHERE CustomerId = @CustomerId)
    INSERT INTO CustomerUpdates (CustomerId, LastUpdateDate) VALUES (@CustomerId, @FallbackDate)";

                        using (SqlCommand insertCmd = new SqlCommand(insertSql, sqlcon))
                        {
                            insertCmd.Parameters.AddWithValue("@CustomerId", customerId);
                            insertCmd.Parameters.AddWithValue("@FallbackDate", fallbackDate);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }

            return lastUpdate;
        }


        private DateTime GetLastUpdateDate(string customerId)
        {

            sqlcon.Open();
            string sql = "SELECT LastUpdateDate FROM CustomerUpdates WHERE CustomerId=@cid";
            using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
            {
                cmd.Parameters.AddWithValue("@cid", customerId);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDateTime(result) : DateTime.MinValue;
            }
            sqlcon.Close();
        }

        private void UpdateLastUpdateDate(string customerId,  DateTime date)
        {
            string sql = @"
        IF NOT EXISTS (SELECT 1 FROM CustomerUpdates WHERE CustomerId=@cid)
            INSERT INTO CustomerUpdates (CustomerId, LastUpdateDate) VALUES (@cid, @dt)
        ELSE
            UPDATE CustomerUpdates SET LastUpdateDate=@dt WHERE CustomerId=@cid";

            using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
            {
                cmd.Parameters.AddWithValue("@cid", customerId);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.ExecuteNonQuery();
            }
        }

        private DateTime ParseDateFromFileName(string fileName)
        {
            // Expecting format TB_dd-MM-yyyy or SP_dd-MM-yyyy
            var parts = fileName.Split('_');
            if (parts.Length < 2) return DateTime.MinValue;
            return DateTime.ParseExact(parts[1], "dd-MM-yyyy", null);
        }

        private string GetFileType(string fileName)
        {
            // Return TB or SP based on prefix
            return fileName.StartsWith("TB", StringComparison.OrdinalIgnoreCase) ? "TB" :
                   fileName.StartsWith("SP", StringComparison.OrdinalIgnoreCase) ? "SP" : "";
        }
    }
    public class SqlFileInfo
    {
        public string Path { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // "TB" or "SP"
    }
    public static class SqlFileHelper
    {
        // folderPath: directory where .sql files exist
        public static List<SqlFileInfo> GetSqlFilesAfterDate(string folderPath, DateTime lastUpdateDate)
        {
            var files = Directory.GetFiles(folderPath, "*.sql");

            var list = new List<SqlFileInfo>();

            foreach (var file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file); // e.g., TB_25-08-2025
                                                                          // Expected format: TB_dd-MM-yyyy or SP_dd-MM-yyyy
                                                                          // Adjust regex if your naming differs
                var match = Regex.Match(fileName, @"^(TB|SP)_(\d{2})-(\d{2})-(\d{4})$", RegexOptions.IgnoreCase);
                if (!match.Success) continue;

                string type = match.Groups[1].Value.ToUpper(); // TB or SP
                int day = int.Parse(match.Groups[2].Value);
                int month = int.Parse(match.Groups[3].Value);
                int year = int.Parse(match.Groups[4].Value);

                DateTime fileDate = new DateTime(year, month, day);

                if (fileDate > lastUpdateDate)
                {
                    list.Add(new SqlFileInfo
                    {
                        Path = file,
                        Date = fileDate,
                        Type = type
                    });
                }
            }

            // Sort TB first, then SP, and by date ascending
            return list
                .OrderBy(f => f.Date)
                .ThenBy(f => f.Type == "TB" ? 0 : 1) // TB before SP
                .ToList();
        }
    }
}
