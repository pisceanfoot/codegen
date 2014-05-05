using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Databases : Collection, IDatabases, IEnumerable, ICollection
    {
        #region ���з���

        /// <summary>
        /// ��ȡ���ݿ�
        /// </summary>
        /// <param name="databaseName">���ݿ�����</param>
        /// <returns>��ȡָ�������ݿ⡣�����ݿⲻ�����򷵻� <strong>null</strong></returns>
        public IDatabase GetDatabase(string databaseName)
        {
            string lowCasedatabaseName = databaseName.ToLower();

            foreach (IDatabase database in this.array)
            {
                if (database.Name.ToLower().Equals(lowCasedatabaseName))
                    return database;
            }

            return null;
        }

        /// <summary>
        /// ������ݿ�
        /// </summary>
        /// <param name="database">���ݿ���Ϣ</param>
        public void AddDatabase(IDatabase database)
        {
            this.Add(database);
        }

        #endregion ���з���

        #region IDatabases ��Ա

        public IDatabase this[object index]
        {
            get
            {
                if (index.GetType() == Type.GetType("System.String"))
                {
                    return GetDatabase(index as string);
                }
                else
                {
                    int tmpIndex = Convert.ToInt32(index);
                    return (IDatabase)array[tmpIndex];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        #endregion IDatabases ��Ա

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