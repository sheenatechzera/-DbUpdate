using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    internal class clsCreateCompany
    {
        clsCommonDb C_Common = new clsCommonDb();
        public int CompanyPathGetMax()
        {
            int max = 0;
            string strTableQuery = "CompanyPathMax";
            max= C_Common.dbExecuteScalar(strTableQuery);
            return max;
        }
        public bool CompanyPathCheckExistanceOfName(string strcompanyname)
        {
            bool isExist = false;
            try
            {
                string strTableQuery = "CompanyPathCheckExistanceOfName";
                isExist = C_Common.dbExecuteScalarWithParameter(strTableQuery, strcompanyname);
            }
            catch (Exception ex)
            {
               
            }           
            return isExist;
        }
    }
}
