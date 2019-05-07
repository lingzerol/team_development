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

namespace team_development.UI.QueryGPA
{
    public partial class QueryMark : Form
    {
        Lib.GetJWXT.GetJWXT jwxt = new Lib.GetJWXT.GetJWXT();
        public QueryMark()
        {
            InitializeComponent();
            choose_semester.SelectedIndex = 0;
            choose_academic_year.SelectedIndex = 3;
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
            this.show_gpa.Columns.Add("课程名称", 90, HorizontalAlignment.Center);
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
            //Regex reg = new Regex(@"(?<=< TD >)(.*?)(?=</ TD >)", RegexOptions.IgnoreCase);//[^(<td>))] 
            Regex reg = new Regex(@"<TD>[^<]*</TD>", RegexOptions.IgnoreCase);//[^(<td>))] 

            MatchCollection mc = reg.Matches(str);
            //showtable.Text = GpaDoc.Body.InnerHtml;

            foreach (Match m in mc)
            {
                itemlist += m.Value + "\r\n";
            }
            MessageBox.Show(itemlist);
        }
    }
}
