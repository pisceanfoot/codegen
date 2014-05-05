using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Collection 描述信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Collection
    {
        protected ArrayList array = new ArrayList();

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Collection()
        {
        }

        #endregion 构造函数

        #region ICollection Members

        /// <summary>
        /// 获取集合数量
        /// </summary>
        public virtual int Count
        {
            get { return array.Count; }
        }

        /// <summary>
        /// 获取是否需要同步
        /// </summary>
        public bool IsSynchronized
        {
            get { return false; }
        }

        /// <summary>
        /// 复制集合
        /// </summary>
        /// <param name="array">待复制集合</param>
        /// <param name="index">其实编号</param>
        public void CopyTo(Array array, int index)
        {
        }

        /// <summary>
        ///
        /// </summary>
        public object SyncRoot
        {
            get { return null; }
        }

        #endregion ICollection Members

        #region IList Members

        public bool IsReadOnly
        {
            get { return true; }
        }

        public void RemoveAt(int index)
        {
        }

        public void Insert(int index, object value)
        {
        }

        public void Remove(object value)
        {
        }

        public bool Contains(object value)
        {
            return false;
        }

        public void Clear()
        {
        }

        public int IndexOf(object value)
        {
            return 0;
        }

        /// <summary>
        /// 添加信息
        /// </summary>
        public int Add(object value)
        {
            return array.Add(value);
        }

        public bool IsFixedSize
        {
            get { return true; }
        }

        #endregion IList Members
    }
}