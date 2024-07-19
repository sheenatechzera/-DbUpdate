using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class clsAlterColumnType
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void AlterColumnType()
        {
            string strTableQuery = @"

               ALTER TABLE MyTable ALTER COLUMN Gender varchar(50);


";
            C_Common.dbExecute(strTableQuery);


        }
    }
}
