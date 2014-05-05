namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class CreateProject
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
            this.components = new System.ComponentModel.Container();
            listViewGroup = new System.Windows.Forms.ListViewGroup("已安装的模版", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProject));
            this.LblTempdateName = new System.Windows.Forms.Label();
            this.ListTemplate = new System.Windows.Forms.ListView();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblLocation = new System.Windows.Forms.Label();
            this.CmbLocation = new System.Windows.Forms.ComboBox();
            this.BtmBroswer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LblSolution = new System.Windows.Forms.Label();
            this.TxtSolutionName = new System.Windows.Forms.TextBox();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // LblTempdateName
            // 
            this.LblTempdateName.AutoSize = true;
            this.LblTempdateName.Location = new System.Drawing.Point(12, 18);
            this.LblTempdateName.Name = "LblTempdateName";
            this.LblTempdateName.Size = new System.Drawing.Size(47, 12);
            this.LblTempdateName.TabIndex = 0;
            this.LblTempdateName.Text = "模版(&T)";
            // 
            // ListTemplate
            // 
            listViewGroup.Header = "已安装的模版";
            listViewGroup.Name = "listViewGroupInstalled";
            this.ListTemplate.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup});
            this.ListTemplate.LargeImageList = this.imageListLarge;
            this.ListTemplate.Location = new System.Drawing.Point(12, 38);
            this.ListTemplate.MultiSelect = false;
            this.ListTemplate.Name = "ListTemplate";
            this.ListTemplate.Size = new System.Drawing.Size(603, 200);
            this.ListTemplate.SmallImageList = this.imageListSmall;
            this.ListTemplate.TabIndex = 1;
            this.ListTemplate.UseCompatibleStateImageBehavior = false;
            this.ListTemplate.SelectedIndexChanged += new System.EventHandler(this.ListTemplate_SelectedIndexChanged);
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Location = new System.Drawing.Point(10, 277);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(53, 12);
            this.LblProjectName.TabIndex = 3;
            this.LblProjectName.Text = "名称(&N):";
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(122, 274);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(410, 21);
            this.TxtProjectName.TabIndex = 2;
            this.TxtProjectName.Text = "ProjectName1";
            this.TxtProjectName.TextChanged += new System.EventHandler(this.TxtProjectName_TextChanged);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("宋体", 9F);
            this.TxtDescription.ForeColor = System.Drawing.Color.Black;
            this.TxtDescription.Location = new System.Drawing.Point(12, 243);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ReadOnly = true;
            this.TxtDescription.Size = new System.Drawing.Size(603, 21);
            this.TxtDescription.TabIndex = 5;
            this.TxtDescription.TabStop = false;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(10, 308);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(53, 12);
            this.LblLocation.TabIndex = 6;
            this.LblLocation.Text = "位置(&L):";
            // 
            // CmbLocation
            // 
            this.CmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.CmbLocation.FormattingEnabled = true;
            this.CmbLocation.Location = new System.Drawing.Point(122, 303);
            this.CmbLocation.Name = "CmbLocation";
            this.CmbLocation.Size = new System.Drawing.Size(410, 20);
            this.CmbLocation.TabIndex = 3;
            this.CmbLocation.TextUpdate += new System.EventHandler(this.CmbLocation_TextUpdate);
            // 
            // BtmBroswer
            // 
            this.BtmBroswer.Location = new System.Drawing.Point(540, 303);
            this.BtmBroswer.Name = "BtmBroswer";
            this.BtmBroswer.Size = new System.Drawing.Size(75, 23);
            this.BtmBroswer.TabIndex = 4;
            this.BtmBroswer.Text = "浏览(&B)...";
            this.BtmBroswer.UseVisualStyleBackColor = true;
            this.BtmBroswer.Click += new System.EventHandler(this.BtmBroswer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 2);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(443, 380);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "确认";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCancle
            // 
            this.BtnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancle.Location = new System.Drawing.Point(540, 380);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(75, 23);
            this.BtnCancle.TabIndex = 7;
            this.BtnCancle.Text = "取消";
            this.BtnCancle.UseVisualStyleBackColor = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // LblSolution
            // 
            this.LblSolution.AutoSize = true;
            this.LblSolution.Location = new System.Drawing.Point(12, 336);
            this.LblSolution.Name = "LblSolution";
            this.LblSolution.Size = new System.Drawing.Size(101, 12);
            this.LblSolution.TabIndex = 12;
            this.LblSolution.Text = "解决方案名称(&M):";
            // 
            // TxtSolutionName
            // 
            this.TxtSolutionName.Location = new System.Drawing.Point(122, 331);
            this.TxtSolutionName.Name = "TxtSolutionName";
            this.TxtSolutionName.Size = new System.Drawing.Size(410, 21);
            this.TxtSolutionName.TabIndex = 5;
            this.TxtSolutionName.Text = "ProjectName1";
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageListSmall.Images.SetKeyName(0, "library.bmp");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageListLarge.Images.SetKeyName(0, "large_library.bmp");
            // 
            // CreateProject
            // 
            this.AcceptButton = this.BtnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancle;
            this.ClientSize = new System.Drawing.Size(624, 417);
            this.Controls.Add(this.TxtSolutionName);
            this.Controls.Add(this.LblSolution);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtmBroswer);
            this.Controls.Add(this.CmbLocation);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtProjectName);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.ListTemplate);
            this.Controls.Add(this.LblTempdateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建项目";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListViewGroup listViewGroup;
        private System.Windows.Forms.Label LblTempdateName;
        private System.Windows.Forms.ListView ListTemplate;
        private System.Windows.Forms.Label LblProjectName;
        private System.Windows.Forms.TextBox TxtProjectName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.ComboBox CmbLocation;
        private System.Windows.Forms.Button BtmBroswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label LblSolution;
        private System.Windows.Forms.TextBox TxtSolutionName;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}