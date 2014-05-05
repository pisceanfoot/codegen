using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Tables ����Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Tables : Collection, ITables, IEnumerable, ICollection
    {
        #region ���з���

        /// <summary>
        /// ��ȡ��
        /// </summary>
        /// <param name="tableName">������</param>
        /// <returns>��ȡָ���ı����������򷵻� <strong>null</strong></returns>
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
        /// ��ӱ�
        /// </summary>
        /// <param name="table">����Ϣ</param>
        public void AddTable(ITable table)
        {
            this.Add(table);
        }

        #endregion ���з���

        #region ITables ��Ա

        /// <summary>
        /// ��ȡָ���ı�
        /// </summary>
        /// <param name="index">�����������</param>
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

        #endregion ITables ��Ա

        #region IList ��Ա

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

        #endregion IList ��Ա
    }
}