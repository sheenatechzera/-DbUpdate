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
    }
}
