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
        //allinfos存放所有院的所有通知和新闻
        public List<Info> allinfos = new List<Info>();
        //showedinfos存放现在要显示的通知和新闻
        public List<Info> showedinfos = new List<Info>();
        private List<Info> preinfos = new List<Info>();
        private int type = 0;
        public Search()
        {
            InitializeComponent();
            TableLoad();

            switch (GlobalData.userInfo.College)
            {
                case 0:
                    checkBox_cahs.Checked = true;
                    break;
                case 1:
                    checkBox_translate.Checked = true;
                    break;
                case 2:
                    checkBox_nb.Checked = true;
                    break;
                case 3:
                    checkBox_it.Checked = true;
                    break;
                case 4:
                    checkBox_ele.Checked = true;
                    break;
                case 5:
                    checkBox_pack.Checked = true;
                    break;
                default:
                    break;
            }
            showedinfos = GetInfo(@"Student_notification.txt");
            showedinfos.AddRange(GetInfo(@"Teacher_notification.txt"));
            showedinfos.AddRange(GetInfo(@"Lecture_notification.txt"));
            showedinfos.AddRange(GetInfo(@"Campus_notification.txt"));
            preinfos = new List<Info>(showedinfos);
            Filllistview(showedinfos);
           // getinfos();
        }

        private void TableLoad() {
            showitem.GridLines = true;

            showitem.View = View.Details;
            showitem.Scrollable = true;
            this.showitem.Columns.Add("标题", 500, HorizontalAlignment.Center);
            this.showitem.Columns.Add("时间", 130, HorizontalAlignment.Center);
            this.showitem.Columns.Add("发布单位", 130, HorizontalAlignment.Center);
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
            /*if (!File.Exists(@"jnu_news.txt") || !File.Exists(@"Campus_notification.txt") || !File.Exists(@"Lecture_notification.txt") || !File.Exists(@"Student_notification.txt") || !File.Exists(@"Teacher_notification.txt"))
            {
                return;
            }*/
            Log.log.Info("Search the Jinan University's news and notices.");
            allinfos.Clear();
            //allinfos里面存放着全部学院全部新闻和通知
            allinfos = GetInfo(@"baozhuang_news.txt");
            allinfos.AddRange(GetInfo(@"dianqi_news.txt"));
            allinfos.AddRange(GetInfo(@"fanyi_news.txt"));
            allinfos.AddRange(GetInfo(@"renwen_news.txt"));
            allinfos.AddRange(GetInfo(@"zhike_news.txt"));
            allinfos.AddRange(GetInfo(@"guoshang_news.txt"));

            allinfos.AddRange(GetInfo(@"baozhuang_inform.txt"));    //包装院
            allinfos.AddRange(GetInfo(@"Electric_inform.txt")); //电气院
            allinfos.AddRange(GetInfo(@"IT_inform.txt"));   //智科院
            allinfos.AddRange(GetInfo(@"NB_inform.txt"));   //国商院
            allinfos.AddRange(GetInfo(@"rwxy_inform.txt")); //人文院
            allinfos.AddRange(GetInfo(@"translate_inform.txt"));    //翻院
            allinfos.AddRange(GetInfo(@"sina.txt"));
            allinfos.AddRange(GetInfo(@"Campus_notification.txt"));
            allinfos.AddRange(GetInfo(@"Lecture_notification.txt"));
            allinfos.AddRange(GetInfo(@"Student_notification.txt"));
            allinfos.AddRange(GetInfo(@"Teacher_notification.txt"));
            //MessageBox.Show(Encoding.UTF8.GetString(Encoding.Default.GetBytes(searchBox.Text)));
            List<Info> searchinfos = new List<Info>();
            foreach (Info record in allinfos)
            {
                if (record.getTitle().IndexOf(searchBox.Text) != -1)
                //if (record.getTitle().IndexOf(Encoding.UTF8.GetString(Encoding.Default.GetBytes(searchBox.Text))) != -1)
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

        private void Choosetypetoshow(int index)
        {
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            type = index;
            switch (index)
            {
                case 0:
                    showedinfos = GetInfo(@"Student_notification.txt");
                    showedinfos.AddRange(GetInfo(@"Teacher_notification.txt"));
                    showedinfos.AddRange(GetInfo(@"Lecture_notification.txt"));
                    showedinfos.AddRange(GetInfo(@"Campus_notification.txt"));
                    preinfos = new List<Info>(showedinfos);
                    Filllistview(showedinfos);
                    break;
                case 1:
                    showedinfos = GetInfo(@"sina.txt");
                    Filllistview(@"sina.txt");
                    break;
                //case 2:
                //    showedinfos = GetInfo(@"sina.txt");
                //    Filllistview(@"sina.txt");
                //    break;
                //case 3:
                //    showedinfos = GetInfo(@"Student_notification.txt");
                //    Filllistview(@"Student_notification.txt");
                //    break;
                //case 4:
                //    showedinfos = GetInfo(@"Teacher_notification.txt");
                //    Filllistview(@"Teacher_notification.txt");
                //    //MessageBox.Show(abc);
                //    break;
                default:
                    break;
            }//end of switch
           
            if (index == 0)
            {
                getinfos();
            }
            this.showitem.EndUpdate();
        }
        private void Filllistview(string path) {
            if (!File.Exists(@"baozhuang_news.txt")||!File.Exists(@"Teacher_notification.txt"))
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
                item.SubItems.Add(record.getIssuer());
                showitem.Items.Add(item);
            }
        }

        //要修改：读取的同时设置学院和类型，比如：国商新闻、国商通知之类的
        private List<Info> GetInfo(string path)
        {
            //showedinfos.Clear();
            List<Info> temp = new List<Info>();
            if (!File.Exists(path)) {
                return temp;
            }
            string filePath = path;
            string issuer = "unidentify source";
            switch (filePath) {
                case @"Student_notification.txt":
                    issuer = "学生通知";
                    break;
                case @"Teacher_notification.txt":
                    issuer = "教师通知";
                    break;
                case @"Lecture_notification.txt":
                    issuer = "课程通知";
                    break;
                case @"Campus_notification.txt":
                    issuer = "校园通知";
                    break;
                case @"baozhuang_news.txt":
                    issuer = "包装新闻";
                    break;
                case @"dianqi_news.txt":
                    issuer = "电气新闻";
                    break;
                case @"fanyi_news.txt":
                    issuer = "翻译新闻";
                    break;
                case @"renwen_news.txt":
                    issuer = "人文新闻";
                    break;
                case @"zhike_news.txt":
                    issuer = "智科新闻";
                    break;
                case @"guoshang_news.txt":
                    issuer = "国商新闻";
                    break;
                case @"baozhuang_inform.txt":
                    issuer = "包装通知";
                    break;
                case @"Electric_inform.txt":
                    issuer = "电气通知";
                    break;
                case @"IT_inform.txt":
                    issuer = "智科通知";
                    break;
                case @"NB_inform.txt":
                    issuer = "国商通知";
                    break;
                case @"rwxy_inform.txt":
                    issuer = "人文通知";
                    break;
                case @"translate_inform.txt":
                    issuer = "翻译通知";
                    break;
                case @"sina.txt":
                    issuer = "新浪新闻";
                    break;
                    //
                default:
                    //issuer = "没有进入case";
                    break;
            }
            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fileStream, Encoding.Default);
            string content = File.ReadAllText(filePath, Encoding.UTF8);
            //string content = File.ReadAllText(filePath);
            string[] element = content.Split(new string[] { "\n" }, StringSplitOptions.None);
            Info info;
            if (filePath.IndexOf("news") != -1||filePath.IndexOf("inform")!=-1)
            {
                for (int i = 0; i < element.Length - 3; i += 3)
                {
                    info = new Info(element[i], element[i + 1], element[i + 2]);
                    info.setIssuer(issuer);
                    temp.Add(info);
                }
                return temp;
            }//end of if
            else {
                for (int i = 0; i < element.Length - 3; i += 3)
                {
                    info = new Info(element[i], element[i + 2], element[i + 1]);
                    info.setIssuer(issuer);
                    temp.Add(info);
                }
                return temp;
            } 
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
            PySina getsina = new PySina();
            //getsina.Init();
            new Thread(getsina.Init).Start();
            Waiting wait = new Waiting();
            wait.StartKiller();
            
            Choosetypetoshow(choosetype.SelectedIndex);
            if (type == 0)
            {
                getinfos();
            }
         }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }       

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (type == 0)
                getinfos();
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (type == 0)
                getinfos();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (type == 0)
                getinfos();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (type == 0)
                getinfos();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (type == 0)
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
            if (type == 0)

                getinfos();            
        }

        void getinfos()
        {
            showitem.Clear();
            TableLoad();
            this.showitem.BeginUpdate();
            showedinfos.Clear();
            showedinfos = new List<Info>(preinfos);

            //要修改：比如点选了国商，则要遍历一遍allinfos，
            //把其中issuer包含国商字段的拿出来加到showedinfos中
            if (type == 0)
            {
                //深复制
                if (checkBox_pack.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"baozhuang_news.txt"));
                    showedinfos.AddRange(GetInfo(@"baozhuang_inform.txt"));
                }
                if (checkBox_ele.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"dianqi_news.txt"));
                    showedinfos.AddRange(GetInfo(@"Electric_inform.txt"));
                }
                if (checkBox_it.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"zhike_news.txt"));
                    showedinfos.AddRange(GetInfo(@"IT_inform.txt"));
                }
                if (checkBox_nb.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"guoshang_news.txt"));
                    //6.10 test
                    showedinfos.AddRange(GetInfo(@"NB_inform.txt"));                    
                }
                if (checkBox_translate.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"fanyi_news.txt"));
                    showedinfos.AddRange(GetInfo(@"translate_inform.txt"));
                }
                if (checkBox_cahs.Checked)
                {
                    showedinfos.AddRange(GetInfo(@"renwen_news.txt"));
                    showedinfos.AddRange(GetInfo(@"rwxy_inform.txt"));
                    //
                }
            }           
            //else if (type == 3) {
            //    if (checkBox_pack.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"baozhuang_inform.txt"));
            //    }
            //    if (checkBox_ele.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"Electric_inform.txt"));                  
            //    }
            //    if (checkBox_it.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"IT_inform.txt"));
                    
            //    }
            //    if (checkBox_nb.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"NB_inform.txt"));
            //    }
            //    if (checkBox_translate.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"translate_inform.txt"));

            //    }
            //    if (checkBox_cahs.Checked)
            //    {
            //        showedinfos.AddRange(GetInfo(@"rwxy_inform.txt"));
                   
            //    }
            //}
            Filllistview(showedinfos);
            this.showitem.EndUpdate();
        }
    }
}