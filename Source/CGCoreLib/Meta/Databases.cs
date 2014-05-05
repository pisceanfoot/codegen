using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    [Serializable]
    internal class Databases : Collection, IDatabases, IEnumerable, ICollection
    {
        #region 公有方法

        /// <summary>
        /// 获取数据库
        /// </summary>
        /// <param name="databaseName">数据库名称</param>
        /// <returns>获取指定的数据库。若数据库不存在则返回 <strong>null</strong></returns>
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
        /// 添加数据库
        /// </summary>
        /// <param name="database">数据库信息</param>
        public void AddDatabase(IDatabase database)
        {
            this.Add(database);
        }

        #endregion 公有方法

        #region IDatabases 成员

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

        #endregion IDatabases 成员

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