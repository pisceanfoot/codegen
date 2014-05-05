namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IDatabase �������ݿ���Ϣ
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IDatabase
    {
        /// <summary>
        /// ��ȡ��������Ϣ
        /// </summary>
        IServer Server { get; }

        /// <summary>
        /// ��ȡ���������ݿ�����
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ��ȡ���������ݿ����
        /// </summary>
        string Alias { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ע
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// ��ȡ���������ݿ���������
        /// </summary>
        DatabaseType DbServerType { get; set; }

        /// <summary>
        /// ��ȡ�����ñ���
        /// </summary>
        ITables Tables { get; set; }

        /// <summary>
        /// ��ȡ�������м���
        /// </summary>
        IViews Views { get; set; }

        /// <summary>
        /// ��ӱ�
        /// </summary>
        /// <param name="talbe">����Ϣ</param>
        void AddTable(ITable table);

        /// <summary>
        /// �����ͼ
        /// </summary>
        /// <param name="view">��ͼ��Ϣ</param>
        void AddView(IView view);
    }
}