using System;
using System.Collections.Generic;
using System.Text;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    /// <summary>
    /// ģ����Ϣ
    /// </summary>
    public class TemplateInfo
    {
        private string name;
        private string location;

        /// <summary>
        /// ��ȡ������ģ������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// ��ȡ������ģ���ַ
        /// </summary>
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
