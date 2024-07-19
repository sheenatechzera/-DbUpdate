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
            this.btnDropColumn = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnColumns = new System.Windows.Forms.Button();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btn_UpdateSp = new System.Windows.Forms.Button();
            this.btn_UpdateTable = new System.Windows.Forms.Button();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.grpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDropColumn
            // 
            this.btnDropColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnDropColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropColumn.Location = new System.Drawing.Point(190, 120);
            this.btnDropColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDropColumn.Name = "btnDropColumn";
            this.btnDropColumn.Size = new System.Drawing.Size(219, 50);
            this.btnDropColumn.TabIndex = 23;
            this.btnDropColumn.Text = "Drop Column";
            this.btnDropColumn.UseVisualStyleBackColor = false;
            this.btnDropColumn.Click += new System.EventHandler(this.btnDropColumn_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrigger.Location = new System.Drawing.Point(190, 228);
            this.btnTrigger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(219, 50);
            this.btnTrigger.TabIndex = 22;
            this.btnTrigger.Text = "Create Triggers";
            this.btnTrigger.UseVisualStyleBackColor = false;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(190, 172);
            this.btnType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(219, 50);
            this.btnType.TabIndex = 21;
            this.btnType.Text = "Update Column Type";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumns.Location = new System.Drawing.Point(9, 228);
            this.btnColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(173, 50);
            this.btnColumns.TabIndex = 20;
            this.btnColumns.Text = "Update Columns";
            this.btnColumns.UseVisualStyleBackColor = false;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(163, 70);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(339, 24);
            this.cmbDatabase.TabIndex = 19;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Database:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(512, 32);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(133, 39);
            this.btn_Connect.TabIndex = 17;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Server Name :";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServerName.Location = new System.Drawing.Point(161, 34);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(343, 23);
            this.txtServerName.TabIndex = 15;
            // 
            // btn_UpdateSp
            // 
            this.btn_UpdateSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSp.Location = new System.Drawing.Point(413, 120);
            this.btn_UpdateSp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateSp.Name = "btn_UpdateSp";
            this.btn_UpdateSp.Size = new System.Drawing.Size(264, 50);
            this.btn_UpdateSp.TabIndex = 14;
            this.btn_UpdateSp.Text = "Update Stored Procedure";
            this.btn_UpdateSp.UseVisualStyleBackColor = false;
            this.btn_UpdateSp.Click += new System.EventHandler(this.btn_UpdateSp_Click);
            // 
            // btn_UpdateTable
            // 
            this.btn_UpdateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btn_UpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTable.Location = new System.Drawing.Point(9, 175);
            this.btn_UpdateTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateTable.Name = "btn_UpdateTable";
            this.btn_UpdateTable.Size = new System.Drawing.Size(173, 47);
            this.btn_UpdateTable.TabIndex = 13;
            this.btn_UpdateTable.Text = "Update Table";
            this.btn_UpdateTable.UseVisualStyleBackColor = false;
            this.btn_UpdateTable.Click += new System.EventHandler(this.btn_UpdateTable_Click);
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(164)))), ((int)(((byte)(214)))));
            this.btnCreateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDb.Location = new System.Drawing.Point(9, 120);
            this.btnCreateDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(173, 50);
            this.btnCreateDb.TabIndex = 12;
            this.btnCreateDb.Text = "Create Db";
            this.btnCreateDb.UseVisualStyleBackColor = false;
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Controls.Add(this.txtServerName);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.cmbDatabase);
            this.grpConnection.Controls.Add(this.btn_Connect);
            this.grpConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConnection.Location = new System.Drawing.Point(8, 10);
            this.grpConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnection.Size = new System.Drawing.Size(669, 101);
            this.grpConnection.TabIndex = 24;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 309);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.btnDropColumn);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnColumns);
            this.Controls.Add(this.btn_UpdateSp);
            this.Controls.Add(this.btn_UpdateTable);
            this.Controls.Add(this.btnCreateDb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Data";
            this.Load += new System.EventHandler(this.UpdateData_Load);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDropColumn;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnColumns;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btn_UpdateSp;
        private System.Windows.Forms.Button btn_UpdateTable;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Windows.Forms.GroupBox grpConnection;
    }
}

