using System;
using System.Text;
using System.Windows.Forms;
using ChinaBest.BaseApplication.CGCoreLib;
using ChinaBest.BaseApplication.CGCoreLib.Meta;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class DataBaseFrm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private System.Collections.ArrayList serverlist = new System.Collections.ArrayList();
        private TreeNode serverNode;

        public DataBaseFrm()
        {
            InitializeComponent();
        }

        private void ConnectToDBToolBtn_Click(object sender, EventArgs e)
        {
            DBConnitonWizardFrm dbConnitionWizardFrm = new DBConnitonWizardFrm();
            //if(dbConnitionWizardFrm.ShowDialog(this)==DialogResult.
            dbConnitionWizardFrm.Owner = this;
            if (dbConnitionWizardFrm.ShowDialog() == DialogResult.OK)
            {
                //��serverlist�е����һ�����������뵽����������
                Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[serverlist.Count - 1];
                serverNode = new TreeNode();
                serverNode.Name = server.Name;
                serverNode.Text = server.Name;
                serverNode.ImageIndex = 0;
                serverNode.SelectedImageIndex = 0;
                serverNode.Tag = server;
                this.MainTreeView.Nodes.Add(serverNode);
            }
        }

        public void CheckSavedPassword()
        {
            if (MainFrm.CurrentProject != null)
            {
                ProjectInfo current = MainFrm.CurrentProject;
                Microsoft.SqlServer.Management.Smo.Server server = null;

                if (current.WindowsAudhority)
                {
                    if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(current.ServerAddress))
                    {
                        server = new Microsoft.SqlServer.Management.Smo.Server(current.ServerAddress);
                    }
                }
                else
                {
                    if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(current.ServerAddress, current.UserName, current.Password))
                    {
                        server = new Microsoft.SqlServer.Management.Smo.Server(new Microsoft.SqlServer.Management.Common.ServerConnection(current.ServerAddress, current.UserName, current.Password));
                    }
                }

                if (server != null)
                {
                    MainTreeView.Nodes.Clear();

                    AddServer(server);

                    Microsoft.SqlServer.Management.Smo.Server server1 = (Microsoft.SqlServer.Management.Smo.Server)serverlist[serverlist.Count - 1];
                    serverNode = new TreeNode();
                    serverNode.Name = server1.Name;
                    serverNode.Text = server1.Name;
                    serverNode.ImageIndex = 0;
                    serverNode.SelectedImageIndex = 0;
                    serverNode.Tag = server1;
                    this.MainTreeView.Nodes.Add(serverNode);
                }
            }
        }

        public void AddServer(Microsoft.SqlServer.Management.Smo.Server objServer)
        {
            this.serverlist.Add(objServer);
        }

        private void ExchangeTreeNodeExpand(TreeNode treenode)
        {
            treenode.Expand();
        }

        //�����ѡ��ķ�������������

        #region �����ѡ��ķ�������������

        /// <summary>
        /// �����ѡ��ķ�������������
        /// </summary>
        /// <param name="servername">��������</param>
        /// <returns>�����ѡ��ķ�������������</returns>
        private int GetNodeSelectServerIndex(string servername)
        {
            int index = 0;
            for (int i = 0; i < serverlist.Count; i++)
            {
                Microsoft.SqlServer.Management.Smo.Server servertmp = (Microsoft.SqlServer.Management.Smo.Server)serverlist[i];
                if (servertmp.Name == servername)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        #endregion �����ѡ��ķ�������������

        //����ֶε�����

        #region ����ֶε�����

        /// <summary>
        /// ����ֶε�����
        /// </summary>
        /// <param name="column">�ֶ�</param>
        /// <returns>����ֶε�����</returns>
        private string GetColumnDescription(Microsoft.SqlServer.Management.Smo.Column column)
        {
            StringBuilder builder = new StringBuilder(column.Name);
            builder.Append(" (");
            if (column.InPrimaryKey)
            {
                builder.Append("PK, ");
            }
            if (column.IsForeignKey)
            {
                builder.Append("FK, ");
            }
            builder.Append(column.DataType);
            switch (column.DataType.ToString().ToLower())
            {
                case "nchar":
                case "nvarchar":
                case "char":
                case "varchar":
                case "nvarcharmax":
                case "varcharmax":
                case "binary":
                case "varbinary":
                case "varbinarymax":
                    builder.Append("(");
                    builder.Append(column.DataType.MaximumLength.ToString());
                    builder.Append(")");
                    break;

                default:
                    break;
            }
            builder.Append(", ");
            if (column.Nullable)
            {
                builder.Append("null");
            }
            else
            {
                builder.Append("not null");
            }
            builder.Append(")");
            return builder.ToString();
        }

        #endregion ����ֶε�����

        //�������������

        #region �������������

        /// <summary>
        /// �������������
        /// </summary>
        /// <param name="index">����</param>
        /// <returns>�������������</returns>
        private string GetIndexDescription(Microsoft.SqlServer.Management.Smo.Index index)
        {
            StringBuilder builder = new StringBuilder(index.Name);
            builder.Append(" (");
            if (index.IsUnique)
            {
                builder.Append("Ψһ��");
            }
            else
            {
                builder.Append("��Ψһ��");
            }
            if (index.IsClustered)
            {
                builder.Append("�ۼ�)");
            }
            else
            {
                builder.Append("�Ǿۼ�)");
            }
            return builder.ToString();
        }

        #endregion �������������

        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                //�������Ƿ����������������
                switch (e.Node.Level)
                {
                    case 0:
                        if (e.Node.Nodes.Count == 0)
                        {
                            //����serverlist������
                            int index = GetNodeSelectServerIndex(e.Node.Name);
                            Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[index];
                            //��������DataBases�Ľ��

                            #region ��������DataBases�Ľ��

                            foreach (Microsoft.SqlServer.Management.Smo.Database database in server.Databases)
                            {
                                //�ж��Ƿ���ϵͳ����
                                if (!database.IsSystemObject)
                                {
                                    TreeNode node = new TreeNode();
                                    node.Name = database.Name;
                                    node.Text = database.Name;
                                    node.ImageIndex = 1;
                                    node.SelectedImageIndex = 1;
                                    node.ContextMenuStrip = DBContentMenu;
                                    node.Tag = database;
                                    e.Node.Nodes.Add(node);
                                }
                            }

                            #endregion ��������DataBases�Ľ��
                        }

                        ExchangeTreeNodeExpand(e.Node);
                        break;

                    case 1:
                        if (e.Node.Nodes.Count == 0)
                        {
                            TreeNode node = new TreeNode();
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            node.Name = "��";
                            node.Text = "��";
                            e.Node.Nodes.Add(node);

                            node = new TreeNode();
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            node.Name = "��ͼ";
                            node.Text = "��ͼ";
                            e.Node.Nodes.Add(node);
                        }
                        ExchangeTreeNodeExpand(e.Node);
                        break;

                    case 2:
                        //ˢ��
                        {
                            if (e.Node.Nodes.Count == 0)
                            {
                                int index = GetNodeSelectServerIndex(e.Node.Parent.Parent.Name);
                                Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[index];

                                switch (e.Node.Name)
                                {
                                    case "��":
                                        //�������еı�
                                        //�ж��Ƿ���Ȩ��
                                        //Microsoft.SqlServer.Management.Smo.Database database = server.Databases[e.Node.Parent.Name];
                                        //Microsoft.SqlServer.Management.Smo.ObjectPermissionInfo objPermissionInfo=server.EnumObjectPermissions(

                                        #region �������еı�

                                        foreach (Microsoft.SqlServer.Management.Smo.Table table in server.Databases[e.Node.Parent.Name].Tables)
                                        {
                                            if (!table.IsSystemObject)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = table.Name;
                                                node.Text = table.Name;
                                                node.ImageIndex = 3;
                                                node.SelectedImageIndex = 3;
                                                node.Tag = table;
                                                node.ContextMenuStrip = this.DBContentMenu;
                                                e.Node.ContextMenuStrip = this.DBTableMenu;
                                                e.Node.Nodes.Add(node);
                                            }
                                        }

                                        #endregion �������еı�

                                        break;

                                    case "��ͼ":
                                        //�������е���ͼ

                                        #region �������е���ͼ

                                        foreach (Microsoft.SqlServer.Management.Smo.View view in server.Databases[e.Node.Parent.Name].Views)
                                        {
                                            if (!view.IsSystemObject)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = view.Name;
                                                node.Text = view.Name;
                                                node.ImageIndex = 7;
                                                node.SelectedImageIndex = 7;
                                                node.Tag = view;
                                                e.Node.Nodes.Add(node);
                                            }
                                        }

                                        #endregion �������е���ͼ

                                        break;

                                    default:
                                        break;
                                }
                            }
                            ExchangeTreeNodeExpand(e.Node);
                        }
                        break;

                    case 3:
                        if (e.Node.Nodes.Count == 0)
                        {
                            TreeNode node = new TreeNode();
                            node.Name = "��";
                            node.Text = "��";
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            e.Node.Nodes.Add(node);

                            if (e.Node.Parent.Name == "��")
                            {
                                node = new TreeNode();
                                node.Name = "��";
                                node.Text = "��";
                                node.ImageIndex = 2;
                                node.SelectedImageIndex = 2;
                                e.Node.Nodes.Add(node);

                                node = new TreeNode();
                                node.Name = "Լ��";
                                node.Text = "Լ��";
                                node.ImageIndex = 2;
                                node.SelectedImageIndex = 2;
                                e.Node.Nodes.Add(node);
                            }

                            node = new TreeNode();
                            node.Name = "����";
                            node.Text = "����";
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            e.Node.Nodes.Add(node);
                        }
                        ExchangeTreeNodeExpand(e.Node);

                        break;

                    case 4:
                        //�ҵ�������ķ�����
                        {
                            int serverindex = GetNodeSelectServerIndex(e.Node.Parent.Parent.Parent.Parent.Name);
                            Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[serverindex];

                            //����������
                            switch (e.Node.Name)
                            {
                                case "��":
                                    if (e.Node.Nodes.Count == 0)
                                    {
                                        if (e.Node.Parent.Parent.Name == "��")
                                        {
                                            foreach (Microsoft.SqlServer.Management.Smo.Column column in server.Databases[e.Node.Parent.Parent.Parent.Name].Tables[e.Node.Parent.Name].Columns)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = column.Name;
                                                node.Text = GetColumnDescription(column);
                                                if (column.InPrimaryKey || column.IsForeignKey)
                                                {
                                                    node.ImageIndex = 6;
                                                    node.SelectedImageIndex = 6;
                                                }
                                                else
                                                {
                                                    node.SelectedImageIndex = 4;
                                                    node.ImageIndex = 4;
                                                }
                                                e.Node.Nodes.Add(node);
                                            }
                                        }
                                        else
                                        {
                                            foreach (Microsoft.SqlServer.Management.Smo.Column column in server.Databases[e.Node.Parent.Parent.Parent.Name].Views[e.Node.Parent.Name].Columns)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = column.Name;
                                                node.Text = GetColumnDescription(column);
                                                if (column.InPrimaryKey || column.IsForeignKey)
                                                {
                                                    node.ImageIndex = 6;
                                                    node.SelectedImageIndex = 6;
                                                }
                                                else
                                                {
                                                    node.SelectedImageIndex = 4;
                                                    node.ImageIndex = 4;
                                                }
                                                e.Node.Nodes.Add(node);
                                            }
                                        }
                                    }
                                    break;

                                case "��":
                                    break;

                                case "Լ��":
                                    break;

                                case "����":
                                    if (e.Node.Nodes.Count == 0)
                                    {
                                        if (e.Node.Parent.Parent.Name == "��")
                                        {
                                            foreach (Microsoft.SqlServer.Management.Smo.Index index in server.Databases[e.Node.Parent.Parent.Parent.Name].Tables[e.Node.Parent.Name].Indexes)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = index.Name;
                                                node.Text = GetIndexDescription(index);
                                                node.ImageIndex = 5;
                                                node.SelectedImageIndex = 5;
                                                e.Node.Nodes.Add(node);
                                            }
                                        }
                                        else
                                        {
                                            foreach (Microsoft.SqlServer.Management.Smo.Index index in server.Databases[e.Node.Parent.Parent.Parent.Name].Views[e.Node.Parent.Name].Indexes)
                                            {
                                                TreeNode node = new TreeNode();
                                                node.Name = index.Name;
                                                node.Text = GetIndexDescription(index);
                                                node.ImageIndex = 5;
                                                node.SelectedImageIndex = 5;
                                                e.Node.Nodes.Add(node);
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    break;
                            }
                            ExchangeTreeNodeExpand(e.Node);
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void ����C����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IServer serverCore = CreateFactory.CreateServer();
            IDatabase databaseCore = CreateFactory.CreateDatabase();

            TreeNode selectedNode = MainTreeView.SelectedNode;
            if (selectedNode.Tag is Microsoft.SqlServer.Management.Smo.Database)
            {
                Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[GetNodeSelectServerIndex(MainTreeView.SelectedNode.Parent.Name)];
                Microsoft.SqlServer.Management.Smo.Database database = server.Databases[MainTreeView.SelectedNode.Name];

                databaseCore.Name = database.Name;
                if (database.DatabaseOptions.Properties.Contains("CB_MEMO"))
                {
                    databaseCore.Comment = database.DatabaseOptions.Properties["CB_MEMO"].Value.ToString();
                }
                foreach (Microsoft.SqlServer.Management.Smo.Table table in database.Tables)
                {
                    ITable tableCore = CreateFactory.CreateTable();
                    tableCore.Name = table.Name;
                    if (table.Properties.Contains("CB_MEMO"))
                    {
                        tableCore.Comment = table.Properties["CB_MEMO"].Value.ToString();
                    }
                    //����ṹ����ֶ�
                    foreach (Microsoft.SqlServer.Management.Smo.Column column in table.Columns)
                    {
                        IColumn columnCore = CreateFactory.CreateColumn();
                        columnCore.Name = column.Name;
                        if (column.DataType.SqlDataType == Microsoft.SqlServer.Management.Smo.SqlDataType.Xml)
                        {
                            columnCore.DbType = "nvarchar";
                        }
                        else
                        {
                            columnCore.DbType = column.DataType.Name;
                        }

                        if (columnCore.DbType == "ntext" || columnCore.DbType == "text")
                            columnCore.Precision = -1;
                        else
                            columnCore.Precision = column.DataType.MaximumLength;
                        columnCore.IsPrimaryKey = column.InPrimaryKey;
                        columnCore.AllowNull = column.Nullable;
                        columnCore.AutoIncrement = column.Identity;
                        if (column.ExtendedProperties.Count > 0)
                            columnCore.Comment = column.ExtendedProperties[0].Value.ToString();
                        //��Բ�ͬ�ֶ����ͽ��д���
                        tableCore.AddColumn(columnCore);
                    }

                    databaseCore.AddTable(tableCore);
                }
            }
            else
            {
                ITable tableCore = CreateFactory.CreateTable();

                if (selectedNode.Parent.Parent != null)
                {
                    if (selectedNode.Parent.Parent.Tag is Microsoft.SqlServer.Management.Smo.Database)
                    {
                        Microsoft.SqlServer.Management.Smo.Database database = selectedNode.Parent.Parent.Tag as Microsoft.SqlServer.Management.Smo.Database;
                        databaseCore.Name = database.Name;
                    }
                }

                Microsoft.SqlServer.Management.Smo.Table table = selectedNode.Tag as Microsoft.SqlServer.Management.Smo.Table;
                tableCore.Name = table.Name;

                //����ṹ����ֶ�
                foreach (Microsoft.SqlServer.Management.Smo.Column column in table.Columns)
                {
                    IColumn columnCore = CreateFactory.CreateColumn();
                    columnCore.Name = column.Name;

                    if (column.DataType.SqlDataType == Microsoft.SqlServer.Management.Smo.SqlDataType.Xml)
                    {
                        columnCore.DbType = "nvarchar";
                    }
                    else
                    {
                        columnCore.DbType = column.DataType.Name;
                    }
                    if (columnCore.DbType == "ntext" || columnCore.DbType == "text")
                        columnCore.Precision = -1;
                    else
                        columnCore.Precision = column.DataType.MaximumLength;
                    columnCore.IsPrimaryKey = column.InPrimaryKey;
                    columnCore.AllowNull = column.Nullable;
                    columnCore.AutoIncrement = column.Identity;
                    if (column.ExtendedProperties.Count > 0)
                    {
                        columnCore.Comment = column.ExtendedProperties[0].Value.ToString();
                        columnCore.Comment = columnCore.Comment.Replace("\r", "");
                        columnCore.Comment = columnCore.Comment.Replace("\n", "");
                    }
                    //��Բ�ͬ�ֶ����ͽ��д���
                    tableCore.AddColumn(columnCore);
                }

                databaseCore.AddTable(tableCore);
            }

            ((MainFrm)this.DockPanel.Parent).GenerationCode(databaseCore);
        }

        private void toolStripMenuItemCreateTable_Click(object sender, EventArgs e)
        {
            TableDesignFrm frm = new TableDesignFrm();
            //frm.Owner = this;
            //((MainFrm)this.Tag).AddPanel(frm);
            ((MainFrm)this.DockPanel.Parent).AddPanel(frm);
        }

        private void MainTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node == serverNode) e.Node.Checked = false;

            if (e.Node.Parent != serverNode)
            {
                e.Node.Parent.Checked = true;
            }
        }

        //private bool hasChecked
    }
}