using System;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Database : IDatabase
    {
        #region 私有成员变量

        private string name;                            // 数据库名称
        private string alias;                           // 数据库别名
        private string comment;                         // 数据库描述
        private DatabaseType databaseType;              // 数据库类型
        private ITables tables;                         // 表集合
        private IViews views;                           // 视图集合

        #endregion 私有成员变量

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Database()
            : this(string.Empty, string.Empty, DatabaseType.SqlServer2005)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">数据库名称</param>
        /// <param name="alias">数据库别名</param>
        /// <param name="databaseType">数据库类型</param>
        public Database(string name, string alias, DatabaseType databaseType)
        {
            this.name = name;
            this.alias = alias;
            this.databaseType = databaseType;
        }

        #endregion 构造函数

        #region IDatabase 成员

        /// <summary>
        /// 获取服务器信息
        /// </summary>
        public IServer Server
        {
            get { return null; }
        }

        /// <summary>
        /// 获取或设置数据库名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 获取或设置数据库别名
        /// </summary>
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// 获取或设置数据库类型
        /// </summary>
        public DatabaseType DbServerType
        {
            get { return databaseType; }
            set { databaseType = value; }
        }

        /// <summary>
        /// 获取或设置表集合
        /// </summary>
        public ITables Tables
        {
            get
            {
                if (tables == null) tables = CreateFactory.CreateTables();
                return tables;
            }
            set { tables = value; }
        }

        /// <summary>
        /// 获取或设置视图集合
        /// </summary>
        public IViews Views
        {
            get
            {
                if (views == null) views = CreateFactory.CreateViews();
                return views;
            }
            set { views = value; }
        }

        #endregion IDatabase 成员

        #region 公有方法

        /// <summary>
        /// 添加表
        /// </summary>
        /// <param name="talbe">表信息</param>
        public void AddTable(ITable table)
        {
            if (table == null) throw new ArgumentException("table 不能为空");
            Tables.Add(table);
        }

        /// <summary>
        /// 添加视图
        /// </summary>
        /// <param name="view">视图信息</param>
        public void AddView(IView view)
        {
            if (view == null) throw new ArgumentException("table 不能为空");
            Views.Add(view);
        }

        #endregion 公有方法
    }
}