using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class clsCreateTrigger
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void CreateTrigger()
        {
            string strTableQuery = @"
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'after_MyTable_insert')
BEGIN
    DROP TRIGGER after_MyTable_insert;
END
GO
CREATE TRIGGER after_MyTable_insert
ON MyTable
AFTER INSERT
AS
BEGIN
    INSERT INTO MyTable_audit (Id, action, Date)
    SELECT id, 'INSERT', GETDATE() FROM INSERTED;
END;
GO
";
            C_Common.dbExecuteTrigger(strTableQuery);
          
        }
    }
}
