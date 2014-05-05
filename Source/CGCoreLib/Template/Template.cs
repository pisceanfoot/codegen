using System;
using System.Collections.Generic;
using System.IO;
using ChinaBest.BaseApplication.CGCoreLib.Common;
using ChinaBest.BaseApplication.CGCoreLib.Meta;
using NVelocity;
using NVelocity.App;
using NVelocity.Exception;

namespace ChinaBest.BaseApplication.CGCoreLib.Template
{
    /// <summary>
    /// 生成模板
    /// </summary>
    public static class Template
    {
        #region 初始化

        private static VelocityContext context;
        public static string encoding = "utf-8";

        static Template()
        {
            try
            {
                Velocity.Init();
            }
            catch (System.Exception e)
            {
                System.Console.Out.WriteLine("Problem initializing Velocity : " + e);
                return;
            }
            context = new VelocityContext();
        }

        #endregion 初始化

        #region 生成代码

        /// <summary>
        /// 生成源文件
        /// </summary>
        /// <param name="templdate">模板名称</param>
        /// <returns>返回生成代码</returns>
        public static List<CodeInfo> Generator(IDatabase database, string templdate)
        {
            string remove = System.Configuration.ConfigurationManager.AppSettings["Filter"];
            if (remove == null) remove = string.Empty;

            string[] removeItem = remove.Split(',');

            List<CodeInfo> codeList = new List<CodeInfo>();
            string templateName = Path.GetFileName(templdate);
            foreach (ITable table in database.Tables)
            {
                foreach (string item in removeItem)
                    if (table.Name.IndexOf(item) == -1) continue;

                Generator(templdate, table, database.Name);
                CodeInfo info = new CodeInfo();
                info.Template = templateName;
                info.FileName = table.PascalCaseName.ToLower();
                info.Code = table.ToString();

                codeList.Add(info);
            }

            foreach (IView view in database.Views)
            {
                foreach (string item in removeItem)
                    if (view.Name.IndexOf(item) == -1) continue;

                Generator(templdate, view, database.Name);

                CodeInfo info = new CodeInfo();
                info.Template = templateName;
                info.FileName = view.PascalCaseName.ToLower();
                info.Code = view.ToString();

                codeList.Add(info);
            }

            return codeList;
        }

        /// <summary>
        /// 生成源文件
        /// </summary>
        /// <param name="templdate">模板名称</param>
        /// <param name="container">ITable 或 IView</param>
        public static void Generator(string templdate, IContainer container, string databaseName)
        {
            SetMappingType(container);
            PutValue("class", container);
            PutValue("now", DateTime.Now.ToString("yyyy-MM-dd"));
            PutValue("database", Util.SetPascalCase(databaseName));

            NVelocity.Template template = null;

            StringWriter stringWriter = new StringWriter();
            try
            {
                template = Velocity.GetTemplate(templdate, encoding);
                template.Merge(context, stringWriter);
            }
            catch (ParseErrorException pee)
            {
                throw new Exception("模板生成时发生异常", pee);
            }

            container.SetCode(stringWriter.ToString());
        }

        /// <summary>
        /// 添加属性
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public static void PutValue(string key, object value)
        {
            context.Put(key, value);
        }

        /// <summary>
        /// 清空值
        /// </summary>
        public static void Clear()
        {
            context = new VelocityContext();
        }

        #endregion 生成代码

        #region 映射类型

        /// <summary>
        /// 设置默认映射类型
        /// </summary>
        /// <param name="talbe">表</param>
        private static void SetMappingType(IContainer container)
        {
            foreach (IColumn column in container.Columns)
            {
                try
                {
                    column.LanguageType = BaseTypeConvert.GetCSharpValue(column.DbType);
                    column.SqlClientType = BaseTypeConvert.GetSqlClientValue(column.DbType);
                    column.ShortProgrameDbType = BaseTypeConvert.GetCSharpDBTypeForSQL(column.DbType);
                    column.ProgrameDbType = BaseTypeConvert.GetCSharpDBType(column.DbType);
                    column.ConvertMethod = BaseTypeConvert.GetCSharpConvertMethod(column.LanguageType);
                    column.EmptyValue = BaseTypeConvert.GetCSharpEmptyType(column.LanguageType);
                }
                catch (Exception ex)
                {
                    string a = ex.Message;
                }
            }
        }

        ///// <summary>
        ///// 设置默认映射类型
        ///// </summary>
        ///// <param name="talbe">表</param>
        //private static void SetMappingType(IView view)
        //{
        //    foreach (IColumn column in view.Columns)
        //    {
        //        column.LanguageType = BaseTypeConvert.GetCSharpValue(column.DbType);
        //        column.SqlClientType = BaseTypeConvert.GetSqlClientValue(column.DbType);
        //        column.ConvertMethod = BaseTypeConvert.GetCSharpConvertMethod(column.LanguageType);
        //        column.EmptyValue = BaseTypeConvert.GetCSharpEmptyType(column.LanguageType);
        //    }
        //}

        #endregion 映射类型
    }
}