using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CGCoreLib.Util
{
    /// <summary>
    /// 描述：  实现类的序列化及反序列化
    /// </summary>
    /// <remarks>
    /// 类名：  Localization
    /// 作者：  Heclei
    /// 版本：  1.0.0.0
    /// 日期：  2007-05-18
    /// </remarks>
    public static class XmlSerialization
    {
        #region 公有方法

        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="filename">文件信息名称</param>
        /// <param name="obj">待序列化对象</param>
        public static void SerializeObject(string fileName, object obj)
        {
            Stream writer = null;
            try
            {
                Type type = obj.GetType();
                XmlSerializer serializer = new XmlSerializer(type);

                writer = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(writer, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <param name="fileNmae">文件信息名称</param>
        /// <param name="type">反序列化对象类型</param>
        /// <returns>返回实例化后对象</returns>
        public static object DeSerializeObject(string fileName, Type type)
        {
            if (!File.Exists(fileName))
                return null;

            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                XmlSerializer xSer = new XmlSerializer(type);
                XmlReader reader = new XmlTextReader(fs);
                return xSer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        #endregion 公有方法
    }
}