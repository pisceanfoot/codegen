using System;
using System.Xml.Serialization;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Table : ITable
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
        public Table()
        {
            this.name = string.Empty;
            this.comment = string.Empty;
            this.code = string.Empty;
            columns = null;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">������</param>
        /// <param name="comment">��ע</param>
        public Table(string name, string comment)
        {
            this.name = name;
            this.comment = comment;
            this.code = string.Empty;
            columns = null;
        }

        #endregion ���캯��

        #region ITable ��Ա

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
        /// ��ȡ������ PascalCase ��ʽ
        /// </summary>
        [XmlIgnore]
        public string PascalCaseName
        {
            get
            {
                string tmpname = name.Replace("t_s_", "");
                tmpname = tmpname.Replace("t_d_", "");
                tmpname = tmpname.Replace("t_r_", "");
                tmpname = tmpname.Replace("t_l_", "");
                tmpname = tmpname.Replace("Vip_", "");
                tmpname = tmpname.Replace("vip_", "");
                return Util.SetPascalCase(tmpname);
            }
        }

        /// <summary>
        /// ��ȡ������ CamelCase ��ʽ
        /// </summary>
        [XmlIgnore]
        public string CamelCaseName
        {
            get
            {
                string tmpname = name.Replace("t_s_", "");
                tmpname = tmpname.Replace("t_d_", "");
                tmpname = tmpname.Replace("t_l_", "");
                tmpname = tmpname.Replace("t_r_", "");
                tmpname = tmpname.Replace("Vip_", "");
                tmpname = tmpname.Replace("vip_", "");
                return Util.SetCamelCase(tmpname);
            }
        }

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        [XmlIgnore]
        public string Type
        {
            get { return "table"; }
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

        #endregion ITable ��Ա

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
        /// ��ȡ���ɺ�Ĵ���
        /// </summary>
        public new string ToString()
        {
            return code;
        }

        /// <summary>
        /// �������ɺ�Ĵ���
        /// </summary>
        /// <param name="code"></param>
        public void SetCode(string code)
        {
            string tmp = code.Replace("\t", "    ");
            this.code = Util.ApplyCommand(tmp);
        }

        #endregion ���з���
    }
}