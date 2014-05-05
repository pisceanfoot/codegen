using System;
using System.Collections.Generic;
using System.IO;
using CGCoreLib.Util;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    [Serializable]
    public class ProjectInfo
    {
        private string name = string.Empty;
        private DateTime createDate;
        private string solutionName = string.Empty;
        private string solutionPath = string.Empty;
        private string templatePath = string.Empty;
        private string serverAddress = string.Empty;
        private string userName = string.Empty;
        private string password = string.Empty;
        private string database = string.Empty;
        private bool windowsAudhority = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        public string SolutionName
        {
            get { return solutionName; }
            set { solutionName = value; }
        }

        public string SolutionPath
        {
            get { return solutionPath; }
            set { solutionPath = value; }
        }

        public string TemplatePath
        {
            get { return templatePath; }
            set { templatePath = value; }
        }

        public string ServerAddress
        {
            get { return serverAddress; }
            set { serverAddress = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public bool WindowsAudhority
        {
            get { return windowsAudhority; }
            set { windowsAudhority = value; }
        }

        public string[] GetTemplateList()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string tmptemplatePath = Path.Combine(appPath, templatePath);
            List<string> files = new List<string>();
            string[] templates = Directory.GetFiles(tmptemplatePath, "*.vm");
            foreach (string file in templates)
            {
                files.Add(file.Replace(appPath, ""));
            }

            return files.ToArray();
        }

        public static bool Save(ProjectInfo info)
        {
            string file = Path.Combine(info.solutionPath, info.name);

            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }

            file = Path.Combine(file, info.name + ".cgp");
            try
            {
                XmlSerialization.SerializeObject(file, info);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class ConnectionInfo
    {
        public string ServerAddress;
        public string UserName;
        public string Password;
        public bool IsWindowAuth;
    }
}