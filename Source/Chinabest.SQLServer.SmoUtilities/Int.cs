using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace ChinaBest.SQLServer.SmoUtilities
{
    public class Int
    {
        #region 私有成员变量

        private string name;
        private string defaultValue;
        private string originalSQLType;
        private bool allowNull;
        private string rowguid;
        protected Identifier identifier = new Identifier();

        private bool primaryKey;
        private SqlDbType sqlType;

        private string dbType;
        private string size;
        private string precision;
        private string scale;

        private bool autoIncrement;
        private string netDataType;
        private string netDefaultValue;
        private string netConvertMethod;
        private string stringFormatType;
        private string comment;

        #endregion 私有成员变量

        #region 公有属性

        /// <summary>
        /// The name of the column.
        /// </summary>
        [XmlAttribute("Name")]
        [Category("(常规)"), DisplayName("(名称)"), DescriptionAttribute("(名称)")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        [XmlAttribute("DefaultValue")]
        [Category("(常规)"), DisplayName("默认值或绑定"), DescriptionAttribute("(默认值或绑定)")]
        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        /// <summary>
        /// The Original SQL type.
        /// </summary>
        [XmlAttribute("OriginalSQLType")]
        [Category("(常规)"), DisplayName("数据类型"), ReadOnly(false), DescriptionAttribute("数据类型")]
        public string OriginalSQLType
        {
            get { return originalSQLType; }
            set { originalSQLType = value; }
        }

        /// <summary>
        /// if this column is nullable.
        /// </summary>
        [XmlAttribute("AllowNull")]
        [Category("(常规)"), DisplayName("允许空"), ReadOnly(true), DescriptionAttribute("允许空")]
        public bool AllowNull
        {
            get { return allowNull; }
            set { allowNull = value; }
        }

        /// <summary>
        /// if this column is nullable.
        /// </summary>
        [XmlAttribute("RowGuid")]
        [TypeConverter(typeof(Identifier)), Category("表设计器"), DisplayName("RowGuid")]
        public string RowGrid
        {
            get { return rowguid; }
            set { rowguid = value; }
        }

        [Category("表设计器"), DisplayName("规范标识")]
        public Identifier Identity
        {
            get { return identifier; }
            set { identifier = value; }
        }

        #endregion 公有属性

        //[XmlAttribute("IDInfo")]
        //[Category("表设计器"), DisplayName("标识规范"), TypeConverterAttribute(typeof(one_type_derived_from_ExpandableObjectConverter))]
        //public bool IDInfo
        //{
        //    get{return idinfo;}
        //    set { idinfo = value; }
        //}
    }

    [TypeConverterAttribute(typeof(IdentifierConverter)), DescriptionAttribute("展开以查看标识规范选项。")]
    public class Identifier
    {
        private bool isIdentifier = false;
        private int identifierStep = 1;
        private int identifierSeed = 1;

        [DefaultValueAttribute(false), DisplayName("(是标识)")]
        public bool IsIdentifier
        {
            get { return isIdentifier; }
            set
            {
                isIdentifier = value;
                if (isIdentifier)
                {
                }
            }
        }

        [DefaultValueAttribute(1), DisplayName("标识增量"), ReadOnly(true)]
        public int IdentifierStep
        {
            get { return identifierStep; }
            set { identifierStep = value; }
        }

        [DefaultValueAttribute(1), DisplayName("标识种子"), ReadOnly(true)]
        public int IdentifierSeed
        {
            get { return identifierSeed; }
            set { identifierSeed = value; }
        }
    }
}