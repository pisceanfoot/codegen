using System;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// 描述 SQL Server 列信息
    /// </summary>
    [Serializable]
    internal class Column : IColumn
    {
        #region 私有成员变量

        private string name;                                // 表名
        private string alias;                               // 别名
        private bool isPrimaryKey;                          // 是否为主键
        private int size;                                   // 字段长度
        private int precision;                              // 字段精度
        private int scale;                                  // 字段小说位
        private bool allowNull;                             // 否则允许空值
        private bool autoIncrement;                         // 是否自增长
        private string defaultValue;                        // 默认值
        private string comment;                             // 备注
        private string languageType;                        // 字段对应 C# 类型
        private string sqlClientType;                       // 字段对应的SqlClient类型
        private string emptyValue;                          // 字段对应 C# 类型的默认值
        private string convertValue;                        // 字段的转换函数
        private string dbType;                              // 数据库字段类型
        private string programeDbType;                      // 字段对应 C# 中 System.Data.DbType
        private string shortProgrameDbType;                 // 字段对应 C# 中 System.Data.DbType

        #endregion 私有成员变量

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Column()
        {
            name = string.Empty;
            alias = string.Empty;
            isPrimaryKey = false;
            size = 0;
            precision = 0;
            scale = 0;
            allowNull = false;
            autoIncrement = false;
            defaultValue = string.Empty;
            comment = string.Empty;
            languageType = string.Empty;
            dbType = "varchar";
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">列名</param>
        /// <param name="isPrimaryKey">是否为主键</param>
        /// <param name="size">长度</param>
        /// <param name="presicion">精度</param>
        /// <param name="scale">小数位</param>
        public Column(string name, bool isPrimaryKey, int size, int presicion, int scale)
            : this()
        {
            this.name = name;
            this.isPrimaryKey = isPrimaryKey;
            this.size = size;
            this.precision = precision;
            this.scale = scale;
        }

        #endregion 构造函数

        #region IColumn 成员

        /// <summary>
        /// 获取或设置表名称
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
        /// 获取或设置表别名
        /// </summary>
        public string Alias
        {
            get
            {
                return alias;
            }
            set
            {
                alias = value;
            }
        }

        /// <summary>
        /// 获取或设置是否为主键
        /// </summary>
        public bool IsPrimaryKey
        {
            get
            {
                return isPrimaryKey;
            }
            set
            {
                isPrimaryKey = value;
            }
        }

        /// <summary>
        /// 获取或设置字段长度
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// 获取或设置精度
        /// </summary>
        public int Precision
        {
            get
            {
                return precision;
            }
            set
            {
                precision = value;
            }
        }

        /// <summary>
        /// 获取或设置小数位
        /// </summary>
        public int Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        /// <summary>
        /// 获取或设置是否允许空值
        /// </summary>
        public bool AllowNull
        {
            get
            {
                return allowNull;
            }
            set
            {
                allowNull = value;
            }
        }

        /// <summary>
        /// 获取或设置自增长
        /// </summary>
        public bool AutoIncrement
        {
            get
            {
                return autoIncrement;
            }
            set
            {
                autoIncrement = value;
            }
        }

        /// <summary>
        /// 获取或设置默认值
        /// </summary>
        public string Default
        {
            get
            {
                return defaultValue;
            }
            set
            {
                defaultValue = value;
            }
        }

        /// <summary>
        ///  获取或设置备注
        /// </summary>
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }

        /// <summary>
        /// 获取或设置字段对应 C# 类型
        /// </summary>
        public string LanguageType
        {
            get { return languageType; }
            set { languageType = value; }
        }

        /// <summary>
        /// 获取映射的数据类型
        /// e.g. C#: SqlClent.Int
        /// </summary>
        public string SqlClientType
        {
            get { return sqlClientType; }
            set { sqlClientType = value; }
        }

        /// <summary>
        /// 获取映射的类型的默认值
        /// </summary>
        public string EmptyValue
        {
            get { return emptyValue; }
            set { emptyValue = value; }
        }

        /// <summary>
        /// 获取映射的类型的的转换函数
        /// e.g. Convert.ToString, Convert.ToInt32
        /// </summary>
        public string ConvertMethod
        {
            get { return convertValue; }
            set { convertValue = value; }
        }

        /// <summary>
        /// 获取或设置数据库字段类型。例如：int， varchar
        /// </summary>
        public string DbType
        {
            get { return dbType; }
            set { dbType = value; }
        }

        /// <summary>
        /// 获取或设置程序中的 DBType 类型 System.Data.DbType
        /// </summary>
        public string ProgrameDbType
        {
            get { return programeDbType; }
            set { programeDbType = value; }
        }

        /// <summary>
        /// 获取或设置程序中的 DBType 类型 System.Data.DbType, "DBType."后面部分
        /// </summary>
        public string ShortProgrameDbType
        {
            get { return shortProgrameDbType; }
            set { shortProgrameDbType = value; }
        }

        /// <summary>
        /// 获取列名的 PascalCase 格式
        /// </summary>
        public string PascalCaseName
        {
            get { return Util.SetPascalCase(name); }
        }

        /// <summary>
        /// 获取列名的 CamelCase 格式
        /// </summary>
        public string CamelCaseName
        {
            get { return Util.SetCamelCase(name); }
        }

        #endregion IColumn 成员
    }
}