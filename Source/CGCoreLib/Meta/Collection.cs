using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Collection ������Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Collection
    {
        protected ArrayList array = new ArrayList();

        #region ���캯��

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public Collection()
        {
        }

        #endregion ���캯��

        #region ICollection Members

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        public virtual int Count
        {
            get { return array.Count; }
        }

        /// <summary>
        /// ��ȡ�Ƿ���Ҫͬ��
        /// </summary>
        public bool IsSynchronized
        {
            get { return false; }
        }

        /// <summary>
        /// ���Ƽ���
        /// </summary>
        /// <param name="array">�����Ƽ���</param>
        /// <param name="index">��ʵ���</param>
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
        /// �����Ϣ
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