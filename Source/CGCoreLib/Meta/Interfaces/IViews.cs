using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITables ������ͼ��Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IViews : IList, IEnumerable
    {
        /// <summary>
        /// ��ȡָ���ı�
        /// </summary>
        /// <param name="index">��ͼ���ƻ�����ͼ����</param>
        /// <remarks>
        /// <list type="table">
        ///		<item><term>int index</term><description>����</description></item>
        ///		<item><term>string index</term><description>��ͼ����</description></item>
        ///	</list>
        /// </remarks>
        IView this[object index] { get; }

        /// <summary>
        /// ��ͼ��������
        /// </summary>
        new int Count { get; }

        /// <summary>
        /// ��ȡ��ͼ Enumerator
        /// </summary>
        /// <returns></returns>
        new IEnumerator GetEnumerator();
    }
}