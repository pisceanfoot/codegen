using System;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace ChinaBest.SQLServer.SmoUtilities
{
    /// <summary>
    /// 描述表中的列，及列中的属性在.Net中的关系
    /// </summary>
    [Serializable]
    public class SQLColumn
    {
        #region 私有成员变量

        private bool primaryKey;
        private SqlDbType sqlType;
        private string originalSQLType;
        private string dbType;
        private string size;
        private string precision;
        private string scale;
        private bool allowNull;
        private string name;
        private string defaultValue;
        private bool autoIncrement;
        private string netDataType;
        private string netDefaultValue;
        private string netConvertMethod;
        private string stringFormatType;
        private string comment;

        #endregion 私有成员变量

        #region 公有属性

        /// <summary>
        /// 主键
        /// </summary>
        [XmlAttribute("PrimaryKey")]
        [Category("配置"), DefaultValue(false), DisplayName("主键")]
        public bool PrimaryKey
        {
            get { return primaryKey; }
            set { primaryKey = value; }
        }

        /// <summary>
        /// Data type of the column.
        /// </summary>
        [XmlAttribute("SqlDbType")]
        [Browsable(false)]
        public SqlDbType SqlType
        {
            get { return sqlType; }
            set { sqlType = value; }
        }

        /// <summary>
        /// The Original SQL type.
        /// </summary>
        [XmlAttribute("OriginalSQLType")]
        [Category("配置"), DisplayName("数据类型"), ReadOnly(true)]
        public string OriginalSQLType
        {
            get { return originalSQLType; }
            set { originalSQLType = value; }
        }

        /// <summary>
        /// DbType Enum of spcial database in string format. Like SqlDbType.Int
        /// </summary>
        [XmlAttribute("DbType")]
        [Browsable(false)]
        public string DbType
        {
            get { return dbType; }
            set { dbType = value; }
        }

        /// <summary>
        /// Data size of the column.
        /// </summary>
        [XmlAttribute("Size")]
        [Category("配置"), DisplayName("长度")]
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The numeric precision of the column, 0 if not applicable
        /// </summary>
        [XmlAttribute("Precision")]
        [Category("配置"), DisplayName("精度")]
        public string Precision
        {
            get { return precision; }
            set { precision = value; }
        }

        /// <summary>
        /// The size of the numeric data in this column.
        /// </summary>
        [XmlAttribute("Scale")]
        [Category("配置"), DisplayName("小数位")]
        public string Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        /// <summary>
        /// if this column is nullable.
        /// </summary>
        [XmlAttribute("AllowNull")]
        [Category("配置"), DisplayName("允许空"), ReadOnly(true)]
        public bool AllowNull
        {
            get { return allowNull; }
            set { allowNull = value; }
        }

        /// <summary>
        /// The name of the column.
        /// </summary>
        [XmlAttribute("Name")]
        [Category("配置"), DisplayName("列名"), ReadOnly(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        [XmlAttribute("DefaultValue")]
        [Category("配置"), DisplayName("默认值")]
        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        /// <summary>
        /// if autoincrement column.
        /// </summary>
        [XmlAttribute("AutoIncrement")]
        [Category("配置"), DisplayName("自增长")]
        public bool AutoIncrement
        {
            get { return autoIncrement; }
            set { autoIncrement = value; }
        }

        /// <summary>
        /// The .NET column Data type.
        /// </summary>
        [XmlAttribute("NetDataType")]
        [Browsable(false)]
        public string NetDataType
        {
            get { return netDataType; }
            set { netDataType = value; }
        }

        /// <summary>
        /// Default value of .NET column Data type.
        /// </summary>
        [XmlAttribute("NetDefaultValue")]
        [Browsable(false)]
        public string NetDefaultValue
        {
            get { return netDefaultValue; }
            set { netDefaultValue = value; }
        }

        /// <summary>
        /// Convert Method
        /// </summary>
        [XmlAttribute("NetConvertMethod")]
        [Browsable(false)]
        public string NetConvertMethod
        {
            get { return netConvertMethod; }
            set { netConvertMethod = value; }
        }

        /// <summary>
        /// StringFormatType '{0}' or {0}
        /// </summary>
        [XmlAttribute("StringFormatType")]
        [Browsable(false)]
        public string StringFormatType
        {
            get { return stringFormatType; }
            set { stringFormatType = value; }
        }

        /// <summary>
        /// Column Comment
        /// </summary>
        [XmlAttribute("Comment")]
        [Category("配置"), DisplayName("备注")]
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        #endregion 公有属性
    }
}