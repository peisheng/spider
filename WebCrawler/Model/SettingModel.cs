using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
     

    public class SettingModel
    {
        public List<ParserSetting> SettingList { get; set; }
 
    }

    public class SiteSettingModel
    {
        public List<SiteSetting> SiteSettingList { get; set; }
    }

    public class ParserSetting {
        public string SourceName { get; set; }
        public string SourceUrl { get; set; }
        public string ContentSelectMark { get; set; }
        public List<string> TargetSiteUrl { get; set; }
        
        public string ReplaceFrom

        {
            get;
            set;
        }
        public string ReplaceTo
        {
            get;
            set;
        }

    }

    public class SiteSetting
    {
        public string WebSiteBaseUrl { get; set; }
        public string SiteName { get; set; }
        public string  UserName { get; set; }
        public string Passwrod { get; set; }    
        public string BlogId { get; set; }
    }
}
