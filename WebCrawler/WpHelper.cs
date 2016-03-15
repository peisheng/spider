using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressSharp;
using WordPressSharp.Models;
using HtmlAgilityPack.Extensions;
using HtmlAgilityPack;
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
            if (url.Length < 5)
                return null;
            ParserEntity entity = new ParserEntity();
            HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = hw.Load(url);
            HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//title");
            if (node == null)
                return null;
            entity.Title = node.InnerText;
            entity.HtmlContent = doc.DocumentNode.InnerHtml;
            entity.TextContent = GetMainContentHelper.GetMainContent(entity.HtmlContent);
            //entity.MarkHtmlContent = doc.Select(ParserSetting.ContentSelectMark);
            return entity;
        }

       

        private WordPressClient GetWpClient(string configName = "")
        {
            WordPressClient client = new WordPressClient();
            return client;
        }
        public void AutoPost(List<string> listUrl)
        {
            using (WordPressClient client = GetWpClient())
            {
                foreach (var item in listUrl)
                {
                    HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = hw.Load(item);
                    HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//title");
                    if (node == null)
                        continue;
                    string title = node.InnerText;
                    string contentHtml = doc.DocumentNode.InnerHtml;

                    string content = GetMainContentHelper.GetMainContent(contentHtml);
                    var post = new Post
                    {
                        PostType = "post", // "post" or "page"
                        Title = title,
                        Content = content,
                        PublishDateTime = DateTime.Now,//DateTime.Now.AddDays(-3),
                        Status = "draft" // "draft" or "publish"
                    };
                    var id = client.NewPost(post);
                }
            }

        }
    }

    public class ParserEntity
    {
        public string Title { get; set; }
        public string TextContent { get; set; }
        public string HtmlContent { get; set; }
        public string MarkHtmlContent { get; set; }
        public string MarkTextContent { get; set; }
        public string ConfuseHtmlContent { get; set; }
    }
}
