using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUpdate
{
    class FinanceSettingsSP : DBConnection
    {
        public FinanceSettingsInfo FinanceSettingsViewAll(string branchid)
        {
            FinanceSettingsInfo infoFinanceSettings = new FinanceSettingsInfo();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmda = new SqlCommand("FinanceSettingsViewAll", sqlcon);
                sccmda.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparama = new SqlParameter();
                sprmparama = sccmda.Parameters.Add("@branchId", SqlDbType.VarChar);
                sprmparama.Value = branchid;

                SqlDataReader sdrreadera = sccmda.ExecuteReader();
                while (sdrreadera.Read())
                {
                    infoFinanceSettings.FinanceSettingsId = int.Parse(sdrreadera["FinanceSettingsId"].ToString());
                    infoFinanceSettings.ActivateTax = bool.Parse(sdrreadera["ActivateTax"].ToString());
                    infoFinanceSettings.BillByBill = bool.Parse(sdrreadera["BillByBill"].ToString());
                    infoFinanceSettings.ActivateInterstCalc = bool.Parse(sdrreadera["ActivateInterstCalc"].ToString());
                    infoFinanceSettings.UseMultiCurrency = bool.Parse(sdrreadera["UseMultiCurrency"].ToString());

                    infoFinanceSettings.SufPrefixVoucherNoGen = bool.Parse(sdrreadera["SufPrefixVoucherNoGen"].ToString());
                    infoFinanceSettings.ActivateCosteCentre = bool.Parse(sdrreadera["ActivateCosteCentre"].ToString());

                    infoFinanceSettings.NegativeCashTransaction = sdrreadera["NegativeCashTransaction"].ToString();
                    infoFinanceSettings.AccountsCalcMethod = sdrreadera["AccountsCalcMethod"].ToString();
                    infoFinanceSettings.TaxType = sdrreadera["TaxType"].ToString();
                    infoFinanceSettings.FormType = sdrreadera["FormType"].ToString();
                    infoFinanceSettings.VatIncluded = bool.Parse(sdrreadera["VatIncluded"].ToString());
                    infoFinanceSettings.VatandCessIncluded = bool.Parse(sdrreadera["VatandCessIncluded"].ToString());
                    infoFinanceSettings.BranchId = sdrreadera["branchId"].ToString();

                    infoFinanceSettings.extra1 = sdrreadera["extra1"].ToString();
                    infoFinanceSettings.AccountsPosting = bool.Parse(sdrreadera["AccountsPosting"].ToString());
                    infoFinanceSettings.ZatcaType = sdrreadera["ZatcaType"].ToString();

                    infoFinanceSettings.ShowCompanyHeader = bool.Parse(sdrreadera["ShowCompanyHeader"].ToString());
                    infoFinanceSettings.ShowCompanyFooter = bool.Parse(sdrreadera["ShowCompanyFooter"].ToString());
                    try
                    {
                        byte[] Header = (byte[])sdrreadera["CompanyHeader"];
                        infoFinanceSettings.CompanyHeader = Header;
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        byte[] Footer = (byte[])sdrreadera["CompanyFooter"];
                        infoFinanceSettings.CompanyFooter = Footer;
                    }
                    catch (Exception)
                    {
                    }
                    infoFinanceSettings.RoundDecimal = int.Parse(sdrreadera["RoundDecimal"].ToString());
                    string dec = "0";
                    infoFinanceSettings.RoundDecimalPart = "#" + dec + "." + dec.PadLeft(FinanceSettingsInfo._roundDecimal, '0');
                    infoFinanceSettings.EnablePOS = bool.Parse(sdrreadera["EnablePOS"].ToString());
                    infoFinanceSettings.Userdef1 = sdrreadera["Userdef1"].ToString();
                    infoFinanceSettings.Userdef2 = sdrreadera["Userdef2"].ToString();
                    infoFinanceSettings.Userdef3 = sdrreadera["Userdef3"].ToString();
                    infoFinanceSettings.Userdef4 = sdrreadera["Userdef4"].ToString();
                    infoFinanceSettings.DateFormat = sdrreadera["DateFormat"].ToString();
                    infoFinanceSettings.PaymentMode = sdrreadera["PaymentMode"].ToString();
                    infoFinanceSettings.ShowReminder = bool.Parse(sdrreadera["ShowReminder"].ToString());
                }
                sdrreadera.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                sqlcon.Close();
            }
            return infoFinanceSettings;

        }
    }
}
