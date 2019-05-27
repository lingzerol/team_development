using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
using System.Web;
using System.Threading;
using System.IO;

namespace team_development.UI.Search
{
    public partial class Search : Form
    {
        private NoticeSearch notice = new NoticeSearch();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Search()
        {
            InitializeComponent();
            
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timerTick);
            timer.Stop();
            notice.getHtml("%E6%9A%A8%E5%8D%97%E5%A4%A7%E5%AD%A6%E7%8F%A0%E6%B5%B7%E6%A0%A1%E5%8C%BA");
            timer.Start();
        }

        private void TableLoad() {
            showitem.GridLines = true;

            showitem.View = View.Details;
            showitem.Scrollable = true;

            this.showitem.Columns.Add("标题", 570, HorizontalAlignment.Center);
            this.showitem.Columns.Add("时间", 130, HorizontalAlignment.Center);
        }

        private void timerTick(object sender, EventArgs e)
        {
            try
            {
                //webBrowser1.DocumentText = notice.getText();               
                timer.Stop();
            }
            catch (Exception E)
            {
                Log.log.Error(E.ToString());
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        /*private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Document.Body.Style = "zoom:0.73";
            foreach (HtmlElement archor in webBrowser1.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }

            foreach (HtmlElement form in this.webBrowser1.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
        }*/

        private void btn_search_Click(object sender, EventArgs e)
        {
            Log.log.Info("Search the Jinan University's news and notices.");
            //MessageBox.Show(searchBox.Text);
            List<Info> searchinfos = new List<Info>();
            foreach (Info record in infos)
            {
                if (record.getTitle().IndexOf(searchBox.Text) != -1)
                    searchinfos.Add(record);
            }
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            if (searchinfos != null && searchinfos.Count > 0) {
                Filllistview(searchinfos);
                //MessageBox.Show(searchinfos.Count.ToString());
            }
            else
                MessageBox.Show("不存在您要搜索的信息");
            this.showitem.EndUpdate();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Log.log.Info("Go back to the previous page.");
            timer.Start();
            //webBrowser1.GoBack();
        }

        List<Info> infos = new List<Info>();
        private void choosetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosetype.SelectedIndex != null) {
                showitem.Clear();
                TableLoad();
                this.showitem.BeginUpdate();
                switch (choosetype.SelectedIndex) {
                    case 0:
                        MessageBox.Show("nothing changed");
                        break;
                    case 1:
                        infos = GetInfo(@"Campus_notification.txt");
                        Filllistview(infos);
                        break;
                    case 2:
                        infos = GetInfo(@"Lecture_notification.txt");
                        Filllistview(infos);
                        break;
                    case 3:
                        infos = GetInfo(@"Student_notification.txt");
                        Filllistview(infos);
                        break;
                    case 4:
                        infos = GetInfo(@"Teacher_notification.txt");
                        Filllistview(infos);
                        //MessageBox.Show(abc);
                        break;
                    default:
                        break;
                }//end of switch
                this.showitem.EndUpdate();
            }            
        }

        private void Filllistview(List<Info> targetinfos)
        {
            foreach (Info record in targetinfos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = record.getTitle();
                item.SubItems.Add(record.getTime());
                showitem.Items.Add(item);
            }
        }

        private List<Info> GetInfo(string path)
        {
            infos.Clear();
            string filePath = path;
            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fileStream, Encoding.Default);
            string content = File.ReadAllText(filePath, Encoding.UTF8);
            string[] element = content.Split(new string[] { "\n" }, StringSplitOptions.None);
            Info info;
            for (int i = 0; i < element.Length - 3; i += 3)
            {
                info = new Info(element[i], element[i + 1], element[i + 2]);
                infos.Add(info);
            }
            return infos;
        }

        private void showitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void showitem_Click(object sender, EventArgs e)
        {
            if (showitem.SelectedItems.Count > 0) {
                Notisditails notisditails = new Notisditails(infos[showitem.SelectedIndices[0]].getUrl());
                notisditails.ShowDialog();
                //MessageBox.Show(showitem.SelectedIndices[0].ToString());
            }
        }
    }
}
