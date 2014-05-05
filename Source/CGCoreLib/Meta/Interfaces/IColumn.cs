namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// IColumn 描述列信息
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    public interface IColumn
    {
        /// <summary>
        /// 获取或设置列名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 获取或设置别名
        /// </summary>
        string Alias { get; set; }

        /// <summary>
        /// 获取或设置是否为主键
        /// </summary>
        bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 获取或设置长度
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// 获取或设置精度
        /// </summary>
        int Precision { get; set; }

        /// <summary>
        /// 获取或设置小数位
        /// </summary>
        int Scale { get; set; }

        /// <summary>
        /// 获取或设置是否允许
        /// </summary>
        bool AllowNull { get; set; }

        /// <summary>
        /// 获取或设置是否为自增长
        /// </summary>
        bool AutoIncrement { get; set; }

        /// <summary>
        /// 获取或设置默认值
        /// </summary>
        string Default { get; set; }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// 获取映射的数据类型
        /// e.g. C#: System.String; System.Int32
        /// </summary>
        string LanguageType { get; set; }

        /// <summary>
        /// 获取映射的数据类型
        /// e.g. C#: SqlClent.Int
        /// </summary>
        string SqlClientType { get; set; }

        /// <summary>
        /// 获取映射的类型的默认值
        /// e.g. String.Empty, int.MinValue
        /// </summary>
        string EmptyValue { get; set; }

        /// <summary>
        /// 获取映射的类型的的转换函数
        /// e.g. Convert.ToString, Convert.ToInt32
        /// </summary>
        string ConvertMethod { get; set; }

        /// <summary>
        /// 获取或设置对应数据库列类型
        /// e.g. int varhcar
        /// </summary>
        string DbType { get; set; }

        /// <summary>
        /// 获取或设置程序中的 DBType 类型 System.Data.DbType, "System.Data.DbType." 后面部分
        /// </summary>
        string ShortProgrameDbType { get; set; }

        /// <summary>
        /// 获取或设置程序中的 DBType 类型 System.Data.DbType
        /// </summary>
        string ProgrameDbType { get; set; }

        /// <summary>
        /// 获取列名的 PascalCase 格式
        /// </summary>
        string PascalCaseName { get; }

        /// <summary>
        /// 获取列名的 CamelCase 格式
        /// </summary>
        string CamelCaseName { get; }
    }
}