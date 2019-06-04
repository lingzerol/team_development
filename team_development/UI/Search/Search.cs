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
using Lib.GetNotifications;

namespace team_development.UI.Search
{
    public partial class Search : Form
    {
        private NoticeSearch notice = new NoticeSearch();
        public List<Info> allinfos = new List<Info>();
        public List<Info> showedinfos = new List<Info>();
        private List<Info> preinfos = new List<Info>();

        public Search()
        {
            InitializeComponent();
            TableLoad();
            if (File.Exists(@"baozhuang_news.txt"))
            {
                showedinfos = GetInfo(@"baozhuang_news.txt");   //默认的信息
                Filllistview(showedinfos);
                preinfos = new List<Info>(showedinfos);
            }
        }

        private void TableLoad() {
            showitem.GridLines = true;

            showitem.View = View.Details;
            showitem.Scrollable = true;
            this.showitem.Columns.Add("标题", 570, HorizontalAlignment.Center);
            this.showitem.Columns.Add("时间", 130, HorizontalAlignment.Center);
        }

        private void Search_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(allinfos.Count.ToString());
        }
        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"jnu_news.txt") || !File.Exists(@"Campus_notification.txt") || !File.Exists(@"Lecture_notification.txt") || !File.Exists(@"Student_notification.txt") || !File.Exists(@"Teacher_notification.txt"))
            {
                return;
            }
            Log.log.Info("Search the Jinan University's news and notices.");
            allinfos.Clear();
            //allinfos里面存放着全部学院全部新闻和通知
            allinfos = GetInfo(@"baozhuang_news.txt");
            allinfos.AddRange(GetInfo(@"diangong_news.txt"));
            allinfos.AddRange(GetInfo(@"fanyi_news.txt"));
            allinfos.AddRange(GetInfo(@"renwen_news.txt"));
            allinfos.AddRange(GetInfo(@"zhike_news.txt"));
            allinfos.AddRange(GetInfo(@"guoshang_news.txt"));
            allinfos.AddRange(GetInfo(@"Campus_notification.txt"));
            allinfos.AddRange(GetInfo(@"Lecture_notification.txt"));
            allinfos.AddRange(GetInfo(@"Student_notification.txt"));
            allinfos.AddRange(GetInfo(@"Teacher_notification.txt"));
            //MessageBox.Show(searchBox.Text);
            List<Info> searchinfos = new List<Info>();
            foreach (Info record in allinfos)
            {
                if (record.getTitle().IndexOf(searchBox.Text) != -1)
                    searchinfos.Add(record);
            }
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            if (searchinfos != null && searchinfos.Count > 0) {
                showedinfos = searchinfos;
                Filllistview(showedinfos);
                //MessageBox.Show(searchinfos.Count.ToString());
            }
            else
                MessageBox.Show("不存在您要搜索的信息");
            this.showitem.EndUpdate();
        }

        private void choosetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosetype.SelectedIndex != null)
            {
                Choosetypetoshow(choosetype.SelectedIndex);
            }
        }

        private void choosecollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosecollege.SelectedIndex != null) {

            }
        }

        private void Choosetypetoshow(int index)
        {
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            switch (index)
            {
                case 0:
                    //Filllistview(@"baozhuang_news.txt");
                    showedinfos = GetInfo(@"baozhuang_news.txt");//默认新闻，具体要看用户选择
                   //showedinfos.AddRange(GetInfo(@"diangong_news.txt"));
                    Filllistview(showedinfos);
                    //Filllistview(@"diangong_news.txt");
                    break;
                case 1:
                    showedinfos = GetInfo(@"Campus_notification.txt");
                    Filllistview(@"Campus_notification.txt");
                    break;
                case 2:
                    showedinfos = GetInfo(@"Lecture_notification.txt");
                    Filllistview(@"Lecture_notification.txt");
                    break;
                case 3:
                    showedinfos = GetInfo(@"Student_notification.txt");
                    Filllistview(@"Student_notification.txt");
                    break;
                case 4:
                    showedinfos = GetInfo(@"Teacher_notification.txt");
                    Filllistview(@"Teacher_notification.txt");
                    //MessageBox.Show(abc);
                    break;

                default:
                    break;
            }//end of switch
            preinfos = new List<Info>(showedinfos);
            getinfos();
            this.showitem.EndUpdate();
        }
        private void Filllistview(string path) {
            if (!File.Exists(@"jnu_news.txt"))
            {
                MessageBox.Show("请刷新");
                return;
            }
            List<Info> targetinfos = GetInfo(path);
            Filllistview(targetinfos);
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
            //showedinfos.Clear();
            List<Info> temp = new List<Info>();
            string filePath = path;
            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fileStream, Encoding.Default);
            string content = File.ReadAllText(filePath, Encoding.UTF8);
            string[] element = content.Split(new string[] { "\n" }, StringSplitOptions.None);
            Info info;
            for (int i = 0; i < element.Length - 3; i += 3)
            {
                info = new Info(element[i], element[i + 1], element[i + 2]);
                temp.Add(info);
            }
            return temp;
        }

        private void showitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void showitem_Click(object sender, EventArgs e)
        {
            if (showitem.SelectedItems.Count > 0) {
                Notisditails notisditails = new Notisditails(showedinfos[showitem.SelectedIndices[0]].getUrl());
                notisditails.ShowDialog();
                //MessageBox.Show(showitem.SelectedIndices[0].ToString());
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            PyNotifications getnoti = new PyNotifications();
            new Thread(getnoti.Init).Start();
            PyNews getnews = new PyNews();
            new Thread(getnews.Init).Start();
            Waiting wait = new Waiting();
            wait.StartKiller();
            Choosetypetoshow(choosetype.SelectedIndex);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }       

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            getinfos();
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            getinfos();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            getinfos();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            getinfos();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            getinfos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                // showitem.Clear();
                /*  TableLoad();
                  this.showitem.BeginUpdate();
                  //MessageBox.Show("包装");
                //  showedinfos.AddRange(GetInfo(@"baozhuang_news.txt"));

                //                 showedinfos = GetInfo(@"baozhuang_news.txt");
                  Filllistview(@"baozhuang_news.txt");
                  this.showitem.EndUpdate();
      */
                getinfos();
            
   
        }
        void getinfos()
        {
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            showedinfos.Clear();
            showedinfos = new List<Info>(preinfos);  //深复制
            if (checkBox1.Checked)
            {
                showedinfos.AddRange(GetInfo(@"baozhuang_news.txt"));               
            }
            if (checkBox2.Checked)
            {
                showedinfos.AddRange(GetInfo(@"diangong_news.txt"));
               
            }
            if (checkBox3.Checked)
            {
                showedinfos.AddRange(GetInfo(@"zhike_news.txt"));               
            }
            if (checkBox4.Checked)
            {
                showedinfos.AddRange(GetInfo(@"guoshang_news.txt"));              
            }
            if (checkBox5.Checked)
            {
                showedinfos.AddRange(GetInfo(@"fanyi_news.txt"));

            }
            if (checkBox6.Checked)
            {
                showedinfos.AddRange(GetInfo(@"renwen_news.txt"));
            }           
            Filllistview(showedinfos);

            this.showitem.EndUpdate();
        }
        
    }
}