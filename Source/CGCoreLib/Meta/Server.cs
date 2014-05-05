using System;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Server : IServer
    {
        #region ˽�г�Ա����

        private string name;                            // ����������
        private string address;                         // ��������ַ
        private string username;                        // �û���
        private string password;                        // ����
        private int authorityType;                      // ��֤��ʽ
        private IDatabases databases;                   // �м���

        #endregion ˽�г�Ա����

        #region ���캯��

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public Server()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.username = string.Empty;
            this.password = string.Empty;
            this.authorityType = 0;
            this.databases = null;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">����������</param>
        /// <param name="address">��������ַ</param>
        /// <param name="username">�û���</param>
        /// <param name="password">����</param>
        /// <param name="audhorityType">��֤��ʽ 0��windows��֤��1��Sql Server ��֤</param>
        public Server(string name, string address, string username, string password, int audhorityType)
        {
            this.name = name;
            this.address = address;
            this.username = username;
            this.password = password;
            this.authorityType = audhorityType;
            this.databases = null;
        }

        #endregion ���캯��

        #region IServer ��Ա

        /// <summary>
        /// ��ȡ�����÷���������
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// ��ȡ�����÷�������ַ
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        /// <summary>
        /// ��ȡ�������û���
        /// </summary>
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// ��ȡ��������֤��ʽ 0������windows��֤��1��SQL Server ��֤
        /// </summary>
        public int AuthorityType
        {
            get { return authorityType; }
            set { authorityType = value; }
        }

        /// <summary>
        /// ��ȡ���������ݿ⼯��
        /// </summary>
        public IDatabases Databases
        {
            get
            {
                if (databases == null) databases = CreateFactory.CreateDatabases();

                return databases;
            }
            set
            {
                databases = value;
            }
        }

        #endregion IServer ��Ա

        #region ���з���

        /// <summary>
        /// ������ݿ�
        /// </summary>
        /// <param name="databsae">���ݿ���Ϣ</param>
        public void AddDatabase(IDatabase databsae)
        {
            if (databsae == null) throw new ArgumentException("databsae ����Ϊ��");
            Databases.Add(databsae);
        }

        #endregion ���з���
    }
}