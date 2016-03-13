using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawler
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            bindListSource();
            binComSiteList();
        }

        private void binComSiteList()
        {
            this.comSiteList.Items.Clear();
            this.comSite.Items.Clear();
            var siteNameList=SettingHelper.GetSiteSettingModel().SiteSettingList.Select(p=>p.SiteName).ToArray();
            this.comSiteList.Items.AddRange(siteNameList);
            this.comSite.Items.AddRange(siteNameList);
        }

        private void bindListSource()
        {
            SettingModel setting = SettingHelper.GetSetting();
           var list= setting.SettingList.Select(p => p.SourceName).ToArray();
           this.ListSource.Items.AddRange(list);
          
            
        }

        private void ListSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.ListSource.SelectedItem.ToString();
            ParserSetting setting = SettingHelper.GetParserSetting(name);
            this.listTargetSiteUrl.Items.Clear();
            if (setting != null)
            {
                this.txtSourceName.Text = setting.SourceName;
                this.txtSourceUrl.Text = setting.SourceUrl;
                this.txtContentSelectMark.Text = setting.ContentSelectMark;
                this.txtReplaceFrom.Text = setting.ReplaceFrom;
                this.txtReplaceTo.Text = setting.ReplaceTo;
                this.listTargetSiteUrl.Items.AddRange(setting.TargetSiteUrl.ToArray());
            }
           
        }

        private void comSiteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sitename = this.comSite.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(sitename))
            {
               SiteSetting set= SettingHelper.GetSiteSetting(sitename);
               if (set != null)
               {
                   this.txtWebSiteBaseUrl.Text = set.WebSiteBaseUrl;
                   this.txtSiteName.Text = set.SiteName;
               }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SettingModel model = new SettingModel();
            model.SettingList = new List<ParserSetting>();
            for (int i = 0; i < 10; i++)
            {
                ParserSetting parser = new ParserSetting();
                parser.SourceName = "网易" + i.ToString();
                parser.SourceUrl = "http://www.163.com/"+i.ToString();
                parser.ContentSelectMark = ".content";
                parser.ReplaceFrom = "网易";
                parser.ReplaceTo = "新浪";
                parser.TargetSiteUrl = new List<string>();
                for (int j = 0; j < 10; j++)
                {
                    parser.TargetSiteUrl.Add("www.website.com.url"+j.ToString());                   
                }
                model.SettingList.Add(parser);
            }
            XmlSerializeHelper.XmlSerializeToFile(model, SettingHelper.SettingPath,Encoding.UTF8);

            SiteSettingModel siteSetting = new SiteSettingModel();
            siteSetting.SiteSettingList = new List<SiteSetting>(); 
            for (int i = 0; i < 10; i++)
            {
                SiteSetting set = new SiteSetting();
                set.SiteName = "Site"+i.ToString();
                set.WebSiteBaseUrl = "http://www.site1.com/"+i.ToString();
                set.Passwrod = "password...";
                set.BlogId = i.ToString();
                siteSetting.SiteSettingList.Add(set);
            }
            XmlSerializeHelper.XmlSerializeToFile(siteSetting,SettingHelper.SiteSettingPath,Encoding.UTF8);
           
            
        }

        private void btnAddTarget_Click(object sender, EventArgs e)
        {
            string sitename=this.comSiteList.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(sitename))
            {
                SiteSetting set=SettingHelper.GetSiteSetting(sitename);
                if (!this.listTargetSiteUrl.Items.Contains(set.WebSiteBaseUrl))
                {
                    this.listTargetSiteUrl.Items.Add(set.WebSiteBaseUrl);                    
                }
            }
        }

        private void btnDeleteSiteUrl_Click(object sender, EventArgs e)
        {
            if (this.listTargetSiteUrl.SelectedItem != null)
            {
                this.listTargetSiteUrl.Items.Remove(this.listTargetSiteUrl.SelectedItem);
            }
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {

        }

        private void btnDelSite_Click(object sender, EventArgs e)
        {
            string siteName = this.comSite.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(siteName))
            {
                this.comSite.Items.Remove(this.comSite.SelectedItem);
            }
            SettingHelper.RemoveSiteSetting(siteName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelSource_Click(object sender, EventArgs e)
        {
          
            string sourceName = this.ListSource.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(sourceName))
            {
               DialogResult result= MessageBox.Show("确定要删当前源配置吗？");
               if (result == DialogResult.OK)
               {
                   this.ListSource.Items.Remove(this.ListSource.SelectedItem);
                   SettingHelper.RemoveParserSetting(sourceName);
               }

                
            }
           
        }

        private void btnSaveSource_Click(object sender, EventArgs e)
        {
            
        }
    }
}
