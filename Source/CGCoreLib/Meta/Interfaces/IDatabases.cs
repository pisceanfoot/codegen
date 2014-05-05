using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITables 描述数据库集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IDatabases : IList, IEnumerable
    {
        /// <summary>
        /// 获取指定的数据库
        /// </summary>
        /// <param name="index">数据库名称或者数据库索引</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>索引</description></item>
        ///		<item><term>string index</term><description>数据库名</description></item>
        ///	</list>
        /// </remarks>
        IDatabase this[object index] { get; }

        /// <summary>
        /// 数据库集合数量
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// 获取数据库 Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}