namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IServer ������������Ϣ
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IServer
    {
        /// <summary>
        /// ��ȡ�����÷���������
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ��ȡ�����÷�������ַ
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// ��ȡ�������û���
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// ��ȡ��������֤��ʽ
        /// </summary>
        int AuthorityType { get; set; }

        /// <summary>
        /// ��ȡ�����ñ���
        /// </summary>
        IDatabases Databases { get; set; }

        /// <summary>
        /// ������ݿ�
        /// </summary>
        /// <param name="databsae">���ݿ���Ϣ</param>
        void AddDatabase(IDatabase databsae);
    }
}