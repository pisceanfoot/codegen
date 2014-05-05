using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITables �������ݿ⼯��
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IServers : IList, IEnumerable
    {
        /// <summary>
        /// ��ȡָ���ķ�����
        /// </summary>
        /// <param name="index">���������ƻ��߷���������</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>����</description></item>
        ///		<item><term>string index</term><description>����������</description></item>
        ///	</list>
        /// </remarks>
        IServer this[object index] { get; }

        /// <summary>
        /// ��������������
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// ��ȡ������ Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}