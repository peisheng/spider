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
    public partial class AutoPost : Form
    {
        public AutoPost()
        {
            InitializeComponent();
            bindComList();
        }

        private void bindComList()
        {
            var items = getList().Select(p => p.JoinString);
            this.comboBox1.Items.AddRange(items.ToArray());


        }
        private List<SiteNameValue> getList()
        {
            List<SiteNameValue> list = new List<SiteNameValue>();
            string[] array = { "完美诛仙", "圣灵诛仙", "玄月诛仙", "缘定诛仙", "诛仙发布网" };
            for (int i = 0; i < array.Length; i++)
            {
                SiteNameValue site = new SiteNameValue();
                site.SiteName = array[i];
                site.SiteValue = i + 1;
                list.Add(site);
            }
            return list;
        }

        string startUrl = "";
        List<LinkEntity> list = new List<LinkEntity>();


        private void btnGet_Click(object sender, EventArgs e)
        {

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
                        
                        if (item.InnerText.Replace("&nbsp;","").Length < 8)
                            continue;
                        LinkEntity le = new LinkEntity();
                        string Link = item.Attributes["href"].Value;
                        le.LinkTitle = item.InnerText;
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
            
                List<string> linkUrl = new List<string>();
                foreach (var item in this.chkBox.CheckedItems)
                {
                    string url = item.ToString().Split(new string[1] { "||||" }, StringSplitOptions.None)[1];
                    linkUrl.Add(url);
                }
                 
                WpHelper helper = new WpHelper();
                helper.AutoPost(linkUrl);  
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
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
