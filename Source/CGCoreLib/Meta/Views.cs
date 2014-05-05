using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Views ����Ϣ����
    /// </summary>
    /// <remarks>
    /// ���ߣ�heclei
    /// ʱ�䣺2008-04-11
    /// �汾��v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Views : Collection, IViews, IEnumerable, ICollection
    {
        #region ���з���

        /// <summary>
        /// ��ȡ��ͼ
        /// </summary>
        /// <param name="viewName">��ͼ����</param>
        /// <returns>��ȡָ������ͼ������ͼ�������򷵻� <strong>null</strong></returns>
        public IView GetView(string viewName)
        {
            string lowCaseViewName = viewName.ToLower();

            foreach (IView view in this.array)
            {
                if (view.Name.ToLower().Equals(lowCaseViewName))
                    return view;
            }

            return null;
        }

        /// <summary>
        /// ��ӱ�
        /// </summary>
        /// <param name="view">����Ϣ</param>
        public void AddTable(IView view)
        {
            this.Add(view);
        }

        #endregion ���з���

        #region IViews ��Ա

        public IView this[object index]
        {
            get
            {
                if (index.GetType() == Type.GetType("System.String"))
                {
                    return GetView(index as string);
                }
                else
                {
                    int tmpIndex = Convert.ToInt32(index);
                    return (IView)array[tmpIndex];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        #endregion IViews ��Ա

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