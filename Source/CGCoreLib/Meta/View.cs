using System;
using System.Xml.Serialization;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class View : IView
    {
        #region ˽�г�Ա����

        private string name;                    // ����
        private string comment;                 // ��ע
        private IColumns columns;               // �м���
        private string code;                    // ���ɺ�Ĵ���

        #endregion ˽�г�Ա����

        #region ���캯��

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public View()
        {
            this.name = string.Empty;
            this.comment = string.Empty;
            this.code = string.Empty;
            columns = null;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">��ͼ����</param>
        /// <param name="comment">��ע</param>
        public View(string name, string comment)
        {
            this.name = name;
            this.comment = comment;
            this.code = string.Empty;
            columns = null;
        }

        #endregion ���캯��

        #region IView ��Ա

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        [XmlIgnore]
        public string Type
        {
            get { return "view"; }
        }

        /// <summary>
        /// ��ȡ�����ñ���
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
        /// ��ȡ�����ñ�ע
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
        /// ��ȡ�������м���
        /// </summary>
        public IColumns Columns
        {
            get
            {
                if (columns == null)
                    columns = CreateFactory.CreateColumns();

                return columns;
            }
            set
            {
                columns = value;
            }
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        [XmlIgnore]
        public IColumn PK
        {
            get
            {
                foreach (IColumn column in columns)
                {
                    if (column.IsPrimaryKey)
                        return column;
                }

                return null;
            }
        }

        /// <summary>
        /// ��ȡ��ͼ���� PascalCase ��ʽ
        /// </summary>
        [XmlIgnore]
        public string PascalCaseName
        {
            get { return Util.SetPascalCase(name); }
        }

        /// <summary>
        /// ��ȡ��ͼ���� CamelCase ��ʽ
        /// </summary>
        [XmlIgnore]
        public string CamelCaseName
        {
            get { return Util.SetCamelCase(name); }
        }

        #endregion IView ��Ա

        #region ���з���

        /// <summary>
        /// �����
        /// </summary>
        /// <param name="column">����Ϣ</param>
        public void AddColumn(IColumn column)
        {
            if (column == null) throw new ArgumentException("column ����Ϊ��");
            Columns.Add(column);
        }

        /// <summary>
        /// �������ɺ�Ĵ���
        /// </summary>
        /// <param name="code"></param>
        public void SetCode(string code)
        {
            this.code = code.Replace("\t", "    ");
        }

        /// <summary>
        /// ��ȡ���ɺ�Ĵ���
        /// </summary>
        public new string ToString()
        {
            return code;
        }

        #endregion ���з���
    }
}