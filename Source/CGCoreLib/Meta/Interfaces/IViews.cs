using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITables 描述视图信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IViews : IList, IEnumerable
    {
        /// <summary>
        /// 获取指定的表
        /// </summary>
        /// <param name="index">视图名称或者视图索引</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>索引</description></item>
        ///		<item><term>string index</term><description>视图名称</description></item>
        ///	</list>
        /// </remarks>
        IView this[object index] { get; }

        /// <summary>
        /// 视图集合数量
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// 获取视图 Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}