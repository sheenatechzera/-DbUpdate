using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    internal class clsDbClear
    {
        clsCommonDb C_Common = new clsCommonDb();
        public void ClearMasterTable()
        {
            string strTableQuery = "DBMasterClear";
            C_Common.dbExecuteSP(strTableQuery);
        }
        public void ClearTransactionTable()
        {
            string strTableQuery = "DBTransactionClear";
            C_Common.dbExecuteSP(strTableQuery);
        }
        public void UpdateBranchIds(string newBranchId)
        {
            string strTableQuery = "DBUpdateBranchIds";
            C_Common.dbExecuteSPWithParameter(strTableQuery,newBranchId);
        }
    }
}
