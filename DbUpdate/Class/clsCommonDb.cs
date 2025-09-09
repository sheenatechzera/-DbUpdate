using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DbUpdate
{
    class clsCommonDb : DBConnection
    {
        public void dbExecute(string strQuery)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(strQuery, GetOpenConnection()))
                {
                    command.ExecuteNonQuery();
                }
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
                using (SqlCommand command = new SqlCommand(strQuery, GetOpenConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void dbExecuteSPWithParameter(string strQuery, string parameter)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(strQuery, GetOpenConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@NewBranchId", SqlDbType.VarChar).Value = parameter;
                    command.ExecuteNonQuery();
                }
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
                string[] batches = strQuery.Split(new[] { "GO", "go", "Go" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string batch in batches)
                {
                    if (!string.IsNullOrWhiteSpace(batch))
                    {
                        using (SqlCommand command = new SqlCommand(batch, GetOpenConnection()))
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
                using (SqlCommand sccmd = new SqlCommand(strQuery, GetOpenConnection()))
                {
                    sccmd.CommandType = CommandType.StoredProcedure;
                    max = int.Parse(sccmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return max;
        }

        public bool dbExecuteScalarWithParameter(string strQuery, string strcompanyname)
        {
            try
            {
                using (SqlCommand sccmd = new SqlCommand(strQuery, GetOpenConnection()))
                {
                    sccmd.CommandType = CommandType.StoredProcedure;
                    sccmd.Parameters.Add("@companyName", SqlDbType.VarChar).Value = strcompanyname;

                    object obj = sccmd.ExecuteScalar();
                    return obj != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        public DataTable dbExecuteAdapter(string strQuery)
        {
            DataTable dtbl = new DataTable();
            try
            {
                using (SqlDataAdapter sqldataadapter = new SqlDataAdapter(strQuery, GetOpenConnection()))
                {
                    sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqldataadapter.Fill(dtbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return dtbl;
        }
    }
}
