using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace ChinaBest.SQLServer.SmoUtilities
{
    public class SmoTools
    {
        private Server objServer;
        private ServerConnection objSvrConn;

        public static bool ConnectServerWithServerInstance(string ServerInstance)
        {
            Microsoft.SqlServer.Management.Smo.Table tb = new Table();

            return true;
        }

        /// <summary>
        /// ��õ�ǰ���������ʻ���Ϣ
        /// </summary>
        /// <returns>��õ�ǰ���������ʻ���Ϣ</returns>
        public static string GetCurrectAccountInfo()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        //��ÿɷ��ʵķ�����SQLServer�������б�

        #region ��ÿɷ��ʵķ�����SQLServer�������б�

        /// <summary>
        /// ��ÿɷ��ʵķ�����SQLServer�������б�
        /// </summary>
        /// <returns>��ÿɷ��ʵķ�����SQLServer�������б�</returns>
        public static System.Data.DataTable GetSQLServerList()
        {
            return SmoApplication.EnumAvailableSqlServers();
        }

        #endregion ��ÿɷ��ʵķ�����SQLServer�������б�

        //���Է������Ƿ���Ȩ������

        #region ���Է������Ƿ���Ȩ������

        /// <summary>
        /// ���Է������Ƿ���Ȩ������
        /// </summary>
        /// <param name="ServerInstance">������ʵ��</param>
        /// <returns>�Ƿ��������</returns>
        public static bool TestDBConnection(string ServerInstance)
        {
            bool result = false;
            try
            {
                //����������ʵ��
                Microsoft.SqlServer.Management.Smo.Server server = new Server(new Microsoft.SqlServer.Management.Common.ServerConnection(ServerInstance));
                server.ConnectionContext.ConnectTimeout = 1;
                server.ConnectionContext.Connect();
                if (server.ConnectionContext.IsOpen)
                {
                    result = true;
                }
                server.ConnectionContext.Disconnect();
            }
            catch
            {
            }
            return result;
        }

        #endregion ���Է������Ƿ���Ȩ������

        //���Է������Ƿ���Ȩ������

        #region ���Է������Ƿ���Ȩ������

        /// <summary>
        /// ���Է������Ƿ���Ȩ������
        /// </summary>
        /// <param name="ServerInstance">������ʵ��</param>
        /// <param name="username">�û���</param>
        /// <param name="password">����</param>
        /// <returns>�Ƿ��������</returns>
        public static bool TestDBConnection(string ServerInstance, string username, string password)
        {
            bool result = false;
            try
            {
                //����������ʵ��
                Microsoft.SqlServer.Management.Smo.Server server = new Server(new Microsoft.SqlServer.Management.Common.ServerConnection(ServerInstance, username, password));
                server.ConnectionContext.ConnectTimeout = 1;
                server.ConnectionContext.Connect();
                if (server.ConnectionContext.IsOpen)
                {
                    result = true;
                }
                server.ConnectionContext.Disconnect();
            }
            catch
            {
            }
            return result;
        }

        #endregion ���Է������Ƿ���Ȩ������
    }
}