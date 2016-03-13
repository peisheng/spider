using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressSharp;
using WordPressSharp.Models;
namespace WebCrawler
{
    public class WpHelper
    {
        public WpHelper( )
        { 
        }
        private WordPressClient GetWpClient(string configName="")
        {
            WordPressClient client=new WordPressClient();
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
                        PublishDateTime = DateTime.Now.AddDays(-3),
                        Status = "publish" // "draft" or "publish"
                    };
                    var id=client.NewPost(post); 
                }
            }
           
        }
    }
}
