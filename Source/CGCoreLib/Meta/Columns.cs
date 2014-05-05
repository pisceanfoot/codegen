using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Columns 表信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Columns : Collection, IColumns, IEnumerable, ICollection
    {
        #region 公有属性

        /// <summary>
        /// 获取列
        /// </summary>
        /// <param name="columnName">列名称</param>
        /// <returns>获取指定的列。若列不存在则返回 <strong>null</strong></returns>
        public IColumn GetColumn(string columnName)
        {
            string lowCaseColumnName = columnName.ToLower();

            foreach (IColumn column in this.array)
            {
                if (column.Name.ToLower().Equals(lowCaseColumnName))
                    return column;
            }

            return null;
        }

        /// <summary>
        /// 添加列信息
        /// </summary>
        /// <param name="column"></param>
        public void AddColumn(IColumn column)
        {
            this.Add(column);
        }

        #endregion 公有属性

        #region IColumns 成员

        /// <summary>
        /// 获取或设置列
        /// </summary>
        /// <param name="index">索引或列名称</param>
        /// <returns></returns>
        public IColumn this[object index]
        {
            get
            {
                if (index.GetType() == Type.GetType("System.String"))
                {
                    return GetColumn(index as string);
                }
                else
                {
                    int idx = Convert.ToInt32(index);
                    return this.array[idx] as IColumn;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.array.GetEnumerator();
        }

        #endregion IColumns 成员

        #region IList 成员

        object IList.this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                ;
            }
        }

        #endregion IList 成员
    }
}