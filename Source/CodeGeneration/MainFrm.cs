using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CGCoreLib.Util;
using ChinaBest.BaseApplication.CGCoreLib;
using ChinaBest.BaseApplication.CGCoreLib.Meta;
using ChinaBest.BaseApplication.CGCoreLib.Template;
using WeifenLuo.WinFormsUI.Docking;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class MainFrm : Form
    {
        #region 私有成员变量

        public static ConnectionInfo CurrentConnection = new ConnectionInfo();                      // 当前链接
        public static ProjectInfo CurrentProject = null;                      // 当前项目
        private IDatabase currentDatabase = null;                       // 当前生成数据库服务器资源

        #endregion 私有成员变量

        #region 窗体

        private DataBaseFrm databasefrm = new DataBaseFrm();
        private ProjectFrm projectfrm = new ProjectFrm();

        #endregion 窗体

        public MainFrm()
        {
            InitializeComponent();
            //

            ShowOrHideDataBaseFrm();

            databasefrm.Tag = this;
            databasefrm.DockState = DockState.DockLeftAutoHide;

            ShowOrHideProjectFrm();
            projectfrm.DockState = DockState.DockRightAutoHide;
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            CodeFrm frm = new CodeFrm();
            frm.TabText = "新建文件";
            frm.Show(this.MainDockPanel);
            frm.Focus();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //int a = 10;
        }

        public void AddPanel(DockContent frm)
        {
            frm.Show(this.MainDockPanel);
            frm.Focus();
        }

        #region 菜单

        /// <summary>
        /// 新建项目
        /// </summary>
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            DialogResult dr = createProject.ShowDialog();
            if (dr == DialogResult.Cancel) return;

            CurrentProject = createProject.Projct;
            ProjectInfo.Save(CurrentProject);
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            string file = openFileDialog.FileName;

            try
            {
                ProjectInfo info = XmlSerialization.DeSerializeObject(file, typeof(ProjectInfo)) as ProjectInfo;
                if (info != null)
                {
                    CurrentProject = info;
                    projectfrm.CurrentProject = CurrentProject;
                    projectfrm.Initi(CurrentProject.Name);

                    try
                    {
                        CurrentConnection.ServerAddress = CurrentProject.ServerAddress;
                        CurrentConnection.UserName = CurrentProject.UserName;
                        CurrentConnection.Password = CurrentProject.Password;
                        CurrentConnection.IsWindowAuth = CurrentProject.WindowsAudhority;

                        databasefrm.CheckSavedPassword();
                    }
                    catch { }

                    string path = Path.Combine(CurrentProject.SolutionPath, CurrentProject.Name);
                    path = Path.Combine(path, CurrentProject.Name);

                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string dir in dirs)
                    {
                        string[] files = Directory.GetFiles(dir, "*.cs");
                        List<CodeInfo> codeInfoList = new List<CodeInfo>();
                        string dirName = Path.GetFileName(dir);
                        foreach (string tmp in files)
                        {
                            CodeInfo tmpInfo = new CodeInfo();
                            tmpInfo.Code = File.ReadAllText(tmp, Encoding.UTF8);
                            tmpInfo.FileName = Path.GetFileName(tmp).Replace(".cs", "");
                            tmpInfo.Template = dirName;

                            codeInfoList.Add(tmpInfo);
                        }

                        projectfrm.AddCodeFiles(dirName, codeInfoList);
                    }
                }
            }
            catch
            {
                MessageBox.Show("文件打开失败", "应用程序提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 导出项目
        /// </summary>
        private void 导出项目EToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion 菜单

        #region 生成项目

        public void GenerationCode(IDatabase database)
        {
            if (CurrentProject == null)
            {
                DialogResult dr = MessageBox.Show("项目不存在，是否立即创建？", "应用程序提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel) return;

                // 创建项目
                NewMenuItem_Click(null, EventArgs.Empty);
                if (CurrentProject == null) return;
            }

            CurrentProject.ServerAddress = CurrentConnection.ServerAddress;
            CurrentProject.UserName = CurrentConnection.UserName;
            CurrentProject.Password = CurrentConnection.Password;
            CurrentProject.WindowsAudhority = CurrentConnection.IsWindowAuth;

            ProjectInfo.Save(CurrentProject);

            if (database == null) throw new ArgumentNullException("参数有误");
            currentDatabase = database;

            Template.PutValue("namespace", CurrentProject.SolutionName);
            string[] template = CurrentProject.GetTemplateList();

            projectfrm.CurrentProject = CurrentProject;
            projectfrm.Initi(CurrentProject.Name);

            try
            {
                foreach (string tmp in template)
                {
                    List<CodeInfo> codeInfoList = Template.Generator(currentDatabase, tmp);

                    string name = Path.GetFileName(tmp);
                    name = name.Replace(".vm", "");
                    projectfrm.AddCodeFiles(name, codeInfoList);
                    SaveCodeFile(name, codeInfoList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "应用程序提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 生成项目

        #region 保存并加载生成后的项目

        private void SaveCodeFile(string template, List<CodeInfo> codeFileList)
        {
            string file = Path.Combine(CurrentProject.SolutionPath, CurrentProject.Name);
            file = Path.Combine(file, CurrentProject.Name);

            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }

            file = Path.Combine(file, template);
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }

            string tmp = string.Empty;
            foreach (CodeInfo code in codeFileList)
            {
                tmp = Path.Combine(file, code.FileName + ".cs");
                File.WriteAllText(tmp, code.Code, Encoding.UTF8);
            }
        }

        #endregion 保存并加载生成后的项目

        #region 添加code显示

        /// <summary>
        /// 添加代码显示
        /// </summary>
        public void DisplayCode(string name, CodeInfo code)
        {
            CodeFrm codeFrm = new CodeFrm();
            codeFrm.SetCode(name, code);
            codeFrm.Show(this.MainDockPanel, DockState.Document);
        }

        #endregion 添加code显示

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SaveAllMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}