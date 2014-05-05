namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// ITable ��������Ϣ
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface ITable : IContainer
    {
        /// <summary>
        /// ��ȡ�����ñ�����
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ע
        /// </summary>
        string Comment { get; set; }

        ///// <summary>
        ///// ��ȡ�����ñ���
        ///// </summary>
        //IColumns Columns { get; set;}

        /// <summary>
        /// ��ȡ������ PascalCase ��ʽ
        /// </summary>
        string PascalCaseName { get; }

        /// <summary>
        /// ��ȡ������ CamelCase ��ʽ
        /// </summary>
        string CamelCaseName { get; }

        /// <summary>
        /// �������Ϣ
        /// </summary>
        /// <param name="column">����Ϣ</param>
        void AddColumn(IColumn column);

        /// <summary>
        /// ��ȡ���ɺ�Ĵ���
        /// </summary>
        string ToString();
    }
}