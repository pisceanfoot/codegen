using System;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Database : IDatabase
    {
        #region ˽�г�Ա����

        private string name;                            // ���ݿ�����
        private string alias;                           // ���ݿ����
        private string comment;                         // ���ݿ�����
        private DatabaseType databaseType;              // ���ݿ�����
        private ITables tables;                         // ����
        private IViews views;                           // ��ͼ����

        #endregion ˽�г�Ա����

        #region ���캯��

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public Database()
            : this(string.Empty, string.Empty, DatabaseType.SqlServer2005)
        {
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">���ݿ�����</param>
        /// <param name="alias">���ݿ����</param>
        /// <param name="databaseType">���ݿ�����</param>
        public Database(string name, string alias, DatabaseType databaseType)
        {
            this.name = name;
            this.alias = alias;
            this.databaseType = databaseType;
        }

        #endregion ���캯��

        #region IDatabase ��Ա

        /// <summary>
        /// ��ȡ��������Ϣ
        /// </summary>
        public IServer Server
        {
            get { return null; }
        }

        /// <summary>
        /// ��ȡ���������ݿ�����
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// ��ȡ���������ݿ����
        /// </summary>
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        /// <summary>
        /// ��ȡ�����ñ�ע
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// ��ȡ���������ݿ�����
        /// </summary>
        public DatabaseType DbServerType
        {
            get { return databaseType; }
            set { databaseType = value; }
        }

        /// <summary>
        /// ��ȡ�����ñ���
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
        /// ��ȡ��������ͼ����
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

        #endregion IDatabase ��Ա

        #region ���з���

        /// <summary>
        /// ��ӱ�
        /// </summary>
        /// <param name="talbe">����Ϣ</param>
        public void AddTable(ITable table)
        {
            if (table == null) throw new ArgumentException("table ����Ϊ��");
            Tables.Add(table);
        }

        /// <summary>
        /// �����ͼ
        /// </summary>
        /// <param name="view">��ͼ��Ϣ</param>
        public void AddView(IView view)
        {
            if (view == null) throw new ArgumentException("table ����Ϊ��");
            Views.Add(view);
        }

        #endregion ���з���
    }
}