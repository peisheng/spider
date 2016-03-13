﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace WebCrawler
{
    /// <summary>
    /// XML序列化帮助类
    /// </summary>
    public static class XmlSerializeHelper
    {

        private static void XmlSerializeInternal(Stream stream, object o, Encoding encoding)
        {

            if (o == null)
                throw new ArgumentNullException("o");

            if (encoding == null)

                throw new ArgumentNullException("encoding");

            XmlSerializer serializer = new XmlSerializer(o.GetType());

            XmlWriterSettings settings = new XmlWriterSettings();

            settings.Indent = true;

            settings.NewLineChars = "\r\n";

            settings.Encoding = encoding;

            settings.IndentChars = " ";

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {

                serializer.Serialize(writer, o);

                writer.Close();

            }
        }

        /// <summary>
        /// 将一个对象序列化为XML字符串
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>序列化产生的XML字符串</returns>
        public static string XmlSerialize(object o, Encoding encoding)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializeInternal(stream, o, encoding);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }


        /// <summary>
        /// 将一个对象按XML序列化的方式写入到一个文件
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="path">保存文件路径</param>
        /// <param name="encoding">编码方式</param>
        public static void XmlSerializeToFile(object o, string path, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))

                throw new ArgumentNullException("path");

            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializeInternal(file, o, encoding);
            }
        }
    }

    /// <summary>
    /// 泛型XML序列化帮助类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class XmlSerializeHelper<T>
    {
        /// <summary>
        /// XML字符串中反序列化对象
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static T XmlDeserialize(string s, Encoding encoding)
        {

            if (string.IsNullOrEmpty(s))

                throw new ArgumentNullException("s");

            if (encoding == null)

                throw new ArgumentNullException("encoding");

            XmlSerializer mySerializer = new XmlSerializer(typeof(T));

            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(s)))
            {

                using (StreamReader sr = new StreamReader(ms, encoding))
                {

                    return (T)mySerializer.Deserialize(sr);

                }

            }

        }


        /// <summary>
        /// 读入一个文件，并按XML的方式反序列化对象。
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>反序列化得到的对象</returns>
        public static T XmlDeserializeFromFile(string path, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))

                throw new ArgumentNullException("path");

            if (encoding == null)

                throw new ArgumentNullException("encoding");

            string xml = File.ReadAllText(path, encoding);

            return XmlDeserialize(xml, encoding);

        }
    }

}
