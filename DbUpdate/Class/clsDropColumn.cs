using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class clsDropColumn
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void DropColumn()
        {
            string strTableQuery = @"

             ALTER TABLE MyTable
            DROP COLUMN Gender;


";
            C_Common.dbExecute(strTableQuery);


        }
    }
}
