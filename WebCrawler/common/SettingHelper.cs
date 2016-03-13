using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    public  class SettingHelper
    {
        public static SettingModel setting;
        public static SiteSettingModel siteSetting;
        static Encoding utf8 = Encoding.UTF8;
        public static string SettingPath {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + "//" + "SettingModel.xml";
            }
        }
        public static string SiteSettingPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + "//" + "SiteSettingModel.xml";
            }
        }
        public static SettingModel GetSetting()
        {
            if (setting == null)
            {
                setting = XmlSerializeHelper<SettingModel>.XmlDeserializeFromFile(SettingPath, utf8);
            }
            return setting;
        }

        public static ParserSetting GetParserSetting(string sourceName)
        {
            ParserSetting ps = GetSetting().SettingList.Where(p => p.SourceName == sourceName).FirstOrDefault();
            return ps;
        }

        public static void RemoveParserSetting(string sourceName)
        {
            var set = GetParserSetting(sourceName);
            var list = GetSetting().SettingList;
            list.Remove(set);
            setting.SettingList = list;
            XmlSerializeHelper.XmlSerializeToFile(setting,SettingPath,utf8);

            
        }
        public static SiteSettingModel GetSiteSettingModel()
        {
            if (siteSetting == null)
            {
                siteSetting = XmlSerializeHelper<SiteSettingModel>.XmlDeserializeFromFile(SiteSettingPath, utf8);
            }
            return siteSetting;
        }
        public static void SaveSettingModel()
        {           
            XmlSerializeHelper.XmlSerializeToFile(setting,SettingPath,utf8);
        }
        public static void SaveSiteSettingModel()
        {
            XmlSerializeHelper.XmlSerializeToFile(siteSetting,SiteSettingPath,utf8);
        }
        public static SiteSetting GetSiteSetting(string siteName)
        {
          SiteSetting ss=  GetSiteSettingModel().SiteSettingList.Where(p=>p.SiteName==siteName).FirstOrDefault();
          return ss;
        }
        public static void RemoveSiteSetting(string siteName)
        {
            SiteSetting set = GetSiteSetting(siteName);
            var list = GetSiteSettingModel().SiteSettingList;
            list.Remove(set);
            siteSetting.SiteSettingList = list;
            XmlSerializeHelper.XmlSerializeToFile(siteSetting,SiteSettingPath,utf8);
        }
      
    }
}
