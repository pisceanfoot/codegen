namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class ProjectFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectFrm));
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.ProjectPropertiesToolBtn = new System.Windows.Forms.ToolStripButton();
            this.ToolSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SBtnExport = new System.Windows.Forms.ToolStripButton();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.MenuStripCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.����CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolBar.SuspendLayout();
            this.MenuStripCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolBar
            // 
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectPropertiesToolBtn,
            this.ToolSeparator1,
            this.RefreshToolBtn,
            this.toolStripSeparator1,
            this.SBtnExport});
            this.MainToolBar.Location = new System.Drawing.Point(0, 0);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.Size = new System.Drawing.Size(292, 25);
            this.MainToolBar.TabIndex = 0;
            this.MainToolBar.Text = "toolStrip1";
            // 
            // ProjectPropertiesToolBtn
            // 
            this.ProjectPropertiesToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProjectPropertiesToolBtn.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.ProjectProperties;
            this.ProjectPropertiesToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProjectPropertiesToolBtn.Name = "ProjectPropertiesToolBtn";
            this.ProjectPropertiesToolBtn.Size = new System.Drawing.Size(23, 22);
            this.ProjectPropertiesToolBtn.Text = "��Ŀ����";
            // 
            // ToolSeparator1
            // 
            this.ToolSeparator1.Name = "ToolSeparator1";
            this.ToolSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SBtnExport
            // 
            this.SBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SBtnExport.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.fileexport;
            this.SBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SBtnExport.Name = "SBtnExport";
            this.SBtnExport.Size = new System.Drawing.Size(23, 22);
            this.SBtnExport.Text = "����";
            this.SBtnExport.Click += new System.EventHandler(this.SBtnExport_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.ImageIndex = 0;
            this.MainTreeView.ImageList = this.imageList;
            this.MainTreeView.Location = new System.Drawing.Point(0, 25);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.SelectedImageIndex = 0;
            this.MainTreeView.Size = new System.Drawing.Size(292, 248);
            this.MainTreeView.TabIndex = 1;
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList.Images.SetKeyName(0, "solution.bmp");
            this.imageList.Images.SetKeyName(1, "solution_library.bmp");
            this.imageList.Images.SetKeyName(2, "solution_class.bmp");
            // 
            // MenuStripCopy
            // 
            this.MenuStripCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.����CToolStripMenuItem});
            this.MenuStripCopy.Name = "MenuStripCopy";
            this.MenuStripCopy.Size = new System.Drawing.Size(113, 26);
            // 
            // ����CToolStripMenuItem
            // 
            this.����CToolStripMenuItem.Name = "����CToolStripMenuItem";
            this.����CToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.����CToolStripMenuItem.Text = "����(&C)";
            this.����CToolStripMenuItem.Click += new System.EventHandler(this.����CToolStripMenuItem_Click);
            // 
            // ProjectFrm
            // 
            this.AllowEndUserDocking = false;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.MainToolBar);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectFrm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRightAutoHide;
            this.TabText = "��Ŀ��Դ������";
            this.Text = "��Ŀ��Դ������";
            this.ToolTipText = "��Ŀ��Դ������";
            this.MainToolBar.ResumeLayout(false);
            this.MainToolBar.PerformLayout();
            this.MenuStripCopy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripButton ProjectPropertiesToolBtn;
        private System.Windows.Forms.ToolStripSeparator ToolSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshToolBtn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SBtnExport;
        private System.Windows.Forms.ContextMenuStrip MenuStripCopy;
        private System.Windows.Forms.ToolStripMenuItem ����CToolStripMenuItem;
    }
}
