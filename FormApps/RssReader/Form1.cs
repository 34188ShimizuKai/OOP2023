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
        List<MyList> myLists = new List<MyList>();

        public Form1() {
            InitializeComponent();
            
        }

        private void btGet_Click(object sender, EventArgs e) {
            search();
        }

        private void search() { 
            try {
                tbNotFound.Text = "";
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

                    tsinfo.Text = "";
                }
            }
            catch (WebException)
            {
                tbNotFound.Text = "404 Not Found";
                tsinfo.Text = "URLが無効です";
                btInputUrl.Enabled = false;
            }
            catch (ArgumentException)
            {
                tsinfo.Text = "URLを入力してください";
                tsinfo.ForeColor = Color.Red;
            }
        }
        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.Items.Count > 0)
            {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
                btInputUrl.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            tsinfo.Text = "";
            tbNotFound.Text = "";
            btInputUrl.Enabled = false;
            btDeleteUrl.Enabled = false;
        }

        private void rbScience_CheckedChanged(object sender, EventArgs e) {
            if (rbScience.Checked)
            {
                tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/science.xml";
                search();
            }
        }

        private void rbIt_CheckedChanged(object sender, EventArgs e) {
            if (rbIt.Checked)
            {
                tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
                search();
            }
        }

        private void rbDomestic_CheckedChanged(object sender, EventArgs e) {
            if (rbDomestic.Checked)
            {
                tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/domestic.xml";
                search();
            }
        }

        private void rbWorld_CheckedChanged(object sender, EventArgs e) {
            if (rbWorld.Checked)
            {
                tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/world.xml";
                search();
            }
        }

        private void tbUrl_KeyUp(object sender, KeyEventArgs e) {
            rbScience.Checked = false;
            rbIt.Checked = false;
            rbDomestic.Checked = false;
            rbWorld.Checked = false;
        }

        private void btInputUrl_Click(object sender, EventArgs e) {

            MyList myList = new MyList(tbLikeName.Text, ItemDatas[lbRssTitle.SelectedIndex].Link.ToString());
            myLists.Add(myList);
            cbMyList.Items.Add(myList.Title);
        }
        private void cbMyList_SelectedIndexChanged(object sender, EventArgs e) {
            //if (lbRssTitle.Items.Count > 0)
            wbBrowser.Navigate(myLists[cbMyList.SelectedIndex].Link);
            btDeleteUrl.Enabled = true;
        }

        private void btDeleteUrl_Click(object sender, EventArgs e) {
            myLists.Remove(myLists[cbMyList.SelectedIndex]);
            cbMyList.Items.Remove(cbMyList.SelectedItem);
            btDeleteUrl.Enabled = false;
        }
    }
}
