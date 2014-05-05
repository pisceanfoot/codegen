using System;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Server : IServer
    {
        #region 私有成员变量

        private string name;                            // 服务器名称
        private string address;                         // 服务器地址
        private string username;                        // 用户名
        private string password;                        // 密码
        private int authorityType;                      // 验证方式
        private IDatabases databases;                   // 列集合

        #endregion 私有成员变量

        #region 构造函数

        /// <summary>
        /// 默认构造函数
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
        /// 构造函数
        /// </summary>
        /// <param name="name">服务器名称</param>
        /// <param name="address">服务器地址</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="audhorityType">验证方式 0：windows认证；1：Sql Server 认证</param>
        public Server(string name, string address, string username, string password, int audhorityType)
        {
            this.name = name;
            this.address = address;
            this.username = username;
            this.password = password;
            this.authorityType = audhorityType;
            this.databases = null;
        }

        #endregion 构造函数

        #region IServer 成员

        /// <summary>
        /// 获取或设置服务器名称
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
        /// 获取或设置服务器地址
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
        /// 获取或设置用户名
        /// </summary>
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// 获取或设置密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// 获取或设置验证方式 0：集成windows认证。1：SQL Server 验证
        /// </summary>
        public int AuthorityType
        {
            get { return authorityType; }
            set { authorityType = value; }
        }

        /// <summary>
        /// 获取或设置数据库集合
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

        #endregion IServer 成员

        #region 公有方法

        /// <summary>
        /// 添加数据库
        /// </summary>
        /// <param name="databsae">数据库信息</param>
        public void AddDatabase(IDatabase databsae)
        {
            if (databsae == null) throw new ArgumentException("databsae 不能为空");
            Databases.Add(databsae);
        }

        #endregion 公有方法
    }
}