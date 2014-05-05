using System;
using System.Xml.Serialization;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Table : ITable
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
        public Table()
        {
            this.name = string.Empty;
            this.comment = string.Empty;
            this.code = string.Empty;
            columns = null;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">表名称</param>
        /// <param name="comment">备注</param>
        public Table(string name, string comment)
        {
            this.name = name;
            this.comment = comment;
            this.code = string.Empty;
            columns = null;
        }

        #endregion 构造函数

        #region ITable 成员

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
        /// 获取表名的 PascalCase 格式
        /// </summary>
        [XmlIgnore]
        public string PascalCaseName
        {
            get
            {
                string tmpname = name.Replace("t_s_", "");
                tmpname = tmpname.Replace("t_d_", "");
                tmpname = tmpname.Replace("t_r_", "");
                tmpname = tmpname.Replace("t_l_", "");
                tmpname = tmpname.Replace("Vip_", "");
                tmpname = tmpname.Replace("vip_", "");
                return Util.SetPascalCase(tmpname);
            }
        }

        /// <summary>
        /// 获取表名的 CamelCase 格式
        /// </summary>
        [XmlIgnore]
        public string CamelCaseName
        {
            get
            {
                string tmpname = name.Replace("t_s_", "");
                tmpname = tmpname.Replace("t_d_", "");
                tmpname = tmpname.Replace("t_l_", "");
                tmpname = tmpname.Replace("t_r_", "");
                tmpname = tmpname.Replace("Vip_", "");
                tmpname = tmpname.Replace("vip_", "");
                return Util.SetCamelCase(tmpname);
            }
        }

        /// <summary>
        /// 获取容器类型
        /// </summary>
        [XmlIgnore]
        public string Type
        {
            get { return "table"; }
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

        #endregion ITable 成员

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
        /// 获取生成后的代码
        /// </summary>
        public new string ToString()
        {
            return code;
        }

        /// <summary>
        /// 保存生成后的代码
        /// </summary>
        /// <param name="code"></param>
        public void SetCode(string code)
        {
            string tmp = code.Replace("\t", "    ");
            this.code = Util.ApplyCommand(tmp);
        }

        #endregion 公有方法
    }
}