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
    public interface IDatabases : IList, IEnumerable
    {
        /// <summary>
        /// ��ȡָ�������ݿ�
        /// </summary>
        /// <param name="index">���ݿ����ƻ������ݿ�����</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>����</description></item>
        ///		<item><term>string index</term><description>���ݿ���</description></item>
        ///	</list>
        /// </remarks>
        IDatabase this[object index] { get; }

        /// <summary>
        /// ���ݿ⼯������
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// ��ȡ���ݿ� Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}