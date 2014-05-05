namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IView 描述视图信息
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IView : IContainer
    {
        /// <summary>
        /// 获取或设置视图名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        string Comment { get; set; }

        ///// <summary>
        ///// 获取或设置列集合
        ///// </summary>
        //IColumns Columns { get; set;}

        /// <summary>
        /// 添加列信息
        /// </summary>
        /// <param name="column">列信息</param>
        void AddColumn(IColumn colunm);

        /// <summary>
        /// 获取视图名的 PascalCase 格式
        /// </summary>
        string PascalCaseName { get; }

        /// <summary>
        /// 获取视图名的 CamelCase 格式
        /// </summary>
        string CamelCaseName { get; }

        /// <summary>
        /// 获取生成后的代码
        /// </summary>
        string ToString();
    }
}