using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Columns ����Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Columns : Collection, IColumns, IEnumerable, ICollection
    {
        #region ��������

        /// <summary>
        /// ��ȡ��
        /// </summary>
        /// <param name="columnName">������</param>
        /// <returns>��ȡָ�����С����в������򷵻� <strong>null</strong></returns>
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
        /// �������Ϣ
        /// </summary>
        /// <param name="column"></param>
        public void AddColumn(IColumn column)
        {
            this.Add(column);
        }

        #endregion ��������

        #region IColumns ��Ա

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <param name="index">������������</param>
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

        #endregion IColumns ��Ա

        #region IList ��Ա

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

        #endregion IList ��Ա
    }
}