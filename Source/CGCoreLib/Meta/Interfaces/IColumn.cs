namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IColumn ��������Ϣ
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    public interface IColumn
    {
        /// <summary>
        /// ��ȡ������������
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ��ȡ�����ñ���
        /// </summary>
        string Alias { get; set; }

        /// <summary>
        /// ��ȡ�������Ƿ�Ϊ����
        /// </summary>
        bool IsPrimaryKey { get; set; }

        /// <summary>
        /// ��ȡ�����ó���
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// ��ȡ�����þ���
        /// </summary>
        int Precision { get; set; }

        /// <summary>
        /// ��ȡ������С��λ
        /// </summary>
        int Scale { get; set; }

        /// <summary>
        /// ��ȡ�������Ƿ�����
        /// </summary>
        bool AllowNull { get; set; }

        /// <summary>
        /// ��ȡ�������Ƿ�Ϊ������
        /// </summary>
        bool AutoIncrement { get; set; }

        /// <summary>
        /// ��ȡ������Ĭ��ֵ
        /// </summary>
        string Default { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ע
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// ��ȡӳ�����������
        /// e.g. C#: System.String; System.Int32
        /// </summary>
        string LanguageType { get; set; }

        /// <summary>
        /// ��ȡӳ�����������
        /// e.g. C#: SqlClent.Int
        /// </summary>
        string SqlClientType { get; set; }

        /// <summary>
        /// ��ȡӳ������͵�Ĭ��ֵ
        /// e.g. String.Empty, int.MinValue
        /// </summary>
        string EmptyValue { get; set; }

        /// <summary>
        /// ��ȡӳ������͵ĵ�ת������
        /// e.g. Convert.ToString, Convert.ToInt32
        /// </summary>
        string ConvertMethod { get; set; }

        /// <summary>
        /// ��ȡ�����ö�Ӧ���ݿ�������
        /// e.g. int varhcar
        /// </summary>
        string DbType { get; set; }

        /// <summary>
        /// ��ȡ�����ó����е� DBType ���� System.Data.DbType, "System.Data.DbType." ���沿��
        /// </summary>
        string ShortProgrameDbType { get; set; }

        /// <summary>
        /// ��ȡ�����ó����е� DBType ���� System.Data.DbType
        /// </summary>
        string ProgrameDbType { get; set; }

        /// <summary>
        /// ��ȡ������ PascalCase ��ʽ
        /// </summary>
        string PascalCaseName { get; }

        /// <summary>
        /// ��ȡ������ CamelCase ��ʽ
        /// </summary>
        string CamelCaseName { get; }
    }
}