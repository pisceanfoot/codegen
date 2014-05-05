using System;
using System.Collections;
using ChinaBest.BaseApplication.CGCoreLib.Common;

namespace ChinaBest.BaseApplication.CGCoreLib.Template
{
    /// <summary>
    /// 实现SQL DBTYPE 和 C#类型的转换
    /// </summary>
    public static class BaseTypeConvert
    {
        private static Hashtable sqlClientType = new Hashtable();
        private static Hashtable cSharpType = new Hashtable();
        private static Hashtable cSharpDBTypeForSQL = new Hashtable();
        private static Hashtable cSharpDBType = new Hashtable();
        private static Hashtable cSharpEmptyType = new Hashtable();
        private static Hashtable cSharpConvertMethod = new Hashtable();

        /// <summary>
        /// 初始化SqlClient类型
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitSqlClientType(string location, string from, string target)
        {
            sqlClientType = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 初始化对应的C Sharp类型
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitCSharpType(string location, string from, string target)
        {
            cSharpType = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 初始化对应的C Sharp默认值
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitCSharpEmptyType(string location, string from, string target)
        {
            cSharpEmptyType = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 初始化对应的C Sharp默认值
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitCSharpConvertMethod(string location, string from, string target)
        {
            cSharpConvertMethod = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 初始化对应的C Sharp默认值
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitCSharpDBTypeForSQL(string location, string from, string target)
        {
            cSharpDBTypeForSQL = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 初始化对应的C 默认值
        /// </summary>
        /// <param name="location">文件路径</param>
        /// <param name="from">from</param>
        /// <param name="target">to</param>
        public static void InitCSharpDBType(string location, string from, string target)
        {
            cSharpDBType = Util.ReadUserMap(location, from, target);
        }

        /// <summary>
        /// 获取SqlClient类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSqlClientValue(string key)
        {
            return (string)sqlClientType[key];
        }

        /// <summary>
        /// 获取 CSharp DBType 类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetCSharpDBTypeForSQL(string key)
        {
            return (string)cSharpDBTypeForSQL[key];
        }

        /// <summary>
        /// 获取 CSharp DBType 类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetCSharpDBType(string key)
        {
            return (string)cSharpDBType[key];
        }

        /// <summary>
        /// 获取C Sharp类型
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回值</returns>
        public static string GetCSharpValue(string key)
        {
            return (string)cSharpType[key];
        }

        /// <summary>
        /// 获取C Sharp默认值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回值</returns>
        public static string GetCSharpEmptyType(string key)
        {
            return (string)cSharpEmptyType[key];
        }

        /// <summary>
        /// 获取C Sharp默认值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回值</returns>
        public static string GetCSharpConvertMethod(string key)
        {
            return (string)cSharpConvertMethod[key];
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Inite()
        {
            try
            {
                InitCSharpConvertMethod("Settings\\LanguageConvert.xml", "C#", "Convert");
                InitCSharpEmptyType("Settings\\LanguageDefault.xml", "C#", "default");
                InitSqlClientType("Settings\\DbTargets.xml", "SQL", "SqlClient");
                InitCSharpType("Settings\\Languages.xml", "SQL", "C#");
                InitCSharpDBTypeForSQL("Settings\\DbTargets.xml", "SQL", "DbTypeForSQL");
                InitCSharpDBType("Settings\\DbTargets.xml", "SQL", "DbType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}