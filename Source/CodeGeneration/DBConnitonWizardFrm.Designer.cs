namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class DBConnitonWizardFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblServerName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnitonWizardFrm));
            this.cmbServerSelect = new System.Windows.Forms.ComboBox();
            this.cmbSQLValidModeSelect = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbAccountSelect = new System.Windows.Forms.ComboBox();
            this.chkRememberPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblServerType = new System.Windows.Forms.Label();
            this.lblValidMode = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            lblServerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Location = new System.Drawing.Point(12, 123);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new System.Drawing.Size(89, 12);
            lblServerName.TabIndex = 11;
            lblServerName.Text = "服务器名称(&S):";
            // 
            // cmbServerSelect
            // 
            this.cmbServerSelect.FormattingEnabled = true;
            this.cmbServerSelect.Location = new System.Drawing.Point(190, 120);
            this.cmbServerSelect.Name = "cmbServerSelect";
            this.cmbServerSelect.Size = new System.Drawing.Size(320, 20);
            this.cmbServerSelect.TabIndex = 0;
            this.cmbServerSelect.SelectedIndexChanged += new System.EventHandler(this.cmbServerSelect_SelectedIndexChanged);
            // 
            // cmbSQLValidModeSelect
            // 
            this.cmbSQLValidModeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSQLValidModeSelect.FormattingEnabled = true;
            this.cmbSQLValidModeSelect.Items.AddRange(new object[] {
            "Windows 身份验证",
            "SQL Server 身份验证"});
            this.cmbSQLValidModeSelect.Location = new System.Drawing.Point(190, 150);
            this.cmbSQLValidModeSelect.Name = "cmbSQLValidModeSelect";
            this.cmbSQLValidModeSelect.Size = new System.Drawing.Size(320, 20);
            this.cmbSQLValidModeSelect.TabIndex = 1;
            this.cmbSQLValidModeSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSQLValidModeSelect_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "数据库引擎"});
            this.comboBox3.Location = new System.Drawing.Point(190, 90);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(320, 20);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "数据库引擎";
            // 
            // cmbAccountSelect
            // 
            this.cmbAccountSelect.FormattingEnabled = true;
            this.cmbAccountSelect.Location = new System.Drawing.Point(206, 180);
            this.cmbAccountSelect.Name = "cmbAccountSelect";
            this.cmbAccountSelect.Size = new System.Drawing.Size(304, 20);
            this.cmbAccountSelect.TabIndex = 3;
            // 
            // chkRememberPassword
            // 
            this.chkRememberPassword.AutoSize = true;
            this.chkRememberPassword.Location = new System.Drawing.Point(206, 246);
            this.chkRememberPassword.Name = "chkRememberPassword";
            this.chkRememberPassword.Size = new System.Drawing.Size(72, 16);
            this.chkRememberPassword.TabIndex = 5;
            this.chkRememberPassword.Text = "记住密码";
            this.chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 210);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(304, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(74, 274);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 25);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "连接(&C)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblServerType
            // 
            this.lblServerType.AutoSize = true;
            this.lblServerType.Location = new System.Drawing.Point(12, 93);
            this.lblServerType.Name = "lblServerType";
            this.lblServerType.Size = new System.Drawing.Size(89, 12);
            this.lblServerType.TabIndex = 10;
            this.lblServerType.Text = "服务器类型(&T):";
            // 
            // lblValidMode
            // 
            this.lblValidMode.AutoSize = true;
            this.lblValidMode.Location = new System.Drawing.Point(12, 153);
            this.lblValidMode.Name = "lblValidMode";
            this.lblValidMode.Size = new System.Drawing.Size(77, 12);
            this.lblValidMode.TabIndex = 12;
            this.lblValidMode.Text = "身份验证(&A):";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(35, 183);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 12);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "用户名(&U):";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 213);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "密码(&P):";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(206, 274);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(100, 25);
            this.btnTestConnection.TabIndex = 15;
            this.btnTestConnection.Text = "测试";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // DBConnitonWizardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblValidMode);
            this.Controls.Add(lblServerName);
            this.Controls.Add(this.lblServerType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkRememberPassword);
            this.Controls.Add(this.cmbAccountSelect);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbSQLValidModeSelect);
            this.Controls.Add(this.cmbServerSelect);
            this.Name = "DBConnitonWizardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接向导";
            this.Load += new System.EventHandler(this.DBConnitonWizardFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbServerSelect;
        private System.Windows.Forms.ComboBox cmbSQLValidModeSelect;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cmbAccountSelect;
        private System.Windows.Forms.CheckBox chkRememberPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblServerType;
        private System.Windows.Forms.Label lblValidMode;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnTestConnection;
    }
}