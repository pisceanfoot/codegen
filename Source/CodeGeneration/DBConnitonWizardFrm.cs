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

        //ȡ����ť
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //�رձ�����
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //��������
            DataBaseFrm objOwner = (DataBaseFrm)this.Owner;
            //�������ݲ��ԣ��ж��Ƿ���Ȩ��
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
            //�������ݲ��ԣ��ж��Ƿ���Ȩ��
            if (cmbSQLValidModeSelect.SelectedIndex == 0)
            {
#if DEBUG
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.Text))
#else
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.SelectedValue.ToString()))
#endif
                {
                    MessageBox.Show("���Գɹ���", "��Ϣ", MessageBoxButtons.OK);
                    btnConnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("�޷����ӣ�", "��Ϣ", MessageBoxButtons.OK);
                    btnConnect.Enabled = false;
                }
            }
            else
            {
                if (ChinaBest.SQLServer.SmoUtilities.SmoTools.TestDBConnection(cmbServerSelect.Text, cmbAccountSelect.Text, txtPassword.Text))
                {
                    MessageBox.Show("���Գɹ���", "��Ϣ", MessageBoxButtons.OK);
                    btnConnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("�޷����ӣ�", "��Ϣ", MessageBoxButtons.OK);
                    btnConnect.Enabled = false;
                }
            }
        }

        private void DBConnitonWizardFrm_Load(object sender, EventArgs e)
        {
            //Ĭ������趨Ϊ��ǰ�û���¼ģʽ
            UseWindowsValid();
#if DEBUG
            cmbServerSelect.Items.Add("(local)");
            cmbServerSelect.SelectedIndex = 0;
#else
            //���SQL Server�������б�
            DataTable dt = GetAllSQLServerList();

            cmbServerSelect.DataSource = dt.DefaultView;
            cmbServerSelect.DisplayMember = "Server";
            cmbServerSelect.ValueMember = "Server";
            if (dt.Rows.Count > 0)
                cmbServerSelect.SelectedIndex = 0;
#endif
        }

        //ʹ��Windows�����֤

        #region ʹ��Windows�����֤

        /// <summary>
        /// ʹ��Windows�����֤
        /// </summary>
        private void UseWindowsValid()
        {
            this.cmbSQLValidModeSelect.Text = "Windows �����֤";

            this.txtPassword.Enabled = false;
            this.lblUsername.Enabled = false;
            this.lblPassword.Enabled = false;
            this.chkRememberPassword.Enabled = false;
            string strUsername = ChinaBest.SQLServer.SmoUtilities.SmoTools.GetCurrectAccountInfo();
            cmbAccountSelect.Text = strUsername;
            this.cmbAccountSelect.Enabled = false;
        }

        #endregion ʹ��Windows�����֤

        //ʹ��SQL Server�����֤

        #region ʹ��SQL Server�����֤

        /// <summary>
        /// ʹ��SQL Server�����֤
        /// </summary>
        private void UnUseWindowsValid()
        {
            this.cmbSQLValidModeSelect.Text = "SQL Server �����֤";
            this.cmbAccountSelect.Enabled = true;
            this.txtPassword.Enabled = true;
            this.lblUsername.Enabled = true;
            this.lblPassword.Enabled = true;
            this.chkRememberPassword.Enabled = true;
            cmbAccountSelect.Text = "sa";
        }

        #endregion ʹ��SQL Server�����֤

        //������п��Է��ʵķ������б�

        #region ������п��Է��ʵķ������б�

        /// <summary>
        /// ������п��Է��ʵķ������б�
        /// </summary>
        /// <returns>���Է��ʵķ������б�</returns>
        private System.Data.DataTable GetAllSQLServerList()
        {
            //��������е�SQL����
            DataTable dt = ChinaBest.SQLServer.SmoUtilities.SmoTools.GetSQLServerList();
            //���ӱ���Localhost

            #region ���ӱ���Localhost

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

            #endregion ���ӱ���Localhost

            //���Ӳ��Է�������SQLServer

            #region ���Ӳ��Է�������SQLServer

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

            #endregion ���Ӳ��Է�������SQLServer

            return dt;
        }

        #endregion ������п��Է��ʵķ������б�

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