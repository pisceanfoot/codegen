using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Tables 表信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Tables : Collection, ITables, IEnumerable, ICollection
    {
        #region 公有方法

        /// <summary>
        /// 获取表
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <returns>获取指定的表。若表不存在则返回 <strong>null</strong></returns>
        public ITable GetTable(string tableName)
        {
            string lowCasetableName = tableName.ToLower();

            foreach (ITable table in this.array)
            {
                if (table.Name.ToLower().Equals(lowCasetableName))
                    return table;
            }

            return null;
        }

        /// <summary>
        /// 添加表
        /// </summary>
        /// <param name="table">表信息</param>
        public void AddTable(ITable table)
        {
            this.Add(table);
        }

        #endregion 公有方法

        #region ITables 成员

        /// <summary>
        /// 获取指定的表
        /// </summary>
        /// <param name="index">索引或表名称</param>
        /// <returns></returns>
        public ITable this[object index]
        {
            get
            {
                if (index.GetType() == Type.GetType("System.String"))
                {
                    return GetTable(index as string);
                }
                else
                {
                    int tmpIndex = Convert.ToInt32(index);
                    return (ITable)array[tmpIndex];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        #endregion ITables 成员

        #region IList 成员

        object IList.this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
            }
        }

        #endregion IList 成员
    }
}