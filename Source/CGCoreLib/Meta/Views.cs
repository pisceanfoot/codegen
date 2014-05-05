using System;
using System.Collections;

namespace ChinaBest.BaseApplication.CGCoreLib.Meta
{
    /// <summary>
    /// Views 表信息集合
    /// </summary>
    /// <remarks>
    /// 作者：heclei
    /// 时间：2008-04-11
    /// 版本：v 1.0.0.0
    /// </remarks>
    [Serializable]
    internal class Views : Collection, IViews, IEnumerable, ICollection
    {
        #region 公有方法

        /// <summary>
        /// 获取视图
        /// </summary>
        /// <param name="viewName">视图名称</param>
        /// <returns>获取指定的视图。若视图不存在则返回 <strong>null</strong></returns>
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
        /// 添加表
        /// </summary>
        /// <param name="view">表信息</param>
        public void AddTable(IView view)
        {
            this.Add(view);
        }

        #endregion 公有方法

        #region IViews 成员

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

        #endregion IViews 成员

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