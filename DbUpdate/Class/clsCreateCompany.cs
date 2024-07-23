using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbUpdate
{
    internal class clsCreateCompany : DBConnection
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
        public DataTable CurrencyViewAll()
        {

            DataTable dtbl = new DataTable();
            try
            {               
                string strQuery = "CurrencyViewAll";
                dtbl=C_Common.dbExecuteAdapter(strQuery);


            }
            catch (Exception ex)
            {
               
            }           

            return dtbl;
        }
        public void CompanyAdd(CompanyInfo companyinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.CompanyId;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra2;
                sccmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void UserEdit(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@branchId", SqlDbType.VarChar);
                sprmparam.Value = userinfo.BranchId;
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
                sprmparam = sccmd.Parameters.Add("@userGroupId", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserGroupId;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = userinfo.Active;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra2;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                sqlcon.Close();
            }

        }
        public string BranchAdd(BranchInfo branchinfo)
        {
            string branchId = "";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BranchAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@branchId", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.BranchId;
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNo", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.PhoneNo;
                sprmparam = sccmd.Parameters.Add("@fax", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.Fax;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.Email;
                sprmparam = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.Web;
                sprmparam = sccmd.Parameters.Add("@tinNo", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.TinNo;
                sprmparam = sccmd.Parameters.Add("@cstNo", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.CstNo;
                sprmparam = sccmd.Parameters.Add("@panNo", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.PanNo;
                sprmparam = sccmd.Parameters.Add("@logo", SqlDbType.Image);
                sprmparam.Value = branchinfo.Logo;
                sprmparam = sccmd.Parameters.Add("@startDate", SqlDbType.DateTime);
                sprmparam.Value = branchinfo.StartDate;
                sprmparam = sccmd.Parameters.Add("@pinNo", SqlDbType.VarChar);
                sprmparam.Value = branchinfo.pinNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@mainBranch", SqlDbType.Bit);
                sprmparam.Value = branchinfo.MainBranch;

                sprmparam = sccmd.Parameters.Add("@CRNumber", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.CRNumber;
                sprmparam = sccmd.Parameters.Add("@StreetName", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.StreetName;
                sprmparam = sccmd.Parameters.Add("@BiuldingNo", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.BiuldingNo;
                sprmparam = sccmd.Parameters.Add("@AdditionalNumber", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.AdditionalNumber;
                sprmparam = sccmd.Parameters.Add("@CityName", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.CityName;
                sprmparam = sccmd.Parameters.Add("@District", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.District;
                sprmparam = sccmd.Parameters.Add("@Country", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.Country;
                sprmparam = sccmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.PostalCode;
                sprmparam = sccmd.Parameters.Add("@branchNameArabic", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.branchNameArabic;
                sprmparam = sccmd.Parameters.Add("@AddressArabic", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.AddressArabic;
                sprmparam = sccmd.Parameters.Add("@StreetNameARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.StreetNameARB;
                sprmparam = sccmd.Parameters.Add("@BiuldingNoARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.BiuldingNoARB;
                sprmparam = sccmd.Parameters.Add("@AdditionalNumberARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.AdditionalNumberARB;
                sprmparam = sccmd.Parameters.Add("@CityNameARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.CityNameARB;
                sprmparam = sccmd.Parameters.Add("@DistrictARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.DistrictARB;
                sprmparam = sccmd.Parameters.Add("@CountryARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.CountryARB;
                sprmparam = sccmd.Parameters.Add("@PostalCodeARB", SqlDbType.NVarChar);
                sprmparam.Value = branchinfo.PostalCodeARB;

                branchId = sccmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return branchId;
        }
        public void CompanyPathAdd(CompanyPathInfo companypathinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyId;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@companyPath", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyPath;
                sprmparam = sccmd.Parameters.Add("@branchEnabled", SqlDbType.Bit);
                sprmparam.Value = companypathinfo.BranchEnabled;
                sprmparam = sccmd.Parameters.Add("@defaultt", SqlDbType.Bit);
                sprmparam.Value = companypathinfo.Defaultt;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra2;
                sccmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }

}
