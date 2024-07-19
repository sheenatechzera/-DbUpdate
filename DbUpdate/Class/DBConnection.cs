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
        protected SqlConnection sqlcon = new SqlConnection();

        public DBConnection()
        {
            sqlcon = new SqlConnection(@"Data Source=" + servername + ";Initial Catalog=" + Dbname + ";Integrated Security=True;");

        }
    }
}