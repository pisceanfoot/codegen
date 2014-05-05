using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace ChinaBest.SQLServer.SmoUtilities
{
    public class Int
    {
        #region ˽�г�Ա����

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

        #endregion ˽�г�Ա����

        #region ��������

        /// <summary>
        /// The name of the column.
        /// </summary>
        [XmlAttribute("Name")]
        [Category("(����)"), DisplayName("(����)"), DescriptionAttribute("(����)")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Ĭ��ֵ
        /// </summary>
        [XmlAttribute("DefaultValue")]
        [Category("(����)"), DisplayName("Ĭ��ֵ���"), DescriptionAttribute("(Ĭ��ֵ���)")]
        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        /// <summary>
        /// The Original SQL type.
        /// </summary>
        [XmlAttribute("OriginalSQLType")]
        [Category("(����)"), DisplayName("��������"), ReadOnly(false), DescriptionAttribute("��������")]
        public string OriginalSQLType
        {
            get { return originalSQLType; }
            set { originalSQLType = value; }
        }

        /// <summary>
        /// if this column is nullable.
        /// </summary>
        [XmlAttribute("AllowNull")]
        [Category("(����)"), DisplayName("�����"), ReadOnly(true), DescriptionAttribute("�����")]
        public bool AllowNull
        {
            get { return allowNull; }
            set { allowNull = value; }
        }

        /// <summary>
        /// if this column is nullable.
        /// </summary>
        [XmlAttribute("RowGuid")]
        [TypeConverter(typeof(Identifier)), Category("�������"), DisplayName("RowGuid")]
        public string RowGrid
        {
            get { return rowguid; }
            set { rowguid = value; }
        }

        [Category("�������"), DisplayName("�淶��ʶ")]
        public Identifier Identity
        {
            get { return identifier; }
            set { identifier = value; }
        }

        #endregion ��������

        //[XmlAttribute("IDInfo")]
        //[Category("�������"), DisplayName("��ʶ�淶"), TypeConverterAttribute(typeof(one_type_derived_from_ExpandableObjectConverter))]
        //public bool IDInfo
        //{
        //    get{return idinfo;}
        //    set { idinfo = value; }
        //}
    }

    [TypeConverterAttribute(typeof(IdentifierConverter)), DescriptionAttribute("չ���Բ鿴��ʶ�淶ѡ�")]
    public class Identifier
    {
        private bool isIdentifier = false;
        private int identifierStep = 1;
        private int identifierSeed = 1;

        [DefaultValueAttribute(false), DisplayName("(�Ǳ�ʶ)")]
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

        [DefaultValueAttribute(1), DisplayName("��ʶ����"), ReadOnly(true)]
        public int IdentifierStep
        {
            get { return identifierStep; }
            set { identifierStep = value; }
        }

        [DefaultValueAttribute(1), DisplayName("��ʶ����"), ReadOnly(true)]
        public int IdentifierSeed
        {
            get { return identifierSeed; }
            set { identifierSeed = value; }
        }
    }
}