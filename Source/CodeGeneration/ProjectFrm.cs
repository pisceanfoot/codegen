using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ChinaBest.BaseApplication.CGCoreLib;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class ProjectFrm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private const string TITLE = "项目资源管理器 - {0}";
        private TreeNode mainNode;
        private ProjectInfo projectInfo = null;

        public ProjectInfo CurrentProject
        {
            get { return projectInfo; }
            set { projectInfo = value; }
        }

        public ProjectFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清空所有节点
        /// </summary>
        public void Clear()
        {
            MainTreeView.Nodes.Clear();
        }

        public void Initi(string projectName)
        {
            Clear();
            string name = string.Format(TITLE, projectName);
            this.TabText = name;
            this.Text = name;
            mainNode = new TreeNode(name, 0, 0);
            MainTreeView.Nodes.Add(mainNode);
        }

        public void AddCodeFiles(string project, List<CodeInfo> codeList)
        {
            TreeNode library = new TreeNode(project, 1, 1);
            library.ContextMenuStrip = this.MenuStripCopy;

            foreach (CodeInfo code in codeList)
            {
                TreeNode classfile = new TreeNode(code.FileName, 2, 2);
                classfile.Tag = code;
                classfile.ContextMenuStrip = this.MenuStripCopy;

                library.Nodes.Add(classfile);
            }

            mainNode.Nodes.Add(library);
        }

        public void Refresh()
        {
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
            }
        }

        private void SBtnExport_Click(object sender, EventArgs e)
        {
        }

        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (MainTreeView.SelectedNode == null) return;

            TreeNode node = MainTreeView.SelectedNode;
            if (node.Tag == null) return;
            CodeInfo code = (CodeInfo)node.Tag;

            string parent = node.Parent.Text;
            ((MainFrm)this.DockPanel.Parent).DisplayCode(parent + "\\" + code.FileName + ".cs", code);
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectInfo == null) return;
            if (MainTreeView.SelectedNode == null) return;

            string file = Path.Combine(projectInfo.SolutionPath, projectInfo.Name);
            file = Path.Combine(file, projectInfo.Name);
            string parent = string.Empty;
            System.Windows.Forms.Clipboard.Clear();
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();

            TreeNode node = MainTreeView.SelectedNode;
            if (node.Tag == null)
            {
                if (node == mainNode)
                    return;
                parent = node.Text;
                file = Path.Combine(file, parent);

                foreach (TreeNode child in node.Nodes)
                {
                    CodeInfo childCode = child.Tag as CodeInfo;
                    string tmpfile = Path.Combine(file, childCode.FileName + ".cs");
                    sc.Add(tmpfile);
                }
            }
            else
            {
                CodeInfo code = node.Tag as CodeInfo;

                parent = node.Parent.Text;

                file = Path.Combine(file, parent);
                file = Path.Combine(file, code.FileName + ".cs");

                sc.Add(file);
            }

            System.Windows.Forms.Clipboard.SetFileDropList(sc);
        }
    }
}