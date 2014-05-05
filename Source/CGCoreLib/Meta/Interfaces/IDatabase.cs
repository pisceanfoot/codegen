namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IDatabase 描述数据库信息
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IDatabase
    {
        /// <summary>
        /// 获取服务器信息
        /// </summary>
        IServer Server { get; }

        /// <summary>
        /// 获取或设置数据库名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 获取或设置数据库别名
        /// </summary>
        string Alias { get; set; }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// 获取或设置数据库链接类型
        /// </summary>
        DatabaseType DbServerType { get; set; }

        /// <summary>
        /// 获取或设置表集合
        /// </summary>
        ITables Tables { get; set; }

        /// <summary>
        /// 获取或设置列集合
        /// </summary>
        IViews Views { get; set; }

        /// <summary>
        /// 添加表
        /// </summary>
        /// <param name="talbe">表信息</param>
        void AddTable(ITable table);

        /// <summary>
        /// 添加视图
        /// </summary>
        /// <param name="view">视图信息</param>
        void AddView(IView view);
    }
}