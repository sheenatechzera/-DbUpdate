using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            string strServer = ".\\sqlExpress";
            if (File.Exists(Application.StartupPath + "\\sys.txt"))
            {
                string DbData = File.ReadAllText(Application.StartupPath + "\\sys.txt"); ;
                string[] values = DbData.Split(',');

                strServer = values[0].Trim();
                txtServerName.Text = strServer;

            }
        }
        bool checkConnection()
        {
            bool isOk = true;
            if (DBConnection.servername == "")
            {
                isOk = false;
                MessageBox.Show("Please Enter Server Name");
            }
            else if (DBConnection.Dbname == "")
            {
                isOk = false;
                MessageBox.Show("Please Select a Database");
            }
            return isOk;
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

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

            DBConnection.servername = txtServerName.Text;
            DBConnection.Dbname = cmbDatabase.Text;
        }

        private void btn_UpdateTable_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTable clstable = new clsCreateTable();
                clstable.CreateTable();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnDropColumn_Click(object sender, EventArgs e)
        {

            if (checkConnection())
            {
                clsDropColumn clsDrop = new clsDropColumn();
                clsDrop.DropColumn();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterColumnType clstable = new clsAlterColumnType();
                clstable.AlterColumnType();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsAlterTable clstable = new clsAlterTable();
                clstable.AlterTable();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateTrigger clsTriggger = new clsCreateTrigger();
                clsTriggger.CreateTrigger();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btn_UpdateSp_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                clsCreateSP clstable = new clsCreateSP();
                clstable.CreateStrdProcedure();
                MessageBox.Show("Updated Successfully");
            }
        }
    }
}
