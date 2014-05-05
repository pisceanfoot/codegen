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
    public interface IServers : IList, IEnumerable
    {
        /// <summary>
        /// 获取指定的服务器
        /// </summary>
        /// <param name="index">服务器名称或者服务器索引</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>索引</description></item>
        ///		<item><term>string index</term><description>服务器名称</description></item>
        ///	</list>
        /// </remarks>
        IServer this[object index] { get; }

        /// <summary>
        /// 服务器集合数量
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// 获取服务器 Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}