namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IView ������ͼ��Ϣ
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IView : IContainer
    {
        /// <summary>
        /// ��ȡ��������ͼ����
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ע
        /// </summary>
        string Comment { get; set; }

        ///// <summary>
        ///// ��ȡ�������м���
        ///// </summary>
        //IColumns Columns { get; set;}

        /// <summary>
        /// �������Ϣ
        /// </summary>
        /// <param name="column">����Ϣ</param>
        void AddColumn(IColumn colunm);

        /// <summary>
        /// ��ȡ��ͼ���� PascalCase ��ʽ
        /// </summary>
        string PascalCaseName { get; }

        /// <summary>
        /// ��ȡ��ͼ���� CamelCase ��ʽ
        /// </summary>
        string CamelCaseName { get; }

        /// <summary>
        /// ��ȡ���ɺ�Ĵ���
        /// </summary>
        string ToString();
    }
}