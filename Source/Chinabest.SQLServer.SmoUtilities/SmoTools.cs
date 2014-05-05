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
        /// 获得当前服务器的帐户信息
        /// </summary>
        /// <returns>获得当前服务器的帐户信息</returns>
        public static string GetCurrectAccountInfo()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        //获得可访问的服务器SQLServer服务器列表

        #region 获得可访问的服务器SQLServer服务器列表

        /// <summary>
        /// 获得可访问的服务器SQLServer服务器列表
        /// </summary>
        /// <returns>获得可访问的服务器SQLServer服务器列表</returns>
        public static System.Data.DataTable GetSQLServerList()
        {
            return SmoApplication.EnumAvailableSqlServers();
        }

        #endregion 获得可访问的服务器SQLServer服务器列表

        //测试服务器是否有权限连接

        #region 测试服务器是否有权限连接

        /// <summary>
        /// 测试服务器是否有权限连接
        /// </summary>
        /// <param name="ServerInstance">服务器实例</param>
        /// <returns>是否可以连接</returns>
        public static bool TestDBConnection(string ServerInstance)
        {
            bool result = false;
            try
            {
                //创建服务器实例
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

        #endregion 测试服务器是否有权限连接

        //测试服务器是否有权限连接

        #region 测试服务器是否有权限连接

        /// <summary>
        /// 测试服务器是否有权限连接
        /// </summary>
        /// <param name="ServerInstance">服务器实例</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否可以连接</returns>
        public static bool TestDBConnection(string ServerInstance, string username, string password)
        {
            bool result = false;
            try
            {
                //创建服务器实例
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

        #endregion 测试服务器是否有权限连接
    }
}