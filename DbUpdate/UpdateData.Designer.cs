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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnColumns = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnDropColumn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcntrlUpdate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.txtPswrd = new System.Windows.Forms.TextBox();
            this.lblPwrd = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbcntrlUpdate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UpdateTable
            // 
            this.btn_UpdateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTable.Location = new System.Drawing.Point(4, 159);
            this.btn_UpdateTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateTable.Name = "btn_UpdateTable";
            this.btn_UpdateTable.Size = new System.Drawing.Size(133, 47);
            this.btn_UpdateTable.TabIndex = 1;
            this.btn_UpdateTable.Text = "Update Table";
            this.btn_UpdateTable.UseVisualStyleBackColor = false;
            this.btn_UpdateTable.Click += new System.EventHandler(this.btn_UpdateTable_Click);
            // 
            // btn_UpdateSp
            // 
            this.btn_UpdateSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSp.Location = new System.Drawing.Point(339, 104);
            this.btn_UpdateSp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateSp.Name = "btn_UpdateSp";
            this.btn_UpdateSp.Size = new System.Drawing.Size(214, 50);
            this.btn_UpdateSp.TabIndex = 2;
            this.btn_UpdateSp.Text = "Update Stored Procedure";
            this.btn_UpdateSp.UseVisualStyleBackColor = false;
            this.btn_UpdateSp.Click += new System.EventHandler(this.btn_UpdateSp_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServerName.Location = new System.Drawing.Point(122, 17);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(210, 23);
            this.txtServerName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Name :";
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(340, 17);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(115, 39);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 58);
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
            this.cmbDatabase.Location = new System.Drawing.Point(124, 55);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(205, 24);
            this.cmbDatabase.TabIndex = 7;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // btnColumns
            // 
            this.btnColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumns.Location = new System.Drawing.Point(4, 212);
            this.btnColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(145, 154);
            this.btnType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(184, 50);
            this.btnType.TabIndex = 9;
            this.btnType.Text = "Update Column Type";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrigger.Location = new System.Drawing.Point(145, 210);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(184, 50);
            this.btnTrigger.TabIndex = 10;
            this.btnTrigger.Text = "Create Triggers";
            this.btnTrigger.UseVisualStyleBackColor = false;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnDropColumn
            // 
            this.btnDropColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnDropColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropColumn.Location = new System.Drawing.Point(145, 102);
            this.btnDropColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDropColumn.Name = "btnDropColumn";
            this.btnDropColumn.Size = new System.Drawing.Size(184, 50);
            this.btnDropColumn.TabIndex = 11;
            this.btnDropColumn.Text = "Drop Column";
            this.btnDropColumn.UseVisualStyleBackColor = false;
            this.btnDropColumn.Click += new System.EventHandler(this.btnDropColumn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDatabase);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 91);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateDb
            // 
            this.btnUpdateDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnUpdateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDb.Location = new System.Drawing.Point(339, 156);
            this.btnUpdateDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDb.Name = "btnUpdateDb";
            this.btnUpdateDb.Size = new System.Drawing.Size(214, 50);
            this.btnUpdateDb.TabIndex = 13;
            this.btnUpdateDb.Text = "Update DB";
            this.btnUpdateDb.UseVisualStyleBackColor = false;
            this.btnUpdateDb.Click += new System.EventHandler(this.btnUpdateDb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // tbcntrlUpdate
            // 
            this.tbcntrlUpdate.Controls.Add(this.tabPage1);
            this.tbcntrlUpdate.Controls.Add(this.tabPage2);
            this.tbcntrlUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbcntrlUpdate.Location = new System.Drawing.Point(12, 12);
            this.tbcntrlUpdate.Name = "tbcntrlUpdate";
            this.tbcntrlUpdate.SelectedIndex = 0;
            this.tbcntrlUpdate.Size = new System.Drawing.Size(584, 304);
            this.tbcntrlUpdate.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnUpdateDb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_UpdateSp);
            this.tabPage1.Controls.Add(this.btn_UpdateTable);
            this.tabPage1.Controls.Add(this.btnDropColumn);
            this.tabPage1.Controls.Add(this.btnColumns);
            this.tabPage1.Controls.Add(this.btnTrigger);
            this.tabPage1.Controls.Add(this.btnType);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update Db";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(576, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Company";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBranchId.Location = new System.Drawing.Point(6, 20);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(76, 17);
            this.lblBranchId.TabIndex = 0;
            this.lblBranchId.Text = "Branch Id :";
            // 
            // txtBranchId
            // 
            this.txtBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBranchId.Location = new System.Drawing.Point(111, 20);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(221, 23);
            this.txtBranchId.TabIndex = 1;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBranchName.Location = new System.Drawing.Point(111, 48);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(221, 23);
            this.txtBranchName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branch Name :";
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnCreateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDb.Location = new System.Drawing.Point(111, 136);
            this.btnCreateDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(221, 38);
            this.btnCreateDb.TabIndex = 4;
            this.btnCreateDb.Text = "Create Company";
            this.btnCreateDb.UseVisualStyleBackColor = false;
            this.btnCreateDb.Click += new System.EventHandler(this.btnCreateDb_Click_1);
            // 
            // txtPswrd
            // 
            this.txtPswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPswrd.Location = new System.Drawing.Point(111, 106);
            this.txtPswrd.Name = "txtPswrd";
            this.txtPswrd.Size = new System.Drawing.Size(221, 23);
            this.txtPswrd.TabIndex = 6;
            // 
            // lblPwrd
            // 
            this.lblPwrd.AutoSize = true;
            this.lblPwrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPwrd.Location = new System.Drawing.Point(6, 106);
            this.lblPwrd.Name = "lblPwrd";
            this.lblPwrd.Size = new System.Drawing.Size(77, 17);
            this.lblPwrd.TabIndex = 5;
            this.lblPwrd.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(111, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 23);
            this.txtUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.Location = new System.Drawing.Point(6, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username :";
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 328);
            this.Controls.Add(this.tbcntrlUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Data";
            this.Load += new System.EventHandler(this.UpdateData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcntrlUpdate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_UpdateTable;
        private System.Windows.Forms.Button btn_UpdateSp;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnColumns;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnDropColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateDb;
        private System.Windows.Forms.Label label3;
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
    }
}

