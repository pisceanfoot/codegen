using System;
using System.Xml.Serialization;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class View : IView
    {
        #region 私有成员变量

        private string name;                    // 表名
        private string comment;                 // 备注
        private IColumns columns;               // 列集合
        private string code;                    // 生成后的代码

        #endregion 私有成员变量

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public View()
        {
            this.name = string.Empty;
            this.comment = string.Empty;
            this.code = string.Empty;
            columns = null;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">视图名称</param>
        /// <param name="comment">备注</param>
        public View(string name, string comment)
        {
            this.name = name;
            this.comment = comment;
            this.code = string.Empty;
            columns = null;
        }

        #endregion 构造函数

        #region IView 成员

        /// <summary>
        /// 获取容器类型
        /// </summary>
        [XmlIgnore]
        public string Type
        {
            get { return "view"; }
        }

        /// <summary>
        /// 获取或设置表名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }

        /// <summary>
        /// 获取或设置列集合
        /// </summary>
        public IColumns Columns
        {
            get
            {
                if (columns == null)
                    columns = CreateFactory.CreateColumns();

                return columns;
            }
            set
            {
                columns = value;
            }
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        [XmlIgnore]
        public IColumn PK
        {
            get
            {
                foreach (IColumn column in columns)
                {
                    if (column.IsPrimaryKey)
                        return column;
                }

                return null;
            }
        }

        /// <summary>
        /// 获取视图名的 PascalCase 格式
        /// </summary>
        [XmlIgnore]
        public string PascalCaseName
        {
            get { return Util.SetPascalCase(name); }
        }

        /// <summary>
        /// 获取视图名的 CamelCase 格式
        /// </summary>
        [XmlIgnore]
        public string CamelCaseName
        {
            get { return Util.SetCamelCase(name); }
        }

        #endregion IView 成员

        #region 公有方法

        /// <summary>
        /// 添加列
        /// </summary>
        /// <param name="column">列信息</param>
        public void AddColumn(IColumn column)
        {
            if (column == null) throw new ArgumentException("column 不能为空");
            Columns.Add(column);
        }

        /// <summary>
        /// 保存生成后的代码
        /// </summary>
        /// <param name="code"></param>
        public void SetCode(string code)
        {
            this.code = code.Replace("\t", "    ");
        }

        /// <summary>
        /// 获取生成后的代码
        /// </summary>
        public new string ToString()
        {
            return code;
        }

        #endregion 公有方法
    }
}