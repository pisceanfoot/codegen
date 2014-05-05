using ChinaBest.BaseApplication.CGCoreLib.Meta;

namespace ChinaBest.BaseApplication.CGCoreLib
{
    /// <summary>
    /// ��������
    /// </summary>
    /// <example>
    /// C#
    /// <code>
    ///     IServer server = CreateFactory.CreateServer();
    ///     IDatabase database = CreateFactory.CreateDatabase();
    ///     database.AddTable(CreateFactory.CreateTable());
    ///     database.AddView(CreateFactory.CreateView());
    ///
    ///     ITable table = CreateFactory.CreateTable();
    ///     table.AddColumn(CreateFactory.CreateColumn());
    ///     database.AddTable(table);
    ///
    ///     IView view = CreateFactory.CreateView();
    ///     view.AddColumn(CreateFactory.CreateColumn());
    ///     database.AddView(view);
    ///
    ///     server.AddDatabase(database);
    /// </code>
    /// </example>
    public static class CreateFactory
    {
        public static DatabaseType databaseType = DatabaseType.SqlServer2005;

        /// <summary>
        /// ������
        /// </summary>
        public static IColumn CreateColumn()
        {
            IColumn column = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    column = new Column();
                    break;

                case DatabaseType.Oracle:
                    column = new Column();
                    break;
            }

            return column;
        }

        /// <summary>
        /// �����м���
        /// </summary>
        internal static IColumns CreateColumns()
        {
            IColumns columns = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    columns = new Columns();
                    break;

                case DatabaseType.Oracle:
                    columns = new Columns();
                    break;
            }

            return columns;
        }

        /// <summary>
        /// ������
        /// </summary>
        public static ITable CreateTable()
        {
            ITable table = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    table = new Table();
                    break;

                case DatabaseType.Oracle:
                    table = new Table();
                    break;
            }

            return table;
        }

        /// <summary>
        /// ��������
        /// </summary>
        internal static ITables CreateTables()
        {
            ITables tables = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    tables = new Tables();
                    break;

                case DatabaseType.Oracle:
                    tables = new Tables();
                    break;
            }

            return tables;
        }

        /// <summary>
        /// ������ͼ
        /// </summary>
        public static IView CreateView()
        {
            IView view = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    view = new View();
                    break;

                case DatabaseType.Oracle:
                    view = new View();
                    break;
            }

            return view;
        }

        /// <summary>
        /// ������ͼ����
        /// </summary>
        internal static IViews CreateViews()
        {
            IViews views = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    views = new Views();
                    break;

                case DatabaseType.Oracle:
                    views = new Views();
                    break;
            }

            return views;
        }

        /// <summary>
        /// �������ݿ�
        /// </summary>
        public static IDatabase CreateDatabase()
        {
            IDatabase database = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    database = new Database();
                    break;

                case DatabaseType.Oracle:
                    database = new Database();
                    break;
            }

            return database;
        }

        /// <summary>
        /// �������ݿ⼯��
        /// </summary>
        internal static IDatabases CreateDatabases()
        {
            IDatabases databases = null;

            switch (databaseType)
            {
                case DatabaseType.SqlServer2005:
                case DatabaseType.SqlServer2000:
                    databases = new Databases();
                    break;

                case DatabaseType.Oracle:
                    databases = new Databases();
                    break;
            }

            return databases;
        }

        /// <summary>
        /// ����������
        /// </summary>
        public static IServer CreateServer()
        {
            return new Server();
        }
    }
}