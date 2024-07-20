using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            label3.Text = GitVersion;
        }

    private void btn_Connect_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text;
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
                        cmbDatabase.DataSource = dtDatabases;
                        cmbDatabase.ValueMember = "name";
                        cmbDatabase.DisplayMember = "name";
                    }
                }
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
               
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

            DBConnection.servername = txtServerName.Text;
            DBConnection.Dbname = cmbDatabase.Text;
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterTable clstable = new clsAlterTable();
                clstable.AlterTable();
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

        private void btn_UpdateSp_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateSP clstable = new clsCreateSP();
                clstable.CreateStrdProcedure();
            }
        }

        private void btnCreateDb_Click(object sender, EventArgs e)
        {

        }

        private void btnType_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterColumnType clstable = new clsAlterColumnType();
                clstable.AlterColumnType();
            }
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTrigger clsTriggger = new clsCreateTrigger();
                clsTriggger.CreateTrigger();
            }
        }

        private void btnDropColumn_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsDropColumn clsDrop = new clsDropColumn();
                clsDrop.DropColumn();
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

        private void btnCreateDb_Click_1(object sender, EventArgs e)
        {
            if (CheckExistnaceOfCompanyName() == true)
            {
                MessageBox.Show("Company name already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBranchName.Focus();
                txtBranchName.SelectAll();
            }
            else
            {
                // Save , create company
                //InfoUser.UserName = txtUsername.Text;
                //InfoUser.Password = txtPswrd.Text;
                //InfoUser.Extra1 = "";
                //InfoUser.Extra2 = "";
                //if (MDIFinacAcount.demoProject || CreateCompany())
                //{
                    
                //        InfoPath.CompanyPath = path;
                    
                   
                //    PrimaryDBSP spPrimary = new PrimaryDBSP();
                //    CompanySP SpCompany = new CompanySP();
                //    UserSP SpUser = new UserSP();
                //    BranchSP SpBranch = new BranchSP();
                //    //adding company path
                //    InfoPath.CompanyId = PublicVariables._companyId;
                //    spPrimary.CompanyPathAdd(InfoPath);
                //    InfoCompany.CompanyId = PublicVariables._companyId;
                //    // Adding company
                //    SpCompany.CompanyAdd(InfoCompany);
                //    //adding branch
                //    InfoBranch.BranchId = PublicVariables._companyId;
                //    PublicVariables._currencyId = InfoBranch.CurrencyId;
                //    InfoBranch.MainBranch = true;
                //    SpBranch.BranchAdd(InfoBranch);



                //    // Adding user
                //    InfoUser.UserId = "1";
                //    InfoUser.BranchId = PublicVariables._companyId;
                //    InfoUser.Active = true;
                //    InfoUser.UserGroupId = "0";
                //    SpUser.UserEdit(InfoUser);
                //    PublicVariables._currencyId = InfoBranch.CurrencyId;
                //    PublicVariables._branchId = InfoBranch.BranchId;
                //    PublicVariables._currentUserId = "1";
                //    MessageBox.Show("Company created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmSaveFinancialYear frmfinace = new frmSaveFinancialYear();
                //    frmfinace.MdiParent = MDIFinacAcount.MDIObj;

                //    this.Close();
                //    frmfinace.CallThisFormFromCompanyCreation(true, cmbCurrency.SelectedValue.ToString());

                //}
                //else
                //{
                //    btnSave.Enabled = true;
                //    MessageBox.Show("Company creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }
        string path = "";
        public bool CreateCompany()
        {
            string _companyId = "";
            // Creating new company data base
            try
            {
                clsCreateCompany primarysp = new clsCreateCompany();
                _companyId = primarysp.CompanyPathGetMax().ToString();
                //if (MDIFinacAcount.DBConnectiontype!="Multi User-Client")
                //{
                // Server DB of multi user or single user system
                bool isExternalDrive = false;
                if (File.Exists(Application.StartupPath + "\\file.txt"))
                {
                    // checking whether entry in external dirve
                    // if DB is in external drive the path should be in file.txt of start up path
                    path = File.ReadAllText(Application.StartupPath + "\\file.txt");
                    if (path != null && path != "")
                    {
                        path = path + "\\Data\\" + _companyId;
                        isExternalDrive = true;
                    }
                }
                if (!isExternalDrive)
                {
                    // No DB in external Drive
                    //if (MDIFinacAcount.isEstimateDB && MDIFinacAcount.strEstimateCompanyPath != "")
                    //{
                    //    // checking whether working in estimate company
                    //    path = MDIFinacAcount.strEstimateCompanyPath + "\\Data\\" + PublicVariables._companyId;
                    //}
                    //else
                    //{
                    //    // working in actual company
                    //    path = Application.StartupPath + "\\Data\\" + PublicVariables._companyId;

                    //}
                }
                
                DirectoryInfo drinfo = new DirectoryInfo(path);
                if (!drinfo.Exists)
                {
                    drinfo.Create();
                }
                FileInfo DestinationMDFinfo = new FileInfo(path + "\\DBFinacAccount.mdf");
                FileInfo DestinationLDFinfo = new FileInfo(path + "\\DBFinacAccount_log.ldf");
                string oldPath = path;
                path = path.Replace(_companyId, "COMP");
                FileInfo SourceMDFinfo = new FileInfo(path + "\\DBFinacAccount.mdf");
                FileInfo SourceLDFinfo = new FileInfo(path + "\\DBFinacAccount_log.ldf");
                File.Copy(SourceMDFinfo.ToString(), DestinationMDFinfo.ToString(), true);
                File.Copy(SourceLDFinfo.ToString(), DestinationLDFinfo.ToString(), true);
                path = oldPath;

                return true;

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
    }
}
