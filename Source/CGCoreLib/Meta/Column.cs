using System;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ���� SQL Server ����Ϣ
    /// </summary>
    [Serializable]
    internal class Column : IColumn
    {
        #region ˽�г�Ա����

        private string name;                                // ����
        private string alias;                               // ����
        private bool isPrimaryKey;                          // �Ƿ�Ϊ����
        private int size;                                   // �ֶγ���
        private int precision;                              // �ֶξ���
        private int scale;                                  // �ֶ�С˵λ
        private bool allowNull;                             // ���������ֵ
        private bool autoIncrement;                         // �Ƿ�������
        private string defaultValue;                        // Ĭ��ֵ
        private string comment;                             // ��ע
        private string languageType;                        // �ֶζ�Ӧ C# ����
        private string sqlClientType;                       // �ֶζ�Ӧ��SqlClient����
        private string emptyValue;                          // �ֶζ�Ӧ C# ���͵�Ĭ��ֵ
        private string convertValue;                        // �ֶε�ת������
        private string dbType;                              // ���ݿ��ֶ�����
        private string programeDbType;                      // �ֶζ�Ӧ C# �� System.Data.DbType
        private string shortProgrameDbType;                 // �ֶζ�Ӧ C# �� System.Data.DbType

        #endregion ˽�г�Ա����

        #region ���캯��

        /// <summary>
        /// Ĭ�Ϲ��캯��
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
        /// ���캯��
        /// </summary>
        /// <param name="name">����</param>
        /// <param name="isPrimaryKey">�Ƿ�Ϊ����</param>
        /// <param name="size">����</param>
        /// <param name="presicion">����</param>
        /// <param name="scale">С��λ</param>
        public Column(string name, bool isPrimaryKey, int size, int presicion, int scale)
            : this()
        {
            this.name = name;
            this.isPrimaryKey = isPrimaryKey;
            this.size = size;
            this.precision = precision;
            this.scale = scale;
        }

        #endregion ���캯��

        #region IColumn ��Ա

        /// <summary>
        /// ��ȡ�����ñ�����
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
        /// ��ȡ�����ñ����
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
        /// ��ȡ�������Ƿ�Ϊ����
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
        /// ��ȡ�������ֶγ���
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
        /// ��ȡ�����þ���
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
        /// ��ȡ������С��λ
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
        /// ��ȡ�������Ƿ������ֵ
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
        /// ��ȡ������������
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
        /// ��ȡ������Ĭ��ֵ
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
        ///  ��ȡ�����ñ�ע
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
        /// ��ȡ�������ֶζ�Ӧ C# ����
        /// </summary>
        public string LanguageType
        {
            get { return languageType; }
            set { languageType = value; }
        }

        /// <summary>
        /// ��ȡӳ�����������
        /// e.g. C#: SqlClent.Int
        /// </summary>
        public string SqlClientType
        {
            get { return sqlClientType; }
            set { sqlClientType = value; }
        }

        /// <summary>
        /// ��ȡӳ������͵�Ĭ��ֵ
        /// </summary>
        public string EmptyValue
        {
            get { return emptyValue; }
            set { emptyValue = value; }
        }

        /// <summary>
        /// ��ȡӳ������͵ĵ�ת������
        /// e.g. Convert.ToString, Convert.ToInt32
        /// </summary>
        public string ConvertMethod
        {
            get { return convertValue; }
            set { convertValue = value; }
        }

        /// <summary>
        /// ��ȡ���������ݿ��ֶ����͡����磺int�� varchar
        /// </summary>
        public string DbType
        {
            get { return dbType; }
            set { dbType = value; }
        }

        /// <summary>
        /// ��ȡ�����ó����е� DBType ���� System.Data.DbType
        /// </summary>
        public string ProgrameDbType
        {
            get { return programeDbType; }
            set { programeDbType = value; }
        }

        /// <summary>
        /// ��ȡ�����ó����е� DBType ���� System.Data.DbType, "DBType."���沿��
        /// </summary>
        public string ShortProgrameDbType
        {
            get { return shortProgrameDbType; }
            set { shortProgrameDbType = value; }
        }

        /// <summary>
        /// ��ȡ������ PascalCase ��ʽ
        /// </summary>
        public string PascalCaseName
        {
            get { return Util.SetPascalCase(name); }
        }

        /// <summary>
        /// ��ȡ������ CamelCase ��ʽ
        /// </summary>
        public string CamelCaseName
        {
            get { return Util.SetCamelCase(name); }
        }

        #endregion IColumn ��Ա
    }
}