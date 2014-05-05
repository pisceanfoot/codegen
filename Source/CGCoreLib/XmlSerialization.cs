using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CGCoreLib.Util
{
    /// <summary>
    /// ������  ʵ��������л��������л�
    /// </summary>
    /// <remarks>
    /// ������  Localization
    /// ���ߣ�  Heclei
    /// �汾��  1.0.0.0
    /// ���ڣ�  2007-05-18
    /// </remarks>
    public static class XmlSerialization
    {
        #region ���з���

        /// <summary>
        /// ���л�����
        /// </summary>
        /// <param name="filename">�ļ���Ϣ����</param>
        /// <param name="obj">�����л�����</param>
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
        /// �����л�����
        /// </summary>
        /// <param name="fileNmae">�ļ���Ϣ����</param>
        /// <param name="type">�����л���������</param>
        /// <returns>����ʵ���������</returns>
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

        #endregion ���з���
    }
}