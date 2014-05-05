using System;
using System.Collections.Generic;
using System.Text;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    /// <summary>
    /// 模板信息
    /// </summary>
    public class TemplateInfo
    {
        private string name;
        private string location;

        /// <summary>
        /// 获取或设置模板名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 获取或设置模板地址
        /// </summary>
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
