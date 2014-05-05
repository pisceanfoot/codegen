using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class CreateProject : Form
    {
        private const string TEMPLATE_DESCPTION = "���ڴ������� {0} Ӧ�ó�������ģ��";
        private const string TEMPLATE_PATH = "template";
        private string templatePath;

        private string preProjectName = string.Empty;
        private ProjectInfo projectInfo = null;

        public ProjectInfo Projct
        {
            get { return projectInfo; }
        }

        public CreateProject()
        {
            InitializeComponent();

            // ����ģ��
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            templatePath = Path.Combine(appPath, TEMPLATE_PATH);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (ListTemplate.FocusedItem == null)
            {
                MessageBox.Show("��ѡ��ģ��", "Ӧ�ó�����ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = CmbLocation.Text;
            if (!path.EndsWith("\\"))
                path += "\\";

            string projectName = TxtProjectName.Text;
            if (path == string.Empty)
            {
                MessageBox.Show("��������Ŀ����·��", "Ӧ�ó�����ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tmp = Path.Combine(path, projectName);

            if (Directory.Exists(tmp))
            {
                MessageBox.Show(string.Format("�������ļ��С�{0}�����Ѵ�����һ����Ŀ������޷���������Ŀ", tmp), "Ӧ�ó�����ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            projectInfo = new ProjectInfo();
            projectInfo.CreateDate = DateTime.Now;
            projectInfo.Name = projectName;
            projectInfo.SolutionName = TxtSolutionName.Text;
            projectInfo.SolutionPath = path;
            projectInfo.TemplatePath = Path.Combine(TEMPLATE_PATH, ListTemplate.FocusedItem.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtmBroswer_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.Cancel) return;

            CmbLocation.Text = folderBrowserDialog.SelectedPath;
        }

        private void TxtProjectName_TextChanged(object sender, EventArgs e)
        {
            string projectName = TxtProjectName.Text.Trim();
            string solution = TxtSolutionName.Text.Trim();

            if (solution == string.Empty || preProjectName == solution)
                TxtSolutionName.Text = projectName;

            preProjectName = projectName;
            if (projectName == string.Empty && BtnCreate.Enabled)
            {
                BtnCreate.Enabled = false;
            }
            else if (!BtnCreate.Enabled)
            {
                BtnCreate.Enabled = true;
            }
        }

        private void CmbLocation_TextUpdate(object sender, EventArgs e)
        {
            string path = CmbLocation.Text.Trim();
            if (string.IsNullOrEmpty(path))
                BtnCreate.Enabled = false;

            if (!Directory.Exists(path))
                BtnCreate.Enabled = false;
            else if (!BtnCreate.Enabled)
            {
                BtnCreate.Enabled = true;
            }
        }

        private void ListTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListTemplate.FocusedItem != null)
            {
                TxtDescription.Text = string.Format(TEMPLATE_DESCPTION, ListTemplate.FocusedItem.Text);
            }
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(templatePath))
            {
                List<ListViewItem> list = new List<ListViewItem>();
                string[] pathList = Directory.GetDirectories(templatePath);
                foreach (string filePath in pathList)
                {
                    if (Directory.GetFiles(filePath, "*.vm").Length > 0)
                    {
                        // add
                        string path = Path.GetFileName(filePath);
                        ListViewItem item = new ListViewItem(path, 0);
                        item.Group = listViewGroup;
                        item.StateImageIndex = 0;

                        list.Add(item);
                    }
                }

                if (list.Count > 0)
                    this.ListTemplate.Items.AddRange(list.ToArray());
            }
        }
    }
}