using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IColumns 描述列信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IColumns : IList, IEnumerable
    {
        /// <summary>
        /// 获取指定的列
        /// </summary>
        /// <param name="index">列名称或者列索引</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>索引</description></item>
        ///		<item><term>string index</term><description>列名</description></item>
        ///	</list>
        /// </remarks>
        IColumn this[object index] { get; }

        /// <summary>
        /// 列集合数量
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// 获取列 Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}