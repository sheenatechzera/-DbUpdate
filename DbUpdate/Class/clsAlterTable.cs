using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class clsAlterTable
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void AlterTable()
        {
            string strTableQuery = @"

                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
               WHERE TABLE_NAME = 'MyTable' AND COLUMN_NAME = 'Age')
				BEGIN
					ALTER TABLE MyTable
					ADD Age VARCHAR(100);
				END

-------------------------------------------------------------------
 IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
               WHERE TABLE_NAME = 'MyTable' AND COLUMN_NAME = 'Gender')
				BEGIN
					ALTER TABLE MyTable
					ADD Gender VARCHAR(100);
				END


";
            C_Common.dbExecute(strTableQuery);


        }
    }
}
