using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IColumns ��������Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IColumns : IList, IEnumerable
    {
        /// <summary>
        /// ��ȡָ������
        /// </summary>
        /// <param name="index">�����ƻ���������</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>����</description></item>
        ///		<item><term>string index</term><description>����</description></item>
        ///	</list>
        /// </remarks>
        IColumn this[object index] { get; }

        /// <summary>
        /// �м�������
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// ��ȡ�� Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}