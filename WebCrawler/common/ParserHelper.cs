using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCrawler
{
    public class ParserHelper
    {
        public static string GetConfuseTitle(string inputTitle)
        {
            string confuseText = getRandomLine();
            if (confuseText.Length > 15)
                confuseText = confuseText.Substring(0, 15);
            confuseText = "[[" + confuseText + "]]";
            inputTitle = inputTitle.Insert(3,confuseText);           
            return inputTitle;
        }
        public static string GetConfuseHtmlContent(string content)
        {
            if (content.Length < 300)
                return content;
            string confuseText1 = getRandomLine();
            string confuseText2 = getRandomLine();
            string confuseText3 = getRandomLine();
            string confuseText4 = getRandomLine();
            confuseText1 = "[[" + confuseText1 + "]]";
            confuseText2 = "[[" + confuseText2 + "]]";
            confuseText3 = "[[" + confuseText3 + "]]";
            confuseText4 = "[[" + confuseText4 + "]]";
            content = content.Insert(20,confuseText1);
            content = content.Insert(content.Length-10,confuseText2);
            content = content.Insert(content.Length - 200, confuseText3);
            content = content.Insert(content.Length - 100, confuseText4);           
            return content;
        }
        public static string GetConfuseTextContent(string content)
        {
             if (content.Length < 100)
                return content;
            string confuseText1 = getRandomLine();
            string confuseText2 = getRandomLine();
            string confuseText3 = getRandomLine();            
            confuseText1 = "[[" + confuseText1 + "]]";
            confuseText2 = "[[" + confuseText2 + "]]";
            confuseText3 = "[[" + confuseText3 + "]]";          
            content = confuseText1 + content+confuseText2;
            content = content.Insert(120, confuseText3);
            return content;
        }

       static List<string> list = new List<string>();
        public static List<string> ConfuseLines
        {
            get {
                if (list.Count == 0)
                {

                    FileStream fs = new FileStream("confuse.txt",FileMode.Open);                   
                    StreamReader sr = new StreamReader(fs,System.Text.Encoding.Default);
                    while (sr.ReadLine() != null)
                    {
                        string temp = sr.ReadLine();
                        if (string.IsNullOrEmpty(temp))
                            continue;
                        Regex reg = new Regex(@"\p{P}");
                        temp = reg.Replace(temp, "");
                        if (!string.IsNullOrEmpty(temp))
                        {
                            list.Add(temp.Trim());
                        }
                    }
                    return list;
                }
                else
                {
                    return list;
                }
                             
            }
        }
        private static string getRandomLine()
        {
            int max=ConfuseLines.Count;
            if (max > 0)
            {
                Random rand = new Random();
                int i = rand.Next(0, max - 1);
                return ConfuseLines[i];
            }
            else
            {
                return "";
            }
            
        }
            



    }
}
