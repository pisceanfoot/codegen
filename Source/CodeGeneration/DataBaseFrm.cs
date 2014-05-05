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
                //将serverlist中的最后一个服务器加入到服务器树中
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

        //获得所选择的服务器的索引号

        #region 获得所选择的服务器的索引号

        /// <summary>
        /// 获得所选择的服务器的索引号
        /// </summary>
        /// <param name="servername">服务器名</param>
        /// <returns>获得所选择的服务器的索引号</returns>
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

        #endregion 获得所选择的服务器的索引号

        //获得字段的描述

        #region 获得字段的描述

        /// <summary>
        /// 获得字段的描述
        /// </summary>
        /// <param name="column">字段</param>
        /// <returns>获得字段的描述</returns>
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

        #endregion 获得字段的描述

        //获得索引的描述

        #region 获得索引的描述

        /// <summary>
        /// 获得索引的描述
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>获得索引的描述</returns>
        private string GetIndexDescription(Microsoft.SqlServer.Management.Smo.Index index)
        {
            StringBuilder builder = new StringBuilder(index.Name);
            builder.Append(" (");
            if (index.IsUnique)
            {
                builder.Append("唯一，");
            }
            else
            {
                builder.Append("不唯一，");
            }
            if (index.IsClustered)
            {
                builder.Append("聚集)");
            }
            else
            {
                builder.Append("非聚集)");
            }
            return builder.ToString();
        }

        #endregion 获得索引的描述

        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                //如果点的是服务器，则进行连接
                switch (e.Node.Level)
                {
                    case 0:
                        if (e.Node.Nodes.Count == 0)
                        {
                            //查找serverlist的索引
                            int index = GetNodeSelectServerIndex(e.Node.Name);
                            Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[index];
                            //返回所有DataBases的结点

                            #region 返回所有DataBases的结点

                            foreach (Microsoft.SqlServer.Management.Smo.Database database in server.Databases)
                            {
                                //判断是否是系统对象
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

                            #endregion 返回所有DataBases的结点
                        }

                        ExchangeTreeNodeExpand(e.Node);
                        break;

                    case 1:
                        if (e.Node.Nodes.Count == 0)
                        {
                            TreeNode node = new TreeNode();
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            node.Name = "表";
                            node.Text = "表";
                            e.Node.Nodes.Add(node);

                            node = new TreeNode();
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            node.Name = "视图";
                            node.Text = "视图";
                            e.Node.Nodes.Add(node);
                        }
                        ExchangeTreeNodeExpand(e.Node);
                        break;

                    case 2:
                        //刷新
                        {
                            if (e.Node.Nodes.Count == 0)
                            {
                                int index = GetNodeSelectServerIndex(e.Node.Parent.Parent.Name);
                                Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[index];

                                switch (e.Node.Name)
                                {
                                    case "表":
                                        //建立所有的表
                                        //判断是否有权限
                                        //Microsoft.SqlServer.Management.Smo.Database database = server.Databases[e.Node.Parent.Name];
                                        //Microsoft.SqlServer.Management.Smo.ObjectPermissionInfo objPermissionInfo=server.EnumObjectPermissions(

                                        #region 建立所有的表

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

                                        #endregion 建立所有的表

                                        break;

                                    case "视图":
                                        //建立所有的视图

                                        #region 建立所有的视图

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

                                        #endregion 建立所有的视图

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
                            node.Name = "列";
                            node.Text = "列";
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            e.Node.Nodes.Add(node);

                            if (e.Node.Parent.Name == "表")
                            {
                                node = new TreeNode();
                                node.Name = "键";
                                node.Text = "键";
                                node.ImageIndex = 2;
                                node.SelectedImageIndex = 2;
                                e.Node.Nodes.Add(node);

                                node = new TreeNode();
                                node.Name = "约束";
                                node.Text = "约束";
                                node.ImageIndex = 2;
                                node.SelectedImageIndex = 2;
                                e.Node.Nodes.Add(node);
                            }

                            node = new TreeNode();
                            node.Name = "索引";
                            node.Text = "索引";
                            node.ImageIndex = 2;
                            node.SelectedImageIndex = 2;
                            e.Node.Nodes.Add(node);
                        }
                        ExchangeTreeNodeExpand(e.Node);

                        break;

                    case 4:
                        //找到所点击的服务器
                        {
                            int serverindex = GetNodeSelectServerIndex(e.Node.Parent.Parent.Parent.Parent.Name);
                            Microsoft.SqlServer.Management.Smo.Server server = (Microsoft.SqlServer.Management.Smo.Server)serverlist[serverindex];

                            //如果点的是列
                            switch (e.Node.Name)
                            {
                                case "列":
                                    if (e.Node.Nodes.Count == 0)
                                    {
                                        if (e.Node.Parent.Parent.Name == "表")
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

                                case "键":
                                    break;

                                case "约束":
                                    break;

                                case "索引":
                                    if (e.Node.Nodes.Count == 0)
                                    {
                                        if (e.Node.Parent.Parent.Name == "表")
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

        private void 生成C代码ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    //给表结构添加字段
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
                        //针对不同字段类型进行处理
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

                //给表结构添加字段
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
                    //针对不同字段类型进行处理
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