using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawler
{
    public partial class AutoPost : Form
    {
        List<string> targetSites = new List<string>();
        public AutoPost()
        {
            InitializeComponent();            
            bindSourceSetting();
        } 
        private void bindSourceSetting()
        {
            this.comSource.Items.Clear();
            SettingModel setting = SettingHelper.GetSetting();
            var list = setting.SettingList.Select(p => p.SourceName).ToArray();
            this.comSource.Items.AddRange(list);
        } 

        string startUrl = "";
        List<LinkEntity> list = new List<LinkEntity>();


        private void btnGet_Click(object sender, EventArgs e)
        {
            list.Clear();

            this.chkBox.Items.Clear();
            if (!string.IsNullOrEmpty(this.txtUrl.Text))
            {
                startUrl = txtUrl.Text;
                HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = hw.Load(startUrl);
                var obj = doc.DocumentNode.SelectNodes("//a[@href]");
                if (obj != null)
                {
                    foreach (var item in obj)
                    {
                        string title = Regex.Replace(item.InnerText.Replace("&nbsp;", "").Replace("&gt;", ""), @"\s", "");
                        if (title.Length< 8)
                            continue;
                        LinkEntity le = new LinkEntity();
                        string Link = item.Attributes["href"].Value;
                        le.LinkTitle = title;
                        if (Accumulation_Url(Link, txtUrl.Text).Trim().Length==0)
                        {
                            continue;                            
                        }
                        le.Link = Accumulation_Url(Link, txtUrl.Text);                       
                        list.Add(le);                        
                        //this.chkBox.Items.Add(le.LinkTitle + "||||" + le.Link);
                    }
                    list.Sort((x, y) =>
                    {
                        if (x.LinkTitle.Length > y.LinkTitle.Length)
                        {
                            return -1;
                        }
                        else if (x.LinkTitle.Length == y.LinkTitle.Length)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    });
                    list.ForEach((item) => {
                        this.chkBox.Items.Add(item.LinkTitle + "||||" + item.Link);
                    });
                }
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.chkBox.Items.Count; i++)
            {
                this.chkBox.SetItemChecked(i, this.chkAll.Checked);
            }
        }

        public string Accumulation_Url(string to_add, string Orgianla)
        {
            Uri absolute = new Uri(Orgianla);
            Uri result = new Uri(absolute, to_add);
            if (!result.ToString().StartsWith("http")) return Orgianla;
            return result.ToString();
        }

        

        private void btnSendPost_Click(object sender, EventArgs e)
        {
            if (this.comSource.SelectedItem == null)
                return;
                List<string> linkUrl = new List<string>();
                foreach (var item in this.chkBox.CheckedItems)
                {
                    string url = item.ToString().Split(new string[1] { "||||" }, StringSplitOptions.None)[1];
                    linkUrl.Add(url);
                }                 
                WpHelper helper = new WpHelper(this.comSource.SelectedItem.ToString());
                helper.AutoPost(linkUrl);              
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void comSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comSource.SelectedItem!=null)
            {
                this.chkBox.Items.Clear();
                string sourceName = this.comSource.SelectedItem.ToString();
                ParserSetting  set=SettingHelper.GetParserSetting(sourceName);
                if (set != null)
                {
                    this.txtUrl.Text = set.SourceUrl;
                    this.txtContentMark.Text = set.ContentSelectMark;
                    var list=set.TargetSiteUrl.ToArray();
                    this.txtReplaceForm.Text = set.ReplaceFrom;
                    this.txtReplaceTo.Text = set.ReplaceTo;
                    this.targetSiteList.Items.AddRange(list);
                    this.targetSites.Clear();
                    this.targetSites.AddRange(list);
                }
                

            }
        }

        private void btnRunAll_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }


    }
    public class LinkEntity
    {
        public string Link { get; set; }
        public string LinkTitle { get; set; }
    }

    public class SiteNameValue
    {
        public int SiteValue { get; set; }
        public string SiteName { get; set; }

        public string JoinString
        {
            get
            {
                return this.SiteValue.ToString() + "|" + this.SiteName;
            }
        }
    }


}
