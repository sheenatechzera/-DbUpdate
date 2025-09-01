using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
//<summary>    
//Summary description for DBConnection    
//</summary>    
namespace DbUpdate
{
    public class DBConnection
    {
        public static string servername = "";
        public static string Dbname = "";
        public static bool CreateDb = false;
        public static string _BranchId = "";
        public static string LocalOrRemote = "";
        protected SqlConnection sqlcon = new SqlConnection();

        public DBConnection()
        {
            string path = "";
            string strServer = ".\\sqlExpress";
            string strSettings = "User ID=sa;Password=a;";
          

            try
            {
                if (CreateDb)
                {
                    if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                    {
                        sqlcon.Close();
                    }

                    if (!string.IsNullOrEmpty(_BranchId))
                    {
                        path = Path.Combine(Application.StartupPath, "DB", _BranchId, "DBFinacAccount.mdf");
                    }
                    else
                    {
                        path = Path.Combine(Application.StartupPath, "DB", "DBFinacAccount.mdf");
                    }

                    string connectionString = $@"Data Source={strServer};AttachDbFilename={path};{strSettings}";
                    sqlcon = new SqlConnection(connectionString);
                }
                else
                {
                    string connectionString = "";
                    if (LocalOrRemote == "Local")
                    {
                        servername = ".\\sqlExpress";
                        connectionString = $@"Data Source={servername};Initial Catalog={Dbname};Integrated Security=True;";
                    }
                    else
                    {
                        string username = "sa";
                        string password = "Tech-fin";
                       // servername = servername + "\\SQLEXPRESS";
                        connectionString = $"Server={servername};Initial Catalog={Dbname};User Id={username};Password={password};MultipleActiveResultSets=True;";
                    }
                    //string connectionString = $@"Data Source={servername};Initial Catalog={Dbname};Integrated Security=True;";
                    sqlcon = new SqlConnection(connectionString);

                  
                }

                sqlcon.Open();
                // Connection successful. You can perform further operations here.
            }
            catch (SqlException ex)
            {
                // Log and handle the error as needed
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }
    }
}