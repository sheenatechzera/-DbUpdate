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
    class clsGeneral:DBConnection
    {
        public void SalesinvoiceUpdateQrCode(string salesMasterId, string qr_link, SqlConnection sqlcon, SqlTransaction sqlTrans)
        {
            try
            {
                using (SqlCommand sccmd = new SqlCommand("SalesinvoiceUpdateQrCode", sqlcon, sqlTrans))
                {
                    sccmd.CommandType = CommandType.StoredProcedure;
                    sccmd.Parameters.Add("@salesMasterId", SqlDbType.VarChar).Value = salesMasterId;
                    sccmd.Parameters.Add("@qr_link", SqlDbType.NVarChar).Value = qr_link;

                    sccmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating QR code for invoice ID " + salesMasterId + ": " + ex.Message);
            }
        }

        public DataTable GetInvoicesWithoutQR( DateTime toDate)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT salesMasterId, date, totalAmount, totalTax,billTime 
 FROM tbl_SalesMaster
 WHERE (qr_link IS NULL OR qr_link = '')
   AND date <= @ToDate";

                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ToDate", toDate);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching invoices: " + ex.Message);
            }
            return dt;
        }

    }
}
