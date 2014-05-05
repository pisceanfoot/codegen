using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Servers : Collection, IServers, IEnumerable, ICollection
    {
        #region 公有方法

        /// <summary>
        /// 获取服务器
        /// </summary>
        /// <param name="databaseName">服务器名称</param>
        /// <returns>获取指定的服务器。若服务器不存在则返回 <strong>null</strong></returns>
        public IServer GetServer(string serverName)
        {
            string lowCaseServerName = serverName.ToLower();

            foreach (IServer server in this.array)
            {
                if (server.Name.ToLower().Equals(lowCaseServerName))
                    return server;
            }

            return null;
        }

        /// <summary>
        /// 添加服务器
        /// </summary>
        /// <param name="database">服务器信息</param>
        public void AddServer(IServer server)
        {
            this.Add(server);
        }

        #endregion 公有方法

        #region IServers 成员

        public IServer this[object index]
        {
            get
            {
                if (index.GetType() == Type.GetType("System.String"))
                {
                    return GetServer(index as string);
                }
                else
                {
                    int tmpIndex = Convert.ToInt32(index);
                    return (IServer)array[tmpIndex];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        #endregion IServers 成员

        #region IList 成员

        object IList.this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
            }
        }

        #endregion IList 成员
    }
}