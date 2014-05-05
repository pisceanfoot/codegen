using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITables 描述表信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface ITables : IList, IEnumerable
    {
        /// <summary>
        /// 获取指定的表
        /// </summary>
        /// <param name="index">表名称或者表索引</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>索引</description></item>
        ///		<item><term>string index</term><description>表名</description></item>
        ///	</list>
        /// </remarks>
        ITable this[object index] { get; }

        /// <summary>
        /// 表集合数量
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// 获取表 Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}