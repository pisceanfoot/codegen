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
    /// ����ģ��
    /// </summary>
    public static class Template
    {
        #region ��ʼ��

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

        #endregion ��ʼ��

        #region ���ɴ���

        /// <summary>
        /// ����Դ�ļ�
        /// </summary>
        /// <param name="templdate">ģ������</param>
        /// <returns>�������ɴ���</returns>
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
        /// ����Դ�ļ�
        /// </summary>
        /// <param name="templdate">ģ������</param>
        /// <param name="container">ITable �� IView</param>
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
                throw new Exception("ģ������ʱ�����쳣", pee);
            }

            container.SetCode(stringWriter.ToString());
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="key">��</param>
        /// <param name="value">ֵ</param>
        public static void PutValue(string key, object value)
        {
            context.Put(key, value);
        }

        /// <summary>
        /// ���ֵ
        /// </summary>
        public static void Clear()
        {
            context = new VelocityContext();
        }

        #endregion ���ɴ���

        #region ӳ������

        /// <summary>
        /// ����Ĭ��ӳ������
        /// </summary>
        /// <param name="talbe">��</param>
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
        ///// ����Ĭ��ӳ������
        ///// </summary>
        ///// <param name="talbe">��</param>
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

        #endregion ӳ������
    }
}