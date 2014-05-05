namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class DataBaseFrm
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseFrm));
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.RefreshToolBtn = new System.Windows.Forms.ToolStripButton();
            this.ToolSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectToDBToolBtn = new System.Windows.Forms.ToolStripButton();
            this.ConnectToServerToolBtn = new System.Windows.Forms.ToolStripButton();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.imageDBTreeView = new System.Windows.Forms.ImageList(this.components);
            this.DBContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.����C����ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.�����������ݿ�ű�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DBTableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCreateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolBar.SuspendLayout();
            this.DBContentMenu.SuspendLayout();
            this.DBTableMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolBar
            // 
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolBtn,
            this.ToolSeparator1,
            this.ConnectToDBToolBtn,
            this.ConnectToServerToolBtn});
            this.MainToolBar.Location = new System.Drawing.Point(0, 0);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.Size = new System.Drawing.Size(292, 25);
            this.MainToolBar.TabIndex = 0;
            this.MainToolBar.Text = "MainToolBar";
            // 
            // RefreshToolBtn
            // 
            this.RefreshToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshToolBtn.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.Refresh;
            this.RefreshToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolBtn.Name = "RefreshToolBtn";
            this.RefreshToolBtn.Size = new System.Drawing.Size(23, 22);
            this.RefreshToolBtn.Text = "ˢ��";
            // 
            // ToolSeparator1
            // 
            this.ToolSeparator1.Name = "ToolSeparator1";
            this.ToolSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ConnectToDBToolBtn
            // 
            this.ConnectToDBToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectToDBToolBtn.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.ConnectToDB;
            this.ConnectToDBToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToDBToolBtn.Name = "ConnectToDBToolBtn";
            this.ConnectToDBToolBtn.Size = new System.Drawing.Size(23, 22);
            this.ConnectToDBToolBtn.Text = "���ӵ����ݿ�";
            this.ConnectToDBToolBtn.Click += new System.EventHandler(this.ConnectToDBToolBtn_Click);
            // 
            // ConnectToServerToolBtn
            // 
            this.ConnectToServerToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectToServerToolBtn.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.ConnectToServer;
            this.ConnectToServerToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToServerToolBtn.Name = "ConnectToServerToolBtn";
            this.ConnectToServerToolBtn.Size = new System.Drawing.Size(23, 22);
            this.ConnectToServerToolBtn.Text = "���ӵ�������";
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.ImageIndex = 1;
            this.MainTreeView.ImageList = this.imageDBTreeView;
            this.MainTreeView.Location = new System.Drawing.Point(0, 25);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.SelectedImageIndex = 1;
            this.MainTreeView.Size = new System.Drawing.Size(292, 248);
            this.MainTreeView.TabIndex = 1;
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            this.MainTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterCheck);
            // 
            // imageDBTreeView
            // 
            this.imageDBTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageDBTreeView.ImageStream")));
            this.imageDBTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageDBTreeView.Images.SetKeyName(0, "dbServer.bmp");
            this.imageDBTreeView.Images.SetKeyName(1, "database.bmp");
            this.imageDBTreeView.Images.SetKeyName(2, "dir.bmp");
            this.imageDBTreeView.Images.SetKeyName(3, "dbtable.bmp");
            this.imageDBTreeView.Images.SetKeyName(4, "dbcolumn.bmp");
            this.imageDBTreeView.Images.SetKeyName(5, "dbindex.bmp");
            this.imageDBTreeView.Images.SetKeyName(6, "dbkey.bmp");
            this.imageDBTreeView.Images.SetKeyName(7, "dbview.bmp");
            // 
            // DBContentMenu
            // 
            this.DBContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.����C����ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.�����������ݿ�ű�ToolStripMenuItem});
            this.DBContentMenu.Name = "DBContentMenu";
            this.DBContentMenu.Size = new System.Drawing.Size(197, 54);
            // 
            // ����C����ToolStripMenuItem
            // 
            this.����C����ToolStripMenuItem.Name = "����C����ToolStripMenuItem";
            this.����C����ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.����C����ToolStripMenuItem.Text = "����C#����...";
            this.����C����ToolStripMenuItem.Click += new System.EventHandler(this.����C����ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // �����������ݿ�ű�ToolStripMenuItem
            // 
            this.�����������ݿ�ű�ToolStripMenuItem.Name = "�����������ݿ�ű�ToolStripMenuItem";
            this.�����������ݿ�ű�ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.�����������ݿ�ű�ToolStripMenuItem.Text = "�����������ݿ�ű�...";
            // 
            // DBTableMenu
            // 
            this.DBTableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreateTable});
            this.DBTableMenu.Name = "DBContentMenu";
            this.DBTableMenu.Size = new System.Drawing.Size(143, 26);
            // 
            // toolStripMenuItemCreateTable
            // 
            this.toolStripMenuItemCreateTable.Name = "toolStripMenuItemCreateTable";
            this.toolStripMenuItemCreateTable.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemCreateTable.Text = "�½���(&N)...";
            this.toolStripMenuItemCreateTable.Click += new System.EventHandler(this.toolStripMenuItemCreateTable_Click);
            // 
            // DataBaseFrm
            // 
            this.AllowEndUserDocking = false;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainToolBar);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataBaseFrm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeftAutoHide;
            this.TabText = "��������Դ������";
            this.Text = "��������Դ������";
            this.ToolTipText = "��������Դ������";
            this.MainToolBar.ResumeLayout(false);
            this.MainToolBar.PerformLayout();
            this.DBContentMenu.ResumeLayout(false);
            this.DBTableMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripButton RefreshToolBtn;
        private System.Windows.Forms.ToolStripSeparator ToolSeparator1;
        private System.Windows.Forms.ToolStripButton ConnectToDBToolBtn;
        private System.Windows.Forms.ToolStripButton ConnectToServerToolBtn;
        private System.Windows.Forms.ImageList imageDBTreeView;
        private System.Windows.Forms.ContextMenuStrip DBContentMenu;
        private System.Windows.Forms.ToolStripMenuItem ����C����ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem �����������ݿ�ű�ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DBTableMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateTable;
    }
}
