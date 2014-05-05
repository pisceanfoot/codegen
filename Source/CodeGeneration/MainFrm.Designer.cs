namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparatorMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparatorMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparatorMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.LastProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparatorMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目资源管理器PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出项目EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectPropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.MainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ViewMenuItem,
            this.BuildMenuItem,
            this.ToolMenuItem,
            this.WindowsMenuItem,
            this.HelpMenuItem});
            this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.Size = new System.Drawing.Size(792, 25);
            this.MainMenuBar.TabIndex = 0;
            this.MainMenuBar.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.FileSeparatorMenuItem1,
            this.CloseMenuItem,
            this.CloseProjectMenuItem,
            this.FileSeparatorMenuItem2,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.SaveAllMenuItem,
            this.FileSeparatorMenuItem3,
            this.LastProjectMenuItem,
            this.FileSeparatorMenuItem4,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(58, 21);
            this.FileMenuItem.Text = "文件(&F)";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewMenuItem.Text = "新建项目(&N)";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenMenuItem.Text = "打开项目(&O)";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // FileSeparatorMenuItem1
            // 
            this.FileSeparatorMenuItem1.Name = "FileSeparatorMenuItem1";
            this.FileSeparatorMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseMenuItem.Text = "关闭(&C)";
            // 
            // CloseProjectMenuItem
            // 
            this.CloseProjectMenuItem.Name = "CloseProjectMenuItem";
            this.CloseProjectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseProjectMenuItem.Text = "关闭项目(&T)";
            // 
            // FileSeparatorMenuItem2
            // 
            this.FileSeparatorMenuItem2.Name = "FileSeparatorMenuItem2";
            this.FileSeparatorMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveMenuItem.Text = "保存(&S)";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsMenuItem.Text = "另存为...(&A)";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // SaveAllMenuItem
            // 
            this.SaveAllMenuItem.Name = "SaveAllMenuItem";
            this.SaveAllMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAllMenuItem.Text = "全部保存(&L)";
            this.SaveAllMenuItem.Click += new System.EventHandler(this.SaveAllMenuItem_Click);
            // 
            // FileSeparatorMenuItem3
            // 
            this.FileSeparatorMenuItem3.Name = "FileSeparatorMenuItem3";
            this.FileSeparatorMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // LastProjectMenuItem
            // 
            this.LastProjectMenuItem.Name = "LastProjectMenuItem";
            this.LastProjectMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LastProjectMenuItem.Text = "最近的项目(&J)";
            // 
            // FileSeparatorMenuItem4
            // 
            this.FileSeparatorMenuItem4.Name = "FileSeparatorMenuItem4";
            this.FileSeparatorMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "退出(&X)";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataBaseMenuItem,
            this.项目资源管理器PToolStripMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ViewMenuItem.Text = "视图(&V)";
            // 
            // DataBaseMenuItem
            // 
            this.DataBaseMenuItem.Checked = true;
            this.DataBaseMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DataBaseMenuItem.Name = "DataBaseMenuItem";
            this.DataBaseMenuItem.Size = new System.Drawing.Size(175, 22);
            this.DataBaseMenuItem.Text = "数据库(&D)";
            this.DataBaseMenuItem.Click += new System.EventHandler(this.DataBaseMenuItem_Click);
            // 
            // 项目资源管理器PToolStripMenuItem
            // 
            this.项目资源管理器PToolStripMenuItem.Image = global::ChinaBest.BaseApplication.CodeGeneration.Properties.Resources.solution_broswer;
            this.项目资源管理器PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.项目资源管理器PToolStripMenuItem.Name = "项目资源管理器PToolStripMenuItem";
            this.项目资源管理器PToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.项目资源管理器PToolStripMenuItem.Text = "项目资源管理器(&P)";
            this.项目资源管理器PToolStripMenuItem.Click += new System.EventHandler(this.项目资源管理器PToolStripMenuItem_Click);
            // 
            // BuildMenuItem
            // 
            this.BuildMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出项目EToolStripMenuItem});
            this.BuildMenuItem.Name = "BuildMenuItem";
            this.BuildMenuItem.Size = new System.Drawing.Size(60, 21);
            this.BuildMenuItem.Text = "生成(&B)";
            // 
            // 导出项目EToolStripMenuItem
            // 
            this.导出项目EToolStripMenuItem.Name = "导出项目EToolStripMenuItem";
            this.导出项目EToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.导出项目EToolStripMenuItem.Text = "导出项目(&E)";
            this.导出项目EToolStripMenuItem.Click += new System.EventHandler(this.导出项目EToolStripMenuItem_Click);
            // 
            // ToolMenuItem
            // 
            this.ToolMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectPropertiesMenuItem});
            this.ToolMenuItem.Name = "ToolMenuItem";
            this.ToolMenuItem.Size = new System.Drawing.Size(59, 21);
            this.ToolMenuItem.Text = "工具(&T)";
            // 
            // ProjectPropertiesMenuItem
            // 
            this.ProjectPropertiesMenuItem.Name = "ProjectPropertiesMenuItem";
            this.ProjectPropertiesMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ProjectPropertiesMenuItem.Text = "项目属性(&P)";
            // 
            // WindowsMenuItem
            // 
            this.WindowsMenuItem.Name = "WindowsMenuItem";
            this.WindowsMenuItem.Size = new System.Drawing.Size(64, 21);
            this.WindowsMenuItem.Text = "窗口(&W)";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(61, 21);
            this.HelpMenuItem.Text = "帮助(&H)";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(224, 22);
            this.AboutMenuItem.Text = "关于 Code Gerneration(&A)";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainToolBar
            // 
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Location = new System.Drawing.Point(0, 25);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.Size = new System.Drawing.Size(792, 25);
            this.MainToolBar.TabIndex = 1;
            this.MainToolBar.Text = "MainToolBar";
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Location = new System.Drawing.Point(0, 551);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(792, 22);
            this.MainStatusBar.TabIndex = 2;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // MainDockPanel
            // 
            this.MainDockPanel.ActiveAutoHideContent = null;
            this.MainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDockPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.MainDockPanel.Location = new System.Drawing.Point(0, 50);
            this.MainDockPanel.Name = "MainDockPanel";
            this.MainDockPanel.Size = new System.Drawing.Size(792, 501);
            this.MainDockPanel.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "项目文件|*.cgp|所有文件|*.*";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.MainDockPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainToolBar);
            this.Controls.Add(this.MainMenuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenuBar;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generation V2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private WeifenLuo.WinFormsUI.Docking.DockPanel MainDockPanel;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseProjectMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem LastProjectMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparatorMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ToolMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectPropertiesMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 导出项目EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目资源管理器PToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

