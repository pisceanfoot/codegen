using System;
using System.Data;
using System.Windows.Forms;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class DBConnitonWizardFrm : Form
    {
        public DBConnitonWizardFrm()
        {
            InitializeComponent();
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭本窗体
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //建立连接
            DataBaseFrm objOwner = (DataBaseFrm)this.Owner;
            //进行数据测试，判断是否有权限
            Microsoft.SqlServer.Management.Smo.Server server;
            if (cmbSQLValidModeSelect.SelectedIndex == 0)
            {
#if DEBUG
                server = new Microsoft.SqlServer.Management.Smo.Server(cmbServerSelect.Text);
#else
                server = new Microsoft.SqlServer.Management.Smo.Server(cmbServerSelect.Text);
#endif
            }
            else
            {
#if DEBUG
                server = new Microsoft.SqlServer.Management.Smo.Server(new Microsoft.SqlServer.Management.Common.ServerConnection(cmbServerSelect.Text, cmbAccountSelect.Text, txtPassword.Text));
#else
                server = new Microsoft.SqlServer.Management.Smo.Server(new Microsoft.SqlServer.Management.Common.ServerConnection(cmbServerSelect.Text, cmbAccountSelect.Text, txtPassword.Text));
#endif
            }

            MainFrm.CurrentConnection.IsWindowAuth = cmbSQLValidModeSelect.SelectedIndex == 0;
            MainFrm.CurrentConnection.ServerAddress = cmbServerSelect.Text;
            MainFrm.CurrentConnection.UserName = cmbAccountSelect.Text;
            MainFrm.CurrentConnection.Password = txtPassword.Text;

            objOwner.AddServer(server);
            this.DialogResult = DialogResult.OK;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //进行数据测试，判断是否有权限
            if (cmbSQLValidModeSelect.SelectedIndex == 0)
            {
#if DEBUG
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.Text))
#else
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.SelectedValue.ToString()))
#endif
                {
                    MessageBox.Show("测试成功！", "信息", MessageBoxButtons.OK);
                    btnConnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("无法连接！", "信息", MessageBoxButtons.OK);
                    btnConnect.Enabled = false;
                }
            }
            else
            {
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.Text, cmbAccountSelect.Text, txtPassword.Text))
                {
                    MessageBox.Show("测试成功！", "信息", MessageBoxButtons.OK);
                    btnConnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("无法连接！", "信息", MessageBoxButtons.OK);
                    btnConnect.Enabled = false;
                }
            }
        }

        private void DBConnitonWizardFrm_Load(object sender, EventArgs e)
        {
            //默认情况设定为当前用户登录模式
            UseWindowsValid();
#if DEBUG
            cmbServerSelect.Items.Add("(local)");
            cmbServerSelect.SelectedIndex = 0;
#else
            //获得SQL Server服务器列表
            DataTable dt = GetAllSQLServerList();

            cmbServerSelect.DataSource = dt.DefaultView;
            cmbServerSelect.DisplayMember = "Server";
            cmbServerSelect.ValueMember = "Server";
            if (dt.Rows.Count > 0)
                cmbServerSelect.SelectedIndex = 0;
#endif
        }

        //使用Windows身份验证

        #region 使用Windows身份验证

        /// <summary>
        /// 使用Windows身份验证
        /// </summary>
        private void UseWindowsValid()
        {
            this.cmbSQLValidModeSelect.Text = "Windows 身份验证";

            this.txtPassword.Enabled = false;
            this.lblUsername.Enabled = false;
            this.lblPassword.Enabled = false;
            this.chkRememberPassword.Enabled = false;
            string strUsername = ChinaBest.SQLServer.SmoUtilities.SmoTools.GetCurrectAccountInfo();
            cmbAccountSelect.Text = strUsername;
            this.cmbAccountSelect.Enabled = false;
        }

        #endregion 使用Windows身份验证

        //使用SQL Server身份验证

        #region 使用SQL Server身份验证

        /// <summary>
        /// 使用SQL Server身份验证
        /// </summary>
        private void UnUseWindowsValid()
        {
            this.cmbSQLValidModeSelect.Text = "SQL Server 身份验证";
            this.cmbAccountSelect.Enabled = true;
            this.txtPassword.Enabled = true;
            this.lblUsername.Enabled = true;
            this.lblPassword.Enabled = true;
            this.chkRememberPassword.Enabled = true;
            cmbAccountSelect.Text = "sa";
        }

        #endregion 使用SQL Server身份验证

        //获得所有可以访问的服务器列表

        #region 获得所有可以访问的服务器列表

        /// <summary>
        /// 获得所有可以访问的服务器列表
        /// </summary>
        /// <returns>可以访问的服务器列表</returns>
        private System.Data.DataTable GetAllSQLServerList()
        {
            //获得网络中的SQL环境
            DataTable dt = ChinaBest.SQLServer.SmoUtilities.SmoTools.GetSQLServerList();
            //增加本地Localhost

            #region 增加本地Localhost

            {
                DataRow dr = dt.NewRow();
                dr["Name"] = "(local)";
                dr["Server"] = "(local)";
                dr["Instance"] = "";
                dr["IsClustered"] = true;
                dr["Version"] = "";
                dr["IsLocal"] = true;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            #endregion 增加本地Localhost

            //增加测试服务器的SQLServer

            #region 增加测试服务器的SQLServer

            {
                DataRow dr = dt.NewRow();
                string TestServer = System.Configuration.ConfigurationManager.AppSettings["TestServer"];
                if (string.IsNullOrEmpty(TestServer))
                {
                    TestServer = "localhost";
                }
                dr["Name"] = TestServer;
                dr["Server"] = TestServer;
                dr["Instance"] = "";
                dr["IsClustered"] = true;
                dr["Version"] = "";
                dr["IsLocal"] = false;
                dt.Rows.InsertAt(dr, 1);
                dt.AcceptChanges();
            }

            #endregion 增加测试服务器的SQLServer

            return dt;
        }

        #endregion 获得所有可以访问的服务器列表

        private void cmbSQLValidModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSQLValidModeSelect.SelectedIndex == 0)
            {
                UseWindowsValid();
            }
            else
            {
                UnUseWindowsValid();
            }
        }

        private void cmbServerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
        }
    }
}