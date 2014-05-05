namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    public interface IContainer
    {
        /// <summary>
        /// 获取容器的内容
        /// </summary>
        string Type { get; }

        /// <summary>
        /// 获取容器内的列
        /// </summary>
        IColumns Columns { get; set; }

        /// <summary>
        /// 获取主键
        /// </summary>
        IColumn PK { get; }

        /// <summary>
        /// 保存代码
        /// </summary>
        /// <param name="code">生成后的代码</param>
        void SetCode(string code);
    }
}