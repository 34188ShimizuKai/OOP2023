using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> ItemDatas = new List<ItemData>();
        public Form1() {
            InitializeComponent();
            
        }

        private void btGet_Click(object sender, EventArgs e) {
            try {
                lbRssTitle.Items.Clear();
                using (var wc = new WebClient())
                {

                    var url = wc.OpenRead(tbUrl.Text);
                    XDocument xdoc = XDocument.Load(url);

                    ItemDatas = xdoc.Root.Descendants("item").
                        Select(x => new ItemData
                        {
                            Title = (string)x.Element("title"),
                            Link = (string)x.Element("link")
                        }).ToList();

                    foreach (var node in ItemDatas)
                    {
                        //string s = Regex.Replace(node.Value, "【|】", ""); 
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
            }
            catch (ArgumentException)
            {
                tsinfo.Text = "URLが無効です";
                tsinfo.ForeColor = Color.Red;
            }
        }
        private void lbRssTitle_Click(object sender, EventArgs e) {
            wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
        }

        private void Form1_Load(object sender, EventArgs e) {
            tsinfo.Text = "";
        }

        private void rbScience_CheckedChanged(object sender, EventArgs e) {

        }

        private void tbIt_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbDomestic_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbWorld_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
