namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    public interface IContainer
    {
        /// <summary>
        /// ��ȡ����������
        /// </summary>
        string Type { get; }

        /// <summary>
        /// ��ȡ�����ڵ���
        /// </summary>
        IColumns Columns { get; set; }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        IColumn PK { get; }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="code">���ɺ�Ĵ���</param>
        void SetCode(string code);
    }
}