namespace DbUpdate
{
    partial class UpdateData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_UpdateTable = new System.Windows.Forms.Button();
            this.btn_UpdateSp = new System.Windows.Forms.Button();
            this.btnColumns = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnDropColumn = new System.Windows.Forms.Button();
            this.btnUpdateDb = new System.Windows.Forms.Button();
            this.lblVersionNo = new System.Windows.Forms.Label();
            this.tbcntrlUpdate = new System.Windows.Forms.TabControl();
            this.tbDbUpdater = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPrimaryDb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPswrd = new System.Windows.Forms.TextBox();
            this.lblPwrd = new System.Windows.Forms.Label();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpUpdateDb = new System.Windows.Forms.GroupBox();
            this.txtNewBranchId = new System.Windows.Forms.TextBox();
            this.lblNewBranchId = new System.Windows.Forms.Label();
            this.btnUpdateNewBranch = new System.Windows.Forms.Button();
            this.grpClearDb = new System.Windows.Forms.GroupBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkMaster = new System.Windows.Forms.CheckBox();
            this.btnClearDb = new System.Windows.Forms.Button();
            this.grpClearConnecr = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClearDbName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClearServerName = new System.Windows.Forms.TextBox();
            this.btnClearConnect = new System.Windows.Forms.Button();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.rbtRemote = new System.Windows.Forms.RadioButton();
            this.tbcntrlUpdate.SuspendLayout();
            this.tbDbUpdater.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpUpdateDb.SuspendLayout();
            this.grpClearDb.SuspendLayout();
            this.grpClearConnecr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UpdateTable
            // 
            this.btn_UpdateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateTable.Enabled = false;
            this.btn_UpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTable.Location = new System.Drawing.Point(4, 102);
            this.btn_UpdateTable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateTable.Name = "btn_UpdateTable";
            this.btn_UpdateTable.Size = new System.Drawing.Size(133, 50);
            this.btn_UpdateTable.TabIndex = 1;
            this.btn_UpdateTable.Text = "Update Table";
            this.btn_UpdateTable.UseVisualStyleBackColor = false;
            this.btn_UpdateTable.Click += new System.EventHandler(this.btn_UpdateTable_Click);
            // 
            // btn_UpdateSp
            // 
            this.btn_UpdateSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateSp.Enabled = false;
            this.btn_UpdateSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSp.Location = new System.Drawing.Point(144, 210);
            this.btn_UpdateSp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateSp.Name = "btn_UpdateSp";
            this.btn_UpdateSp.Size = new System.Drawing.Size(193, 50);
            this.btn_UpdateSp.TabIndex = 2;
            this.btn_UpdateSp.Text = "Update Stored Procedure";
            this.btn_UpdateSp.UseVisualStyleBackColor = false;
            this.btn_UpdateSp.Click += new System.EventHandler(this.btn_UpdateSp_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnColumns.Enabled = false;
            this.btnColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumns.Location = new System.Drawing.Point(4, 155);
            this.btnColumns.Margin = new System.Windows.Forms.Padding(4);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(133, 50);
            this.btnColumns.TabIndex = 8;
            this.btnColumns.Text = "Update Columns";
            this.btnColumns.UseVisualStyleBackColor = false;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnType.Enabled = false;
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(145, 103);
            this.btnType.Margin = new System.Windows.Forms.Padding(4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(193, 48);
            this.btnType.TabIndex = 9;
            this.btnType.Text = "Update Column Type";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnTrigger.Enabled = false;
            this.btnTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrigger.Location = new System.Drawing.Point(145, 156);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(192, 50);
            this.btnTrigger.TabIndex = 10;
            this.btnTrigger.Text = "Create Triggers";
            this.btnTrigger.UseVisualStyleBackColor = false;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnDropColumn
            // 
            this.btnDropColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnDropColumn.Enabled = false;
            this.btnDropColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropColumn.Location = new System.Drawing.Point(4, 210);
            this.btnDropColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropColumn.Name = "btnDropColumn";
            this.btnDropColumn.Size = new System.Drawing.Size(132, 50);
            this.btnDropColumn.TabIndex = 11;
            this.btnDropColumn.Text = "Drop Column";
            this.btnDropColumn.UseVisualStyleBackColor = false;
            this.btnDropColumn.Click += new System.EventHandler(this.btnDropColumn_Click);
            // 
            // btnUpdateDb
            // 
            this.btnUpdateDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnUpdateDb.Enabled = false;
            this.btnUpdateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDb.Location = new System.Drawing.Point(346, 104);
            this.btnUpdateDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDb.Name = "btnUpdateDb";
            this.btnUpdateDb.Size = new System.Drawing.Size(214, 50);
            this.btnUpdateDb.TabIndex = 13;
            this.btnUpdateDb.Text = "Update DB";
            this.btnUpdateDb.UseVisualStyleBackColor = false;
            this.btnUpdateDb.Click += new System.EventHandler(this.btnUpdateDb_Click);
            // 
            // lblVersionNo
            // 
            this.lblVersionNo.AutoSize = true;
            this.lblVersionNo.Location = new System.Drawing.Point(434, 172);
            this.lblVersionNo.Name = "lblVersionNo";
            this.lblVersionNo.Size = new System.Drawing.Size(0, 17);
            this.lblVersionNo.TabIndex = 14;
            // 
            // tbcntrlUpdate
            // 
            this.tbcntrlUpdate.Controls.Add(this.tbDbUpdater);
            this.tbcntrlUpdate.Controls.Add(this.tabPage1);
            this.tbcntrlUpdate.Controls.Add(this.tabPage2);
            this.tbcntrlUpdate.Controls.Add(this.tabPage3);
            this.tbcntrlUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbcntrlUpdate.Location = new System.Drawing.Point(12, 12);
            this.tbcntrlUpdate.Name = "tbcntrlUpdate";
            this.tbcntrlUpdate.SelectedIndex = 0;
            this.tbcntrlUpdate.Size = new System.Drawing.Size(667, 327);
            this.tbcntrlUpdate.TabIndex = 0;
            this.tbcntrlUpdate.SelectedIndexChanged += new System.EventHandler(this.tbcntrlUpdate_SelectedIndexChanged);
            // 
            // tbDbUpdater
            // 
            this.tbDbUpdater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.tbDbUpdater.Controls.Add(this.lblInfo);
            this.tbDbUpdater.Controls.Add(this.dtpFromDate);
            this.tbDbUpdater.Controls.Add(this.lblFromDate);
            this.tbDbUpdater.Controls.Add(this.btnUpdateAll);
            this.tbDbUpdater.Controls.Add(this.groupBox1);
            this.tbDbUpdater.Location = new System.Drawing.Point(4, 25);
            this.tbDbUpdater.Name = "tbDbUpdater";
            this.tbDbUpdater.Padding = new System.Windows.Forms.Padding(3);
            this.tbDbUpdater.Size = new System.Drawing.Size(659, 298);
            this.tbDbUpdater.TabIndex = 3;
            this.tbDbUpdater.Text = "Db Updater";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblInfo.Location = new System.Drawing.Point(26, 205);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 17;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(161, 165);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(142, 23);
            this.dtpFromDate.TabIndex = 16;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFromDate.Location = new System.Drawing.Point(14, 165);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(139, 17);
            this.lblFromDate.TabIndex = 15;
            this.lblFromDate.Text = "Updation from Date :";
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnUpdateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.Location = new System.Drawing.Point(403, 159);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(176, 39);
            this.btnUpdateAll.TabIndex = 14;
            this.btnUpdateAll.Text = "Update Database";
            this.btnUpdateAll.UseVisualStyleBackColor = false;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRemote);
            this.groupBox1.Controls.Add(this.rbtLocal);
            this.groupBox1.Controls.Add(this.txtxCustomerId);
            this.groupBox1.Controls.Add(this.lblCustId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbPrimaryDb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDatabase);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txtxCustomerId
            // 
            this.txtxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtxCustomerId.Location = new System.Drawing.Point(502, 80);
            this.txtxCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtxCustomerId.Name = "txtxCustomerId";
            this.txtxCustomerId.Size = new System.Drawing.Size(138, 23);
            this.txtxCustomerId.TabIndex = 15;
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustId.Location = new System.Drawing.Point(411, 82);
            this.lblCustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(91, 17);
            this.lblCustId.TabIndex = 10;
            this.lblCustId.Text = "Customer Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(7, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Select Primary Database:";
            // 
            // cmbPrimaryDb
            // 
            this.cmbPrimaryDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPrimaryDb.FormattingEnabled = true;
            this.cmbPrimaryDb.Location = new System.Drawing.Point(175, 79);
            this.cmbPrimaryDb.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrimaryDb.Name = "cmbPrimaryDb";
            this.cmbPrimaryDb.Size = new System.Drawing.Size(235, 24);
            this.cmbPrimaryDb.TabIndex = 9;
            this.cmbPrimaryDb.SelectedIndexChanged += new System.EventHandler(this.cmbPrimaryDb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Name :";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServerName.Location = new System.Drawing.Point(173, 46);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(237, 23);
            this.txtServerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Database:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(175, 111);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(235, 24);
            this.cmbDatabase.TabIndex = 7;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(412, 42);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(115, 31);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnUpdateDb);
            this.tabPage1.Controls.Add(this.lblVersionNo);
            this.tabPage1.Controls.Add(this.btn_UpdateSp);
            this.tabPage1.Controls.Add(this.btn_UpdateTable);
            this.tabPage1.Controls.Add(this.btnDropColumn);
            this.tabPage1.Controls.Add(this.btnColumns);
            this.tabPage1.Controls.Add(this.btnTrigger);
            this.tabPage1.Controls.Add(this.btnType);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update Db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Version :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.tabPage2.Controls.Add(this.cmbCurrency);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUsername);
            this.tabPage2.Controls.Add(this.lblUsername);
            this.tabPage2.Controls.Add(this.txtPswrd);
            this.tabPage2.Controls.Add(this.lblPwrd);
            this.tabPage2.Controls.Add(this.btnCreateDb);
            this.tabPage2.Controls.Add(this.txtBranchName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtBranchId);
            this.tabPage2.Controls.Add(this.lblBranchId);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Company";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(111, 20);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(172, 24);
            this.cmbCurrency.TabIndex = 0;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Currency :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(394, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.Location = new System.Drawing.Point(289, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username :";
            // 
            // txtPswrd
            // 
            this.txtPswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPswrd.Location = new System.Drawing.Point(394, 49);
            this.txtPswrd.Name = "txtPswrd";
            this.txtPswrd.PasswordChar = '*';
            this.txtPswrd.Size = new System.Drawing.Size(172, 23);
            this.txtPswrd.TabIndex = 4;
            this.txtPswrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPswrd_KeyDown);
            // 
            // lblPwrd
            // 
            this.lblPwrd.AutoSize = true;
            this.lblPwrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPwrd.Location = new System.Drawing.Point(289, 49);
            this.lblPwrd.Name = "lblPwrd";
            this.lblPwrd.Size = new System.Drawing.Size(77, 17);
            this.lblPwrd.TabIndex = 8;
            this.lblPwrd.Text = "Password :";
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnCreateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDb.Location = new System.Drawing.Point(348, 102);
            this.btnCreateDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(221, 38);
            this.btnCreateDb.TabIndex = 10;
            this.btnCreateDb.Text = "Create Company";
            this.btnCreateDb.UseVisualStyleBackColor = false;
            this.btnCreateDb.Click += new System.EventHandler(this.btnCreateDb_Click_1);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBranchName.Location = new System.Drawing.Point(111, 77);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(172, 23);
            this.txtBranchName.TabIndex = 2;
            this.txtBranchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBranchName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Branch Name :";
            // 
            // txtBranchId
            // 
            this.txtBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBranchId.Location = new System.Drawing.Point(111, 49);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(172, 23);
            this.txtBranchId.TabIndex = 1;
            this.txtBranchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBranchId_KeyDown);
            this.txtBranchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBranchId_KeyPress);
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBranchId.Location = new System.Drawing.Point(6, 49);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(76, 17);
            this.lblBranchId.TabIndex = 6;
            this.lblBranchId.Text = "Branch Id :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.tabPage3.Controls.Add(this.grpUpdateDb);
            this.tabPage3.Controls.Add(this.grpClearDb);
            this.tabPage3.Controls.Add(this.grpClearConnecr);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clear Db";
            // 
            // grpUpdateDb
            // 
            this.grpUpdateDb.Controls.Add(this.txtNewBranchId);
            this.grpUpdateDb.Controls.Add(this.lblNewBranchId);
            this.grpUpdateDb.Controls.Add(this.btnUpdateNewBranch);
            this.grpUpdateDb.Location = new System.Drawing.Point(23, 173);
            this.grpUpdateDb.Name = "grpUpdateDb";
            this.grpUpdateDb.Size = new System.Drawing.Size(493, 59);
            this.grpUpdateDb.TabIndex = 21;
            this.grpUpdateDb.TabStop = false;
            // 
            // txtNewBranchId
            // 
            this.txtNewBranchId.Location = new System.Drawing.Point(130, 22);
            this.txtNewBranchId.Name = "txtNewBranchId";
            this.txtNewBranchId.Size = new System.Drawing.Size(210, 23);
            this.txtNewBranchId.TabIndex = 16;
            // 
            // lblNewBranchId
            // 
            this.lblNewBranchId.AutoSize = true;
            this.lblNewBranchId.Location = new System.Drawing.Point(13, 25);
            this.lblNewBranchId.Name = "lblNewBranchId";
            this.lblNewBranchId.Size = new System.Drawing.Size(107, 17);
            this.lblNewBranchId.TabIndex = 17;
            this.lblNewBranchId.Text = "New Branch Id :";
            // 
            // btnUpdateNewBranch
            // 
            this.btnUpdateNewBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnUpdateNewBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNewBranch.Location = new System.Drawing.Point(343, 16);
            this.btnUpdateNewBranch.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateNewBranch.Name = "btnUpdateNewBranch";
            this.btnUpdateNewBranch.Size = new System.Drawing.Size(143, 35);
            this.btnUpdateNewBranch.TabIndex = 18;
            this.btnUpdateNewBranch.Text = "Update Database";
            this.btnUpdateNewBranch.UseVisualStyleBackColor = false;
            this.btnUpdateNewBranch.Click += new System.EventHandler(this.btnUpdateNewBranch_Click);
            // 
            // grpClearDb
            // 
            this.grpClearDb.Controls.Add(this.chkTransaction);
            this.grpClearDb.Controls.Add(this.chkMaster);
            this.grpClearDb.Controls.Add(this.btnClearDb);
            this.grpClearDb.Location = new System.Drawing.Point(23, 104);
            this.grpClearDb.Name = "grpClearDb";
            this.grpClearDb.Size = new System.Drawing.Size(493, 63);
            this.grpClearDb.TabIndex = 20;
            this.grpClearDb.TabStop = false;
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(175, 22);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(165, 21);
            this.chkTransaction.TabIndex = 14;
            this.chkTransaction.Text = "Clear All Transactions";
            this.chkTransaction.UseVisualStyleBackColor = true;
            // 
            // chkMaster
            // 
            this.chkMaster.AutoSize = true;
            this.chkMaster.Location = new System.Drawing.Point(16, 22);
            this.chkMaster.Name = "chkMaster";
            this.chkMaster.Size = new System.Drawing.Size(154, 21);
            this.chkMaster.TabIndex = 13;
            this.chkMaster.Text = "Clear Master Tables";
            this.chkMaster.UseVisualStyleBackColor = true;
            // 
            // btnClearDb
            // 
            this.btnClearDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnClearDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDb.Location = new System.Drawing.Point(342, 14);
            this.btnClearDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDb.Name = "btnClearDb";
            this.btnClearDb.Size = new System.Drawing.Size(143, 35);
            this.btnClearDb.TabIndex = 15;
            this.btnClearDb.Text = "Clear Database";
            this.btnClearDb.UseVisualStyleBackColor = false;
            this.btnClearDb.Click += new System.EventHandler(this.btnClearDb_Click);
            // 
            // grpClearConnecr
            // 
            this.grpClearConnecr.Controls.Add(this.label6);
            this.grpClearConnecr.Controls.Add(this.cmbClearDbName);
            this.grpClearConnecr.Controls.Add(this.label7);
            this.grpClearConnecr.Controls.Add(this.txtClearServerName);
            this.grpClearConnecr.Controls.Add(this.btnClearConnect);
            this.grpClearConnecr.Location = new System.Drawing.Point(23, 6);
            this.grpClearConnecr.Name = "grpClearConnecr";
            this.grpClearConnecr.Size = new System.Drawing.Size(493, 92);
            this.grpClearConnecr.TabIndex = 19;
            this.grpClearConnecr.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Server Name :";
            // 
            // cmbClearDbName
            // 
            this.cmbClearDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbClearDbName.FormattingEnabled = true;
            this.cmbClearDbName.Location = new System.Drawing.Point(124, 56);
            this.cmbClearDbName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClearDbName.Name = "cmbClearDbName";
            this.cmbClearDbName.Size = new System.Drawing.Size(210, 24);
            this.cmbClearDbName.TabIndex = 12;
            this.cmbClearDbName.SelectedIndexChanged += new System.EventHandler(this.cmbClearDbName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Database:";
            // 
            // txtClearServerName
            // 
            this.txtClearServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtClearServerName.Location = new System.Drawing.Point(124, 25);
            this.txtClearServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClearServerName.Name = "txtClearServerName";
            this.txtClearServerName.Size = new System.Drawing.Size(210, 23);
            this.txtClearServerName.TabIndex = 8;
            // 
            // btnClearConnect
            // 
            this.btnClearConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnClearConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConnect.Location = new System.Drawing.Point(342, 23);
            this.btnClearConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearConnect.Name = "btnClearConnect";
            this.btnClearConnect.Size = new System.Drawing.Size(143, 35);
            this.btnClearConnect.TabIndex = 10;
            this.btnClearConnect.Text = "Connect";
            this.btnClearConnect.UseVisualStyleBackColor = false;
            this.btnClearConnect.Click += new System.EventHandler(this.btnClearConnect_Click);
            // 
            // rbtLocal
            // 
            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Location = new System.Drawing.Point(40, 15);
            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Size = new System.Drawing.Size(60, 21);
            this.rbtLocal.TabIndex = 16;
            this.rbtLocal.TabStop = true;
            this.rbtLocal.Text = "Local";
            this.rbtLocal.UseVisualStyleBackColor = true;
            this.rbtLocal.CheckedChanged += new System.EventHandler(this.rbtLocal_CheckedChanged);
            // 
            // rbtRemote
            // 
            this.rbtRemote.AutoSize = true;
            this.rbtRemote.Location = new System.Drawing.Point(155, 15);
            this.rbtRemote.Name = "rbtRemote";
            this.rbtRemote.Size = new System.Drawing.Size(75, 21);
            this.rbtRemote.TabIndex = 17;
            this.rbtRemote.TabStop = true;
            this.rbtRemote.Text = "Remote";
            this.rbtRemote.UseVisualStyleBackColor = true;
            this.rbtRemote.CheckedChanged += new System.EventHandler(this.rbtRemote_CheckedChanged);
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(683, 342);
            this.Controls.Add(this.tbcntrlUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Data";
            this.Load += new System.EventHandler(this.UpdateData_Load);
            this.tbcntrlUpdate.ResumeLayout(false);
            this.tbDbUpdater.ResumeLayout(false);
            this.tbDbUpdater.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpUpdateDb.ResumeLayout(false);
            this.grpUpdateDb.PerformLayout();
            this.grpClearDb.ResumeLayout(false);
            this.grpClearDb.PerformLayout();
            this.grpClearConnecr.ResumeLayout(false);
            this.grpClearConnecr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_UpdateTable;
        private System.Windows.Forms.Button btn_UpdateSp;
        private System.Windows.Forms.Button btnColumns;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnDropColumn;
        private System.Windows.Forms.Button btnUpdateDb;
        private System.Windows.Forms.Label lblVersionNo;
        private System.Windows.Forms.TabControl tbcntrlUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPswrd;
        private System.Windows.Forms.Label lblPwrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClearServerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClearDbName;
        private System.Windows.Forms.Button btnClearConnect;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkMaster;
        private System.Windows.Forms.Button btnClearDb;
        private System.Windows.Forms.Label lblNewBranchId;
        private System.Windows.Forms.TextBox txtNewBranchId;
        private System.Windows.Forms.Button btnUpdateNewBranch;
        private System.Windows.Forms.GroupBox grpUpdateDb;
        private System.Windows.Forms.GroupBox grpClearDb;
        private System.Windows.Forms.GroupBox grpClearConnecr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbDbUpdater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPrimaryDb;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.TextBox txtxCustomerId;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rbtRemote;
        private System.Windows.Forms.RadioButton rbtLocal;
    }
}

