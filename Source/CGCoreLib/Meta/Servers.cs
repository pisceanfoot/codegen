using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Servers : Collection, IServers, IEnumerable, ICollection
    {
        #region ���з���

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="databaseName">����������</param>
        /// <returns>��ȡָ���ķ����������������������򷵻� <strong>null</strong></returns>
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
        /// ��ӷ�����
        /// </summary>
        /// <param name="database">��������Ϣ</param>
        public void AddServer(IServer server)
        {
            this.Add(server);
        }

        #endregion ���з���

        #region IServers ��Ա

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

        #endregion IServers ��Ա

        #region IList ��Ա

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

        #endregion IList ��Ա
    }
}