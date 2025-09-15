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

        //public bool RunUpdatesForCustomer(string customerId, string scriptsFolder, DateTime fromDate)
        //{
        //    bool overallSuccess = true;
        //    DateTime lastUpdate = EnsureTableAndGetLastUpdateDate(customerId, fromDate);

        //    var files = SqlFileHelper.GetSqlFilesAfterDate(scriptsFolder, lastUpdate);
        //    var groupedFiles = files.GroupBy(f => f.Date).OrderBy(g => g.Key);

        //    sqlcon.Open();

        //    foreach (var group in groupedFiles)
        //    {
        //        DateTime currentDate = group.Key;
        //        var tbFiles = group.Where(f => f.Type == "TB").ToList();
        //        var spFiles = group.Where(f => f.Type == "SP").ToList();

        //        using (SqlTransaction tran = sqlcon.BeginTransaction())
        //        {
        //            bool hasError = false;

        //            foreach (var file in tbFiles.Concat(spFiles))
        //            {
        //                string sql = File.ReadAllText(file.Path);
        //                var batches = Regex.Split(sql, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

        //                foreach (var batch in batches)
        //                {
        //                    if (string.IsNullOrWhiteSpace(batch)) continue;
        //                    try
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand(batch, sqlcon, tran))
        //                        {
        //                            cmd.ExecuteNonQuery();
        //                        }
        //                    }
        //                    catch (SqlException ex)
        //                    {
        //                        tran.Rollback();
        //                        LogError(ex.Message, currentDate, ex.LineNumber, Path.GetFileName(file.Path));
        //                        hasError = true;
        //                        break; // stop further execution for this group
        //                    }
        //                }
        //                if (hasError) break;
        //            }

        //            if (!hasError)
        //            {
        //                tran.Commit();
        //                UpdateLastUpdateDate(customerId, currentDate);
        //            }
        //            else
        //            {
        //                overallSuccess = false;
        //            }
        //        }
        //    }

        //    sqlcon.Close();
        //    return overallSuccess;
        //}

        public bool RunUpdatesForCustomer(string customerId, string scriptsFolder, DateTime fromDate)
        {
            bool overallSuccess = true;

            // 1️⃣ Get last update date from tracking table
            DateTime lastUpdate = EnsureTableAndGetLastUpdateDate(customerId, fromDate);

            // 2️⃣ Collect SQL files newer than lastUpdate
            var files = SqlFileHelper.GetSqlFilesAfterDate(scriptsFolder, lastUpdate);

            if (!files.Any())
                return true; // nothing to run

            // 3️⃣ Open a single connection and transaction
            using (SqlConnection sqlcon = DBConnection.GetOpenConnection())
            using (SqlTransaction tran = sqlcon.BeginTransaction())
            {
                try
                {
                    // group by date, process in order
                    var groupedFiles = files.GroupBy(f => f.Date).OrderBy(g => g.Key);

                    DateTime lastProcessedDate = DateTime.MinValue;

                    foreach (var group in groupedFiles)
                    {
                        DateTime currentDate = group.Key;
                        lastProcessedDate = currentDate; // keep track of last group

                        // Run table scripts first
                        var tbFiles = group.Where(f => f.Type == "TB").ToList();
                        foreach (var file in tbFiles)
                        {
                            if (!ExecuteSqlFile(file, sqlcon, tran, currentDate))
                                throw new Exception($"Table script failed: {file.Path}");
                        }

                        // Run SP scripts after tables
                        var spFiles = group.Where(f => f.Type == "SP").ToList();
                        foreach (var file in spFiles)
                        {
                            if (!ExecuteSqlFile(file, sqlcon, tran, currentDate, ensureProcExists: true))
                                throw new Exception($"Stored procedure script failed: {file.Path}");
                        }
                    }

                    // ✅ Update once after all groups processed
                    if (lastProcessedDate != DateTime.MinValue)
                    {
                        UpdateLastUpdateDate(customerId, lastProcessedDate, sqlcon, tran);
                    }


                    // ✅ All good: commit once
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    // 🔴 Rollback if *anything* fails
                    tran.Rollback();
                    LogError(ex.Message, fromDate, 0, "RunUpdatesForCustomer");
                    overallSuccess = false;
                }
            }

            return overallSuccess;
        }


        private bool ExecuteSqlFile(SqlFileInfo file, SqlConnection sqlcon, SqlTransaction tran, DateTime currentDate, bool ensureProcExists = false)
        {
            string sql = File.ReadAllText(file.Path);
            // Strip any "USE [DBName]" lines (they break transaction context)
            sql = Regex.Replace(sql, @"^\s*USE\s+\[.*?\]\s*;?\s*$", "", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            // Auto-wrap ALTER PROCEDURE with IF OBJECT_ID check if requested
            if (ensureProcExists && Regex.IsMatch(sql, @"\bALTER\s+PROCEDURE\b", RegexOptions.IgnoreCase))
            {
                var procNameMatch = Regex.Match(sql, @"ALTER\s+PROCEDURE\s+([\[\]\w\.]+)", RegexOptions.IgnoreCase);
                if (procNameMatch.Success)
                {
                    string procName = procNameMatch.Groups[1].Value;
                    string safeBlock = $@"
IF OBJECT_ID('{procName}', 'P') IS NULL
    EXEC('CREATE PROCEDURE {procName} AS BEGIN SET NOCOUNT ON; END')
GO
{sql}";
                    sql = safeBlock;
                }
            }

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
                    LogError(ex.Message, currentDate, ex.LineNumber, Path.GetFileName(file.Path));
                    return false;
                }
            }

            return true;
        }
        private void LogError(string message, DateTime? scriptDate,int lineNumber,string filename)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UpdateErrors.log");
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Date:{scriptDate:yyyy-MM-dd} | {message}| Line:{lineNumber} | File:{filename}";
            File.AppendAllText(logPath, logEntry + Environment.NewLine);
        }
        //public void ExecuteSqlFile(string filePath)
        //{
        //    string sqlScript = File.ReadAllText(filePath);

           
        //        sqlcon.Open();
        //        SqlTransaction transaction = sqlcon.BeginTransaction();

        //        try
        //        {
        //            // Split commands by GO if your files have multiple SP/TB statements
        //            string[] commands = Regex.Split(sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

        //            foreach (string command in commands)
        //            {
        //                if (string.IsNullOrWhiteSpace(command)) continue;

        //                using (SqlCommand cmd = new SqlCommand(command, sqlcon, transaction))
        //                {
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }

        //            transaction.Commit();  // commit if all succeed
        //            LogExecution(filePath, "SUCCESS");
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback(); // rollback on error
        //            LogExecution(filePath, "FAILED: " + ex.Message);
        //            throw; // rethrow so calling code knows it failed
        //        }
            
        //}
        private void LogExecution(string filePath, string status)
        {
            string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UpdateLog.txt");
            string log = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {Path.GetFileName(filePath)} | {status}";
            File.AppendAllText(logFile, log + Environment.NewLine);
        }


        private DateTime EnsureTableAndGetLastUpdateDate(string customerId, DateTime fallbackDate)
        {
            DateTime lastUpdate = fallbackDate;

            try
            {
                using (SqlConnection sqlcon = DBConnection.GetOpenConnection())
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqlcon.Close(); // Close if already open
                    }

                    sqlcon.Open(); // Now safely open

                    string createSql = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CustomerUpdates')
BEGIN
    CREATE TABLE CustomerUpdates (
        CustomerId NVARCHAR(50) PRIMARY KEY,
        LastUpdateDate DATE
    );
END";
                    using (SqlCommand cmd = new SqlCommand(createSql, sqlcon))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    //sqlcon.Close();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return lastUpdate;
        }


        private DateTime GetLastUpdateDate(string customerId)
        {
            using (SqlConnection sqlcon = DBConnection.GetOpenConnection())
            {
                string sql = "SELECT LastUpdateDate FROM CustomerUpdates WHERE CustomerId=@cid";
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@cid", customerId);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToDateTime(result);

                    return DateTime.MinValue;
                }
            }
        }

        private void UpdateLastUpdateDate(string customerId, DateTime date, SqlConnection sqlcon, SqlTransaction tran)
        {
            string sql = @"
 IF NOT EXISTS (SELECT 1 FROM CustomerUpdates WHERE CustomerId=@cid)
     INSERT INTO CustomerUpdates (CustomerId, LastUpdateDate) VALUES (@cid, @dt)
 ELSE
     UPDATE CustomerUpdates SET LastUpdateDate=@dt WHERE CustomerId=@cid";

            using (SqlCommand cmd = new SqlCommand(sql, sqlcon, tran))
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
        public static List<SqlFileInfo> GetSqlFilesAfterDate(string folderPath, DateTime lastUpdateDate)
        {
            var files = Directory.GetFiles(folderPath, "*.sql");
            var list = new List<SqlFileInfo>();

            foreach (var file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);

                // --- Format 1: TB/SP_dd-MM-yyyy ---
                var match1 = Regex.Match(fileName, @"^(TB|SP)_(\d{2})-(\d{2})-(\d{4})$", RegexOptions.IgnoreCase);

                // --- Format 2: ProcName_dd-MMM-yyyy (old style) ---
                var match2 = Regex.Match(fileName, @"_(\d{2})-([A-Za-z]{3})-(\d{4})$", RegexOptions.IgnoreCase);

                string type = "SP"; // default assume SP if old style
                DateTime fileDate;

                if (match1.Success)
                {
                    type = match1.Groups[1].Value.ToUpper();
                    int day = int.Parse(match1.Groups[2].Value);
                    int month = int.Parse(match1.Groups[3].Value);
                    int year = int.Parse(match1.Groups[4].Value);
                    fileDate = new DateTime(year, month, day);
                }
                else if (match2.Success)
                {
                    int day = int.Parse(match2.Groups[1].Value);
                    string monthAbbr = match2.Groups[2].Value;
                    int year = int.Parse(match2.Groups[3].Value);

                    // Convert month abbreviation (e.g. Sep → 9)
                    DateTime parsed;
                    if (!DateTime.TryParseExact($"{day:D2}-{monthAbbr}-{year}", "dd-MMM-yyyy",
                               System.Globalization.CultureInfo.InvariantCulture,
                               System.Globalization.DateTimeStyles.None, out parsed))
                        continue;

                    fileDate = parsed;
                    type = "SP"; // old format always procedure
                }
                else
                {
                    continue; // skip unknown format
                }

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

            // Sort TB first, then SP, by date
            return list
                .OrderBy(f => f.Date)
                .ThenBy(f => f.Type == "TB" ? 0 : 1)
                .ToList();
        }

        // folderPath: directory where .sql files exist
        //public static List<SqlFileInfo> GetSqlFilesAfterDate(string folderPath, DateTime lastUpdateDate)
        //{
        //    var files = Directory.GetFiles(folderPath, "*.sql");

        //    var list = new List<SqlFileInfo>();

        //    foreach (var file in files)
        //    {
        //        string fileName = Path.GetFileNameWithoutExtension(file); // e.g., TB_25-08-2025
        //                                                                  // Expected format: TB_dd-MM-yyyy or SP_dd-MM-yyyy
        //                                                                  // Adjust regex if your naming differs
        //        var match = Regex.Match(fileName, @"^(TB|SP)_(\d{2})-(\d{2})-(\d{4})$", RegexOptions.IgnoreCase);
        //        if (!match.Success) continue;

        //        string type = match.Groups[1].Value.ToUpper(); // TB or SP
        //        int day = int.Parse(match.Groups[2].Value);
        //        int month = int.Parse(match.Groups[3].Value);
        //        int year = int.Parse(match.Groups[4].Value);

        //        DateTime fileDate = new DateTime(year, month, day);

        //        if (fileDate > lastUpdateDate)
        //        {
        //            list.Add(new SqlFileInfo
        //            {
        //                Path = file,
        //                Date = fileDate,
        //                Type = type
        //            });
        //        }
        //    }

        //    // Sort TB first, then SP, and by date ascending
        //    return list
        //        .OrderBy(f => f.Date)
        //        .ThenBy(f => f.Type == "TB" ? 0 : 1) // TB before SP
        //        .ToList();
        //}
    }
}
