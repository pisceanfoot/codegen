namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IServer 描述服务器信息
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IServer
    {
        /// <summary>
        /// 获取或设置服务器名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 获取或设置服务器地址
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// 获取或设置密码
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// 获取或设者验证方式
        /// </summary>
        int AuthorityType { get; set; }

        /// <summary>
        /// 获取或设置表集合
        /// </summary>
        IDatabases Databases { get; set; }

        /// <summary>
        /// 添加数据库
        /// </summary>
        /// <param name="databsae">数据库信息</param>
        void AddDatabase(IDatabase databsae);
    }
}