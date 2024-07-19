using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbUpdate
{
    class clsCreateTable
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void CreateTable()
        {
            string strTableQuery = @"

                IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'MyTable')
                CREATE TABLE MyTable (
                Id INT PRIMARY KEY,
                Name NVARCHAR(50)
                );
                
-------------------------------------------
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'MyNewTable')
                CREATE TABLE MyNewTable (
                Id INT PRIMARY KEY,
                Name NVARCHAR(50)
                );

   IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'MyTable_audit')
                CREATE TABLE MyTable_audit (
                Id INT PRIMARY KEY,
                action varchar(50),
                Date Datetime
                );
";
            C_Common.dbExecute(strTableQuery);

           
        }
    }
}
