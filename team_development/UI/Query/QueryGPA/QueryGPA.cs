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
using team_development.UI.Query.QueryGPA;

namespace team_development.UI.QueryGPA
{
    public partial class QueryMark : Form
    {
        Lib.GetJWXT.GetJWXT jwxt = new Lib.GetJWXT.GetJWXT();
        List<Gpa> Gpalist = new List<Gpa>();
        public QueryMark()
        {
            InitializeComponent();
            //choose_semester.SelectedIndex = 0;  设置下拉框初始值，同下
            //choose_academic_year.SelectedIndex = 3;
            TableLoad();
 
        }

        public void TableLoad()
        {
            show_gpa.GridLines = true;//表格是否显示网格线

            show_gpa.View = View.Details;//设置显示方式
            show_gpa.Scrollable = true;//是否自动显示滚动条

            /*this.show_gpa.Columns.Add("课程代码", 90, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程名称", 120, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程绩点", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程状态", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程类别", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学分", 80, HorizontalAlignment.Center);
            */
            this.show_gpa.Columns.Add("学年", 90, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学期", 60, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程名称", 150, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学分", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("绩点", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程类别", 90, HorizontalAlignment.Center);
            
        }

        private void GpaInquiry_Load(object sender, EventArgs e)
        {

        }

        private void Show_gpa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {
            ShowValidate.Image = jwxt.GetValidateImage();
        }

        private void login_Click(object sender, EventArgs e)
        {
            jwxt.Login("2016052351", "liangzp1818", GetValide.Text);
        }

        private void getgpa_Click(object sender, EventArgs e)
        {
            //showhtml.Text = jwxt.GetGPA();
            HtmlDocument GpaDoc = jwxt.GetGPA();

            string str = (string)GpaDoc.Body.InnerHtml;
            string itemlist=null;
            Regex reg = new Regex(@"<TD>[^<]*</TD>", RegexOptions.IgnoreCase);//[^(<td>))] 

            MatchCollection mc = reg.Matches(str);
            //showtable.Text = GpaDoc.Body.InnerHtml;

            foreach (Match m in mc)
            {
                itemlist += m.Value + "\r\n";
            }
            //MessageBox.Show(itemlist);

            /*Gpa record = new Gpa();
            for () {
                Gpalist.Add(record);
            }

            //开始往listview输入
            this.show_gpa.BeginUpdate();
            foreach (Gpa g in Gpalist) {
                ListViewItem temp = new ListViewItem();
                temp.SubItems.Add("2016-2017");
                temp.SubItems.Add("上");
                temp.SubItems.Add("中国近代史纲要");
                temp.SubItems.Add("2.00");
            }*/
            float a = 2.00f;
            this.show_gpa.BeginUpdate();
            ListViewItem temp = new ListViewItem();
            temp.Text="2016-2017";
            temp.SubItems.Add("上");
            temp.SubItems.Add("中国近代史纲要");
            temp.SubItems.Add(a.ToString());
            temp.SubItems.Add("95.0");
            temp.SubItems.Add("9.0");
            temp.SubItems.Add("公共选修课");
            this.show_gpa.Items.Add(temp);
            this.show_gpa.EndUpdate();
        }
    }
}
