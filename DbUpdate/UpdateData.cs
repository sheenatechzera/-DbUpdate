using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DbUpdate
{
    public partial class UpdateData : Form
    {
        public UpdateData()
        {
            InitializeComponent();
        }
        string connectionString = "";
   
        SqlConnection sqlconConnection = new SqlConnection();
        private void UpdateData_Load(object sender, EventArgs e)
        {
            rbtLocal.Checked = true;
            VersionInfo();
            LoadServer();
           
        }
        void LoadServer()
        {
            string strServer = ".\\sqlExpress";
            if (File.Exists(Application.StartupPath + "\\sys.txt"))
            {
                string DbData = File.ReadAllText(Application.StartupPath + "\\sys.txt"); ;
                string[] values = DbData.Split(',');

                strServer = values[0].Trim();
                txtServerName.Text = strServer;
                txtClearServerName.Text = strServer;
            }
        }
        public static string GitVersion { get; private set; }
         void VersionInfo()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gitversion.txt");
            if (File.Exists(filePath))
            {
                GitVersion = File.ReadAllText(filePath).Trim();
               
            }
            else
            {
                GitVersion = "Unknown";
            }
            lblVersionNo.Text = GitVersion;
        }
        bool isLoad = false;
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            isLoad = true;
            lblInfo.Text = "";
            string serverName = txtServerName.Text.Trim();
            DataTable dtDatabases = new DataTable();
            if (rbtLocal.Checked) // Local DB
            {
                // Local + Windows Auth
                connectionString = $"Server={serverName};Integrated Security=True;MultipleActiveResultSets=True;";

            }
            else if(rbtRemote.Checked) // Remote DB
            {
                string username = "sa";
                string password = "Tech-fin";
                connectionString = $"Server={serverName};User Id={username};Password={password};MultipleActiveResultSets=True;";

            }
           // connectionString = @"Server=" + serverName + " ;Integrated Security=true;";
         //   connectionString = "Server=DESKTOP-EPIDFH4\\SQLEXPRESS;Integrated Security=true;";
            // SQL query to get the list of databases
            string query = "SELECT name FROM sys.databases";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sdaadapter = new SqlDataAdapter(query, connection);
                    sdaadapter.SelectCommand.CommandType = CommandType.Text;
                    sdaadapter.Fill(dtDatabases);

                    if (dtDatabases.Rows.Count > 0)
                    {
                        cmbPrimaryDb.DataSource = null;
                        cmbPrimaryDb.DataSource = dtDatabases;
                        cmbPrimaryDb.ValueMember = "name";
                        cmbPrimaryDb.DisplayMember = "name";



                        cmbDatabase.DataSource = dtDatabases.Copy();
                        cmbDatabase.ValueMember = "name";
                        cmbDatabase.DisplayMember = "name";
                    }
                }
                isLoad = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }



        private void btn_UpdateTable_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTable clstable = new clsCreateTable();
                clstable.CreateTable();
                MessageBox.Show("Updated Succesfully");
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                DBConnection.servername = txtServerName.Text;
                DBConnection.Dbname = cmbDatabase.Text;
                DBConnection.LocalOrRemote = rbtLocal.Checked ? "Local" : "Remote";
                if (tbcntrlUpdate.SelectedTab.Name == "tbDbUpdater")
                    lblInfo.Text =
        "Stored procedures and Table changes will be updated to the " + cmbDatabase.SelectedValue.ToString() + " database.\r\n" +
        "Stored Procedures filename format ex: SP_06-08-2025\r\n" +
        "Tables filename format ex: TB_06-08-2025\r\n" +
        "Separate each query with GO.";

            }
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterTable clstable = new clsAlterTable();
                clstable.AlterTable();
                MessageBox.Show("Updated Succesfully");
            }
        }
        bool checkConnection()
        {
            bool isOk = true;
            if (txtServerName.Text == "")
            {
                isOk = false;
                MessageBox.Show("Please Enter Server Name");
            }
            else if (cmbDatabase.Text == "")
            {
                isOk = false;
                MessageBox.Show("Please Select a Database");
            }
            return isOk;
        }
        bool checkDbClearConnection()
        {
            bool isOk = true;
            if (txtClearServerName.Text == "")
            {
                isOk = false;
                MessageBox.Show("Please Enter Server Name");
            }
            else if (cmbClearDbName.Text == "")
            {
                isOk = false;
                MessageBox.Show("Please Select a Database");
            }
            return isOk;
        }

        private void btn_UpdateSp_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateSP clstable = new clsCreateSP();
                clstable.CreateStrdProcedure();
                MessageBox.Show("Updated Succesfully");
            }
        }
        private void btnType_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterColumnType clstable = new clsAlterColumnType();
                clstable.AlterColumnType();
                MessageBox.Show("Updated Succesfully");
            }
        }
        private void btnTrigger_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTrigger clsTriggger = new clsCreateTrigger();
                clsTriggger.CreateTrigger();
                MessageBox.Show("Updated Succesfully");
            }
        }
        private void btnDropColumn_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsDropColumn clsDrop = new clsDropColumn();
                clsDrop.DropColumn();
                MessageBox.Show("Updated Succesfully");
            }
        }

        private void btnUpdateDb_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTable clstable = new clsCreateTable();
                clstable.CreateTable();

                clsAlterTable clscolumn = new clsAlterTable();
                clscolumn.AlterTable();

                clsAlterColumnType clsType = new clsAlterColumnType();
                clsType.AlterColumnType();

                clsDropColumn clsDrop = new clsDropColumn();
                clsDrop.DropColumn();

                clsCreateTrigger clsTriggger = new clsCreateTrigger();
                clsTriggger.CreateTrigger();

                clsCreateSP clsP = new clsCreateSP();
                clsP.CreateStrdProcedure();

                MessageBox.Show("Updated Succesfully");

            }
        }
        byte[] logo = null;
        private void btnCreateDb_Click_1(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedValue == null || cmbCurrency.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please select currency");
            }
            else if (txtBranchId.Text=="")
            {
                MessageBox.Show("Please enter branchid");
                txtBranchId.Focus();
            }
            else if (txtBranchName.Text == "")
            {
                MessageBox.Show("Please enter branch name");
                txtBranchName.Focus();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username");
                txtUsername.Focus();
            }
            else if (txtPswrd.Text == "")
            {
                MessageBox.Show("Please enter password");
                txtPswrd.Focus();
            }
            else  if (CheckExistnaceOfCompanyName() == true)
            {
                MessageBox.Show("Company name already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBranchName.Focus();
                txtBranchName.SelectAll();
            }
            else
            {
                CompanyInfo InfoCompany = new CompanyInfo();
                CompanyPathInfo InfoPath = new CompanyPathInfo();
                BranchInfo InfoBranch = new BranchInfo();
                UserInfo InfoUser = new UserInfo();

                InfoCompany.CompanyName = txtBranchName.Text;
                InfoCompany.Extra1 = "";
                InfoCompany.Extra2 = "";

                InfoPath.BranchEnabled = false;
                InfoPath.CompanyName = txtBranchName.Text;
                InfoPath.Defaultt = false;
                InfoPath.Extra1 = "";
                InfoPath.Extra2 = "";

                InfoBranch.BranchName = txtBranchName.Text;
                InfoBranch.Address = "";
                InfoBranch.PhoneNo = "";
                InfoBranch.Fax = "";
                InfoBranch.Mobile = "";
                InfoBranch.Email = "";
                InfoBranch.Web = "";
                InfoBranch.StartDate = DateTime.Now;

                InfoBranch.TinNo = "";
                InfoBranch.CstNo = "";
                InfoBranch.PanNo = "";
                InfoBranch.CurrencyId = cmbCurrency.SelectedValue.ToString();
                // logo
                GetDefaultImage();
                InfoBranch.Logo = logo;
                InfoBranch.pinNo = "";
                InfoBranch.Extra1 = "";
                InfoBranch.Extra2 = "";
                //Company Name & Address Arabic
                InfoBranch.branchNameArabic = "";
                InfoBranch.AddressArabic = "";

                InfoBranch.StreetName = "";
                InfoBranch.StreetNameARB = "";
                InfoBranch.BiuldingNo = "";
                InfoBranch.BiuldingNoARB = "";
                InfoBranch.CityName = "";
                InfoBranch.CityNameARB = "";
                InfoBranch.District = "";
                InfoBranch.DistrictARB = "";
                InfoBranch.Country = "";
                InfoBranch.CountryARB = "";
                InfoBranch.AdditionalNumber = "";
                InfoBranch.AdditionalNumberARB = "";
                InfoBranch.PostalCode = "";
                InfoBranch.PostalCodeARB = "";
                InfoBranch.CRNumber = "";

                // Save , create company
                InfoUser.UserName = txtUsername.Text;
                InfoUser.Password = txtPswrd.Text;
                InfoUser.Extra1 = "";
                InfoUser.Extra2 = "";
                if (CreateCompany())
                {
                    DBConnection._BranchId = txtBranchId.Text;
                    DBConnection con = new DBConnection();
                    InfoPath.CompanyPath = path;
                    clsCreateCompany spCompany = new clsCreateCompany();
                    //adding company path
                    InfoPath.CompanyId = txtBranchId.Text;
                    spCompany.CompanyPathAdd(InfoPath);
                    InfoCompany.CompanyId = txtBranchId.Text;
                    // Adding company
                    spCompany.CompanyAdd(InfoCompany);
                    //adding branch
                    InfoBranch.BranchId = txtBranchId.Text;
               
                    InfoBranch.MainBranch = true;
                    spCompany.BranchAdd(InfoBranch);

                    // Adding user
                    InfoUser.UserId = "1";
                    InfoUser.BranchId = txtBranchId.Text;
                    InfoUser.Active = true;
                    InfoUser.UserGroupId = "0";
                    spCompany.UserEdit(InfoUser);
                 
                    MessageBox.Show("Company created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFunction();
                }
                else
                {                 
                    MessageBox.Show("Company creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBConnection._BranchId = "";
                    txtBranchId.Focus();
                }

            }
        }
        string path = "";
        public bool CreateCompany()
        {
            string _branchId = "";
            // Creating new company data base
            try
            {
                clsCreateCompany primarysp = new clsCreateCompany();
                _branchId = txtBranchId.Text;
                path = Application.StartupPath + "\\DB\\" + _branchId;
                //string oldPath = Application.StartupPath + "\\DB";
                DirectoryInfo drinfo = new DirectoryInfo(path);
                if (!drinfo.Exists)
                {
                    drinfo.Create();
                    FileInfo DestinationMDFinfo = new FileInfo(path + "\\DBFinacAccount.mdf");
                    FileInfo DestinationLDFinfo = new FileInfo(path + "\\DBFinacAccount_log.ldf");
                    string oldPath = path;
                    path = path.Replace(_branchId, "COMP");
                    FileInfo SourceMDFinfo = new FileInfo(path + "\\DBFinacAccount.mdf");
                    FileInfo SourceLDFinfo = new FileInfo(path + "\\DBFinacAccount_log.ldf");
                    File.Copy(SourceMDFinfo.ToString(), DestinationMDFinfo.ToString(), true);
                    File.Copy(SourceLDFinfo.ToString(), DestinationLDFinfo.ToString(), true);
                    path = oldPath;

                    // Get the current ACL of the file
                    FileSecurity fileSecurity = File.GetAccessControl(path + "\\DBFinacAccount.mdf");
                    FileSecurity fileSecuritylog = File.GetAccessControl(path + "\\DBFinacAccount_log.ldf");

                    // Define a new rule that grants Everyone full control
                    FileSystemAccessRule accessRule = new FileSystemAccessRule(
                        new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                        FileSystemRights.FullControl,
                        AccessControlType.Allow
                    );

                    // Add the new rule to the ACL
                    fileSecurity.AddAccessRule(accessRule);
                    fileSecuritylog.AddAccessRule(accessRule);

                    // Set the modified ACL back to the file
                    File.SetAccessControl(path + "\\DBFinacAccount.mdf", fileSecurity);
                    File.SetAccessControl(path + "\\DBFinacAccount_log.ldf", fileSecuritylog);
                    return true;
                }
                else
                {
                    MessageBox.Show(_branchId + " Folder already exists. Give another branch id");
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
            //return true;
        }
        public bool CheckExistnaceOfCompanyName()
        {
            //Check whether a company  name already exist in DB
            bool isExist = false;
            clsCreateCompany SpPrimary = new clsCreateCompany();
            isExist = SpPrimary.CompanyPathCheckExistanceOfName(txtBranchName.Text);            
            return isExist;
        }
        public void FillCurrency()
        {
            // To fill currency combo

            clsCreateCompany SpCompany = new clsCreateCompany();
            DataTable dtbl = new DataTable();
            cmbCurrency.DataSource = null;

            dtbl = SpCompany.CurrencyViewAll();

            for (int i = 0; i < dtbl.Columns.Count; ++i)
            {
                if (dtbl.Columns[i].Caption != "currencyId" && dtbl.Columns[i].Caption != "currencyName" && dtbl.Columns[i].Caption != "currencySymbol")
                {
                    dtbl.Columns.RemoveAt(i);
                    i--;
                }
            }
            cmbCurrency.DataSource = dtbl;
            cmbCurrency.DisplayMember = "currencySymbol";
            cmbCurrency.ValueMember = "currencyId";

            cmbCurrency.SelectedIndex = -1;

        }

        private void tbcntrlUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.servername = "";
            DBConnection.Dbname = "";
            cmbClearDbName.SelectedIndex = -1;
            cmbDatabase.SelectedIndex = -1;
            txtNewBranchId.Text = "";
            chkMaster.Checked = false;
            chkTransaction.Checked = false;
            clearFunction();

            if (tbcntrlUpdate.SelectedTab.Text == "Create Company")
            {
                DBConnection.CreateDb = true;
                FillCurrency();
            }
            else
            {
                DBConnection.CreateDb = false;
                DBConnection._BranchId = "";
            }

        }
        public void GetDefaultImage()
        {
            // To get deafult image
            // As we store default image in start up path,  we assign the file path as its path
            string strImagePath = "";

            strImagePath = Application.StartupPath + "\\logo.JPG";
            logo = ReadFile(strImagePath);
            //MemoryStream ms = new MemoryStream(logo);
            //Image newImage = Image.FromStream(ms);
            //pbLogo.Image = newImage;
            //pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        byte[] ReadFile(string strImagePath)
        {
            //Read image from the specified location 
            // return byte form image

            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(strImagePath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(strImagePath, FileMode.Open,
                                                    FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to 

            //supply number of bytes to read from file.
            //In this case we want to read entire file. 

            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void txtBranchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key (backspace, enter, etc.)
            // or a digit (0-9). If not, mark the event as handled.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void clearFunction()
        {
            txtBranchId.Text = "";
            txtBranchName.Text = "";
            cmbCurrency.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPswrd.Text = "";
            DBConnection._BranchId = "";
        }

        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UD1" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBranchId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UD2" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBranchName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UD3" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UD4" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPswrd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UD5" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearConnect_Click(object sender, EventArgs e)
        {
            string serverName = txtClearServerName.Text;
            DataTable dtDatabases = new DataTable();
            connectionString = @"Server=" + serverName + " ;Integrated Security=true;";

            // SQL query to get the list of databases
            string query = "SELECT name FROM sys.databases";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sdaadapter = new SqlDataAdapter(query, connection);
                    sdaadapter.SelectCommand.CommandType = CommandType.Text;
                    sdaadapter.Fill(dtDatabases);

                    if (dtDatabases.Rows.Count > 0)
                    {
                        cmbClearDbName.DataSource = dtDatabases;
                        cmbClearDbName.ValueMember = "name";
                        cmbClearDbName.DisplayMember = "name";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnClearDb_Click(object sender, EventArgs e)
        {
            clsDbClear clsClear = new clsDbClear();
            if (checkDbClearConnection())
            {
                if (chkMaster.Checked)
                {
                    clsClear.ClearMasterTable();
                }
                if (chkTransaction.Checked)
                {
                    clsClear.ClearTransactionTable();
                }
                MessageBox.Show("Db cleared successfully");
            }
        }

        private void btnUpdateNewBranch_Click(object sender, EventArgs e)
        {
            if (checkDbClearConnection())
            {
                if (!string.IsNullOrEmpty(txtNewBranchId.Text))
                {
                    string _newBranchId = "";
                    _newBranchId = txtNewBranchId.Text;
                    clsDbClear clsClear = new clsDbClear();
                    clsClear.UpdateBranchIds(_newBranchId);
                    MessageBox.Show("Branch Id updated Successfully");
                    txtNewBranchId.Text = "";
                }
                else
                    MessageBox.Show("Please enter branch id");
            }
        }

        private void cmbClearDbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.servername = txtClearServerName.Text;
            DBConnection.Dbname = cmbClearDbName.Text;
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                var updater = new clsDbUpdater();
                string customerId= txtxCustomerId.Text.Trim();
                if (customerId == "")
                {
                    MessageBox.Show("Please Enter Customer Id");
                }
                else
                {

                    string scriptPath = @"C:\SqlScripts";

                    if (!Directory.Exists(scriptPath))
                    {
                        MessageBox.Show("The script path does not exist: " + scriptPath,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // stop further execution
                    }

                    if (updater.RunUpdatesForCustomer(customerId, scriptPath, dtpFromDate.Value)) { 
                        MessageBox.Show(
             "Updation Completed Successfully From " + dtpFromDate.Value.ToString("yyyy-MM-dd"),
             "Success",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information 
         );
                }
else
                {
                    MessageBox.Show(
                        "Updation Failed. Please Check UpdateErrors.log in Directory",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning    
                    );
                }
            }
            }

        }
        string companyId = "";
        private void cmbPrimaryDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                if (checkConnection())
                {
                    try
                    {
                        DBConnection.servername = txtServerName.Text;
                        DBConnection.Dbname = cmbPrimaryDb.Text;
                        DBConnection.LocalOrRemote= rbtLocal.Checked ? "Local" : "Remote";
                        clsCreateCompany clsCompany = new clsCreateCompany();
                        DataTable dtblCompany = clsCompany.CompanyPathViewAll();

                        if (dtblCompany.Rows.Count > 0)
                        {
                            companyId = dtblCompany.Rows[0]["companyId"].ToString();
                            txtxCustomerId.Text = dtblCompany.Rows[0]["serialNo"].ToString();
                        }
                        else
                        {
                            txtxCustomerId.Text = "";
                        }
                    }
                    catch { }
                }
            }
        }

        private void rbtLocal_CheckedChanged(object sender, EventArgs e)
        {
            isLoad = true;
            txtServerName.Text = @".\SQLEXPRESS";
           // txtServerName.Enabled = false;
            cmbPrimaryDb.DataSource = null;
            cmbDatabase.DataSource = null;
            txtxCustomerId.Text = "";
            isLoad = false;
        }

        private void rbtRemote_CheckedChanged(object sender, EventArgs e)
        {
            isLoad = true;
            txtServerName.Text = "";
          //  txtServerName.Enabled = true;
            cmbPrimaryDb.DataSource = null;
            cmbDatabase.DataSource = null;
            txtxCustomerId.Text = "";
            isLoad = false;
        }
    }
    
}
