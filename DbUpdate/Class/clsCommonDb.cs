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
    class clsCommonDb : DBConnection
    {
        public void dbExecute(string strQuery)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand command = new SqlCommand(strQuery, sqlcon);

                command.ExecuteNonQuery();
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void dbExecuteSP(string strQuery)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand command = new SqlCommand(strQuery, sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void dbExecuteSPWithParameter(string strQuery,string parameter)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand command = new SqlCommand(strQuery, sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = command.Parameters.Add("@NewBranchId", SqlDbType.VarChar);
                prm.Value = parameter;
                command.ExecuteNonQuery();
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void dbExecuteTrigger(string strQuery)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string[] batches = strQuery.Split(new[] { "GO", "go", "Go" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string batch in batches)
                {
                    if (!string.IsNullOrWhiteSpace(batch))
                    {
                        using (SqlCommand command = new SqlCommand(batch, sqlcon))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public int dbExecuteScalar(string strQuery)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand(strQuery, sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = int.Parse(sccmd.ExecuteScalar().ToString());
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                sqlcon.Close();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return max;
        }
        public bool dbExecuteScalarWithParameter(string strQuery, string strcompanyname)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand(strQuery, sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                prm = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                prm.Value = strcompanyname;
                object obj = sccmd.ExecuteScalar();
                sqlcon.Close();
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        public DataTable dbExecuteAdapter(string strQuery)
        {
            DataTable dtbl = new DataTable();
            try
            {                
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(strQuery, sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;            
                sqldataadapter.Fill(dtbl);
            
             }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
              
            }
            return dtbl;
        }
    }
}
