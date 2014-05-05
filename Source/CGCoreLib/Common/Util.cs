using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ChinaBest.BaseApplication.CGCoreLib.Common
{
    /// <summary>
    /// 实用类
    /// </summary>
    public static class Util
    {
        private static Regex regex;
        private const string COM_REMOVE = "^r^";
        private const string COM_ADD = "\\^n(?<num>\\d*?)\\^";

        static Util()
        {
            regex = new Regex(COM_ADD, RegexOptions.Compiled);
        }

        public static Hashtable ReadUserMap(string mapFileName, string mapGroupTypeFrom, string mapGroupTypeTo)
        {
            Hashtable h = new Hashtable();
            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader(mapFileName);
                reader.WhitespaceHandling = WhitespaceHandling.None;

                while (reader.Read())
                {
                    if (reader.GetAttribute("From") == mapGroupTypeFrom && reader.GetAttribute("To") == mapGroupTypeTo)
                    {
                        break;
                    }
                }
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        break;
                    }
                    else
                    {
                        h.Add(reader.GetAttribute("From"), reader.GetAttribute("To"));
                    }
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return h;
        }

        #region Naming Functions

        /// <summary>
        /// Trim spaces from a string.
        /// </summary>
        public static string TrimSpaces(string name)
        {
            return name.Replace(" ", "");
        }

        /// <summary>
        /// Trim spaces from a string.
        /// Pass in a char[] containing a list of additional characters
        /// to remove. Spaces are always trimmed.
        /// </summary>
        /// <example>
        /// <code>
        /// char[] c = new char[5] {'\\', '@', ',', '-', ':'};
        ///	string str = DnpUtils.TrimSpaces(Table.Alias, c);
        /// </code>
        /// </example>
        /// <param name="name">The string that needs to be adjusted.</param>
        /// <param name="trimList">char[] of characters to be trimmed.</param>
        /// <returns>A string with all listed characters trimmed. </returns>
        public static string TrimSpaces(string name, char[] trimList)
        {
            for (int i = 0; i < trimList.GetLength(0); i++)
            {
                name = name.Replace(trimList[i], ' ');
            }

            return TrimSpaces(name);
        }

        /// <summary>
        /// SetPascalCase sets the first character to upper case,
        /// trims spaces, underscores, and periods, and sets next to upper.
        /// (PascalCase is sometimes referred to as UpperCamelCase.)
        /// </summary>
        /// <example>
        /// <code>
        /// string tableName = DnpUtils.SetPascalCase("MY_TABLE_NAME");
        /// </code>
        /// The result is "MyTableName"
        /// </example>
        public static string SetPascalCase(string name)
        {
            string buff = "";
            bool next2upper = true;
            bool allUpper = true;

            // checks for names in all CAPS
            foreach (char c in name)
            {
                if (Char.IsLower(c))
                {
                    allUpper = false;
                    break;
                }
            }

            foreach (char c in name)
            {
                switch (c)
                {
                    // Trim spaces
                    case ' ':
                        next2upper = true;
                        break;
                    // Trim underscores
                    case '_':
                        next2upper = true;
                        break;
                    // Trim periods
                    case '.':
                        next2upper = true;
                        break;

                    default:
                        if (next2upper)
                        {
                            buff += c.ToString().ToUpper();
                            next2upper = false;
                        }
                        else if (allUpper)
                        {
                            buff += c.ToString().ToLower();
                        }
                        else
                        {
                            buff += c.ToString();
                        }
                        break;
                }
            }

            return buff;
        }

        /// <summary>
        /// SetPascalCase sets the first character to upper case,
        /// trims spaces, underscores, and periods, and sets next to upper.
        /// (PascalCase is sometimes referred to as UpperCamelCase.)
        /// Pass in a char[] containing a list of additional characters
        /// to remove. Spaces, underscores, and periods are always trimmed.
        /// </summary>
        /// <example>
        /// <code>
        /// char[] c = new char[5] {'\\', '@', ',', '-', ':'};
        ///	string str = DnpUtils.SetPascalCase(Table.Alias, c);
        /// </code>
        /// </example>
        /// <param name="name">The string that needs to be adjusted.</param>
        /// <param name="trimList">char[] of characters to be trimmed.</param>
        /// <returns>A string with all listed characters trimmed. </returns>
        public static string SetPascalCase(string name, char[] trimList)
        {
            for (int i = 0; i < trimList.GetLength(0); i++)
            {
                name = name.Replace(trimList[i], ' ');
            }

            return SetPascalCase(name);
        }

        /// <summary>
        /// SetCamelCase sets the first character to lower case,
        /// trims spaces, underscores, and periods, and sets next to upper.
        /// (CamelCase in this context refers to the lowerCamelCase convention.)
        /// </summary>
        /// <example>
        /// <code>
        /// string tableName = DnpUtils.SetCamelCase("MY_TABLE_NAME");
        /// </code>
        /// The result is "myTableName"
        /// </example>
        public static string SetCamelCase(string name)
        {
            string buff = "";
            bool next2upper = false;
            bool firstLetter = true;
            bool allUpper = true;

            // checks for names in all CAPS
            foreach (char c in name)
            {
                if (Char.IsLower(c))
                {
                    allUpper = false;
                    break;
                }
            }

            foreach (char c in name)
            {
                switch (c)
                {
                    // Trim spaces
                    case ' ':
                        if (!firstLetter)
                        {
                            next2upper = true;
                        }
                        break;
                    // Trim underscores
                    case '_':
                        if (!firstLetter)
                        {
                            next2upper = true;
                        }
                        break;
                    // Trim periods
                    case '.':
                        if (!firstLetter)
                        {
                            next2upper = true;
                        }
                        break;

                    default:
                        if (next2upper)
                        {
                            buff += c.ToString().ToUpper();
                            next2upper = false;
                        }
                        else
                        {
                            if (firstLetter)
                            {
                                buff += c.ToString().ToLower();
                                firstLetter = false;
                            }
                            else if (allUpper)
                            {
                                buff += c.ToString().ToLower();
                            }
                            else
                            {
                                buff += c.ToString();
                            }
                        }

                        break;
                }
            }

            return buff;
        }

        /// <summary>
        /// SetCamelCase sets the first character to lower case,
        /// trims spaces, underscores, and periods, and sets next to upper.
        /// (CamelCase in this context refers to the lowerCamelCase convention.)
        /// Pass in a char[] containing a list of additional characters
        /// to remove. Spaces, underscores, and periods are always trimmed.
        /// </summary>
        /// <example>
        /// <code>
        /// char[] c = new char[5] {'\\', '@', ',', '-', ':'};
        ///	string str = DnpUtils.SetCamelCase(Table.Alias, c);
        /// </code>
        /// </example>
        /// <param name="name">The string that needs to be adjusted.</param>
        /// <param name="trimList">char[] of characters to be trimmed.</param>
        /// <returns>A string with all listed characters trimmed. </returns>
        public static string SetCamelCase(string name, char[] trimList)
        {
            for (int i = 0; i < trimList.GetLength(0); i++)
            {
                name = name.Replace(trimList[i], ' ');
            }

            return SetCamelCase(name);
        }

        /// <summary>
        /// Used to construct an output file name.
        /// </summary>
        /// <example>
        /// <code>
        /// string outputPath = "C:\\Output";
        /// string fileName = "Order Details";
        /// bool prefix = true;
        /// bool trim = true;
        /// string fullFileName =
        ///     DnpUtils.GetOutputFile(outputPath, fileName, ".cs", prefix, trim);
        /// </code>
        /// The result is "C:\Output\_OrderDetails.cs"
        /// </example>
        /// <param name="path">The path (with or without the trailing '\')</param>
        /// <param name="fileName">The name of the file (without the extension)</param>
        /// <param name="suffix">the file extension (with the dot), e.g. '.cs'</param>
        /// <param name="prefix">Set to true if you want a preceding underscore</param>
        /// <param name="trimName">Set to true to TrimSpaces() from the fileName</param>
        /// <returns>A string containing the concatenated path, prefix, filename, and suffix</returns>
        public static string GetOutputFile(string path, string fileName, string suffix, bool prefix, bool trimName)
        {
            string buff = path;

            if (!buff.EndsWith("\\"))
            {
                buff += "\\";
            }

            if (prefix)
            {
                if (trimName)
                {
                    buff += "_" + TrimSpaces(fileName);
                }
                else
                {
                    buff += "_" + fileName;
                }
            }
            else
            {
                if (trimName)
                {
                    buff += TrimSpaces(fileName);
                }
                else
                {
                    buff += fileName;
                }
            }

            buff += suffix;

            return buff;
        }

        #endregion Naming Functions

        /// <summary>
        /// 执行自定义命令
        /// </summary>
        /// <param name="code">代码</param>
        public static string ApplyCommand(string code)
        {
            int index = code.IndexOf("^c^");
            while (index > -1)
            {
                // 删除标记命令
                code = code.Remove(index, 3);

                int tmp = code.LastIndexOf(",", index);
                code = code.Remove(tmp, 1);

                index = code.IndexOf("^c^");
            }

            //int start = -1;
            //int end = -1;

            //int index = code.IndexOf(COM_REMOVE);
            //while (index > -1)
            //{
            //    code = code.Remove(index, 3);

            //    end = index - 1;
            //    index--;
            //    while (index > -1)
            //    {
            //        if (code[index] != 32 && code[index] != '\r' && code[index] != '\n')
            //        {
            //            start = index + 1;
            //            break;
            //        }
            //        index--;
            //    }

            //    code = code.Remove(start, end - start);
            //    start = -1;
            //    end = -1;

            //    index = code.IndexOf(COM_REMOVE);
            //}

            //MatchCollection mcollection = regex.Matches(code);

            //foreach (Match match in mcollection)
            //{
            //    code = code.Replace(match.Value, "\r\n" + match.Value);
            //    code = code.Replace(match.Value, TabString(Convert.ToInt32(match.Groups["num"].Value)));
            //}

            return code;
        }

        public static string TabString(int num)
        {
            StringBuilder builder = new StringBuilder(num);
            while (num-- > 0)
            {
                builder.Append("\t");
            }

            return builder.ToString();
        }
    }
}