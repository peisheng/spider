using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressSharp;
using WordPressSharp.Models;
using HtmlAgilityPack;
using HtmlAgilityPack.Extensions;

using System.Text.RegularExpressions;
using System.Threading;
namespace WebCrawler
{
    public class WpHelper
    {
        string _sourceName = string.Empty;
        public string SourceName
        {
            get { return this._sourceName; }
            set
            {
                this._sourceName = value;
            }
        }
        public ParserSetting ParserSetting { get; set; }

        public WpHelper(string sourceName)
        {
            _sourceName = sourceName;
            this.ParserSetting = SettingHelper.GetParserSetting(_sourceName);
        }


        private List<SiteSetting> GetSiteSetting()
        {
            List<SiteSetting> allSites = SettingHelper.GetSiteSettingModel().SiteSettingList;
            List<string> siteBaseUrls = this.ParserSetting.TargetSiteUrl;
            var results = allSites.Where(p => siteBaseUrls.Contains(p.WebSiteBaseUrl)).ToList();
            return results;
        }

        private List<WordPressSiteConfig> ReadyConfigs()
        {
            List<SiteSetting> list = GetSiteSetting();
            List<WordPressSiteConfig> configs = new List<WordPressSiteConfig>();
            for (int i = 0; i < list.Count; i++)
            {
                SiteSetting set = list[i];
                WordPressSiteConfig config = new WordPressSiteConfig();
                config.BaseUrl = set.WebSiteBaseUrl;
                config.BlogId = 1;
                config.Username = set.UserName;
                config.Password = set.Passwrod;
                configs.Add(config);
            }
            return configs;
        }

        private ParserEntity getEntity(string url)
        {
            string replaceFrom = this.ParserSetting.ReplaceFrom;
            string replaceTo = this.ParserSetting.ReplaceTo;
            if (url.Length < 5)
                return null;
            ParserEntity entity = new ParserEntity();
            HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = hw.Load(url);
            string tempHtml = string.Empty;
            if (!string.IsNullOrEmpty(replaceFrom))
            {
                string[] arrFrom = replaceFrom.Split(new string[1] { "|" }, StringSplitOptions.None);
                string[] arrTo = replaceTo.Split(new string[1] { "1" }, StringSplitOptions.None);
                if (arrFrom.Length == arrTo.Length)
                {
                    for (int i = 0; i < arrFrom.Length; i++)
                    {
                        Regex reg = new Regex(arrFrom[i]);
                        tempHtml = reg.Replace(doc.DocumentNode.InnerHtml, arrTo[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < arrFrom.Length; i++)
                    {
                        Regex reg = new Regex(arrFrom[i]);
                        tempHtml = reg.Replace(doc.DocumentNode.InnerHtml, "");
                    }
                }
                doc.LoadHtml(tempHtml);
            }

            HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//title");
            if (node == null)
                return null;
            if (node.InnerText.Trim().Length < 5)
                return null;
            entity.Title = node.InnerText;
            entity.ConfuseTitle = ParserHelper.GetConfuseTitle(entity.Title);
            entity.HtmlContent = doc.DocumentNode.InnerHtml;
            entity.TextContent = GetMainContentHelper.GetMainContent(entity.HtmlContent);
            List<HtmlNode> list = new List<HtmlNode>();
            if (string.IsNullOrEmpty(ParserSetting.ContentSelectMark))
                return null;
            string[] arrMark = ParserSetting.ContentSelectMark.Split(new string[1] { "|" }, StringSplitOptions.None);
            for (int i = 0; i < arrMark.Length; i++)
            {
                var tempList = doc.Select(arrMark[i]);
                list.AddRange(tempList);
            }
            var markHtmlContent = new StringBuilder();
            var markTextContent = new StringBuilder();
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    markHtmlContent.Append(item.InnerHtml);
                    markTextContent.Append(item.InnerText);
                }
            }
            entity.MarkHtmlContent = markHtmlContent.ToString();
            entity.MarkTextContent = markTextContent.ToString();
            entity.ConfuseHtmlContent = ParserHelper.GetConfuseHtmlContent(entity.MarkHtmlContent);
            entity.ConfuseTextContent = ParserHelper.GetConfuseTextContent(entity.MarkTextContent);
            return entity;
        }




        private WordPressClient GetWpClient(string configName = "")
        {
            WordPressClient client = new WordPressClient();
            return client;
        }
        public void AutoPost(List<string> listUrl)
        {
            Thread thread = new Thread(() =>
                           {
                               if (listUrl.Count == 0)
                                   return;
                               var configs = ReadyConfigs();
                               if (configs.Count == 0)
                                   return;
                               int i = configs.Count;
                               int j = 0;
                               foreach (string s in listUrl)
                               {

                                   try
                                   {
                                       ParserEntity entity = getEntity(s);
                                       if (entity == null)
                                           return;
                                       if (string.IsNullOrEmpty(entity.Title) || string.IsNullOrEmpty(entity.MarkTextContent))
                                       {
                                           return;
                                       }
                                       var config = configs[j];
                                       using (WordPressClient client = new WordPressClient(config))
                                       {
                                           var post = new Post
                                           {
                                               PostType = "post", // "post" or "page"
                                               Title = entity.ConfuseTitle,
                                               Content = entity.ConfuseHtmlContent,// entity.ConfuseHtmlContent,
                                               PublishDateTime = DateTime.Now,//DateTime.Now.AddDays(-3),
                                               Status = "draft" // "draft" or "publish"
                                           };
                                           var id = client.NewPost(post);
                                       }
                                       if (j == i - 1)
                                           j = 0;
                                       else
                                       {
                                           j++;
                                       }
                                   }
                                   catch (Exception ex)
                                   {
                                       //记日志

                                   }



                               }

                              
                           });
            thread.Start();

        }
    }

    public class ParserEntity
    {
        public string Title { get; set; }
        public string ConfuseTitle { get; set; }
        public string TextContent { get; set; }
        public string HtmlContent { get; set; }
        public string MarkHtmlContent { get; set; }
        public string MarkTextContent { get; set; }
        public string ConfuseHtmlContent { get; set; }
        public string ConfuseTextContent { get; set; }
    }
}
