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
        public List<Gpa> Gpas = new List<Gpa>();
        public QueryMark()
        {
            InitializeComponent();
            choose_semester.SelectedIndex = 0;
            choose_academic_year.SelectedIndex = 0;
            TableLoad();
        }

        public void TableLoad()
        {
            show_gpa.GridLines = true;//表格是否显示网格线

            show_gpa.View = View.Details;//设置显示方式
            show_gpa.Scrollable = true;//是否自动显示滚动条
            
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
            HtmlDocument GpaDoc = jwxt.GetGPA();
            show_gpa.Clear();
            TableLoad();

            string str = (string)GpaDoc.Body.InnerHtml;
            string itemlist=null;
            Regex reg = new Regex(@"<TD>[^<]*</TD>", RegexOptions.IgnoreCase); 
            MatchCollection mc = reg.Matches(str);
            string item;
             int i = 0;
            string a="";
            string schoolyear="" ;
            string semester="";
            string coursename ="";
            float credit=0, mark=0,gp=0;
            string coursecategory="";
            foreach (Match m in mc)
            {
                item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                if (!Ru.Equals(""))
                {
                    switch (i)
                    {
                        case 0:
                            schoolyear = Ru;
                            break;
                        case 1:
                            semester = Ru;
                            break;
                        case 2:
                            coursename = Ru;
                            break;
                        case 3:
                            credit =Convert.ToSingle(Ru);
                            break;
                        case 4:
                            mark = Convert.ToSingle(Ru);
                            break;
                        case 5:
                            gp = Convert.ToSingle(Ru);
                            break;
                        case 8:
                            coursecategory = Ru;

                        Gpa  gpa = new Gpa(schoolyear, semester, coursename, credit, mark, gp, coursecategory);
                            Gpas.Add(gpa);
                            break;
                    }
                    i++;
                    i = i % 11;
                   
                   }
            }
            foreach (Gpa g in Gpas)
            {
                itemlist += g.mark + "\r\n";

            }
            ListViewItem temp;
            int flag = 0;
            if (choose_academic_year.Text !="ALL")
                flag++;
            if (choose_semester.Text != "ALL")
                flag+=2;

            this.show_gpa.BeginUpdate();
            switch (flag) {
                case 0:
                    foreach (Gpa g in Gpas)
                    {
                        temp = new ListViewItem();
                        temp.Text = g.schoolyear;
                        temp.SubItems.Add(g.semester);
                        temp.SubItems.Add(g.coursename);
                        temp.SubItems.Add(g.credit.ToString());
                        temp.SubItems.Add(g.mark.ToString());
                        temp.SubItems.Add(g.gp.ToString());
                        temp.SubItems.Add(g.coursecategory);
                        this.show_gpa.Items.Add(temp);
                    }
                    break;
                case 1:
                    foreach (Gpa g in Gpas)
                    {
                        if (g.schoolyear == choose_academic_year.Text)
                        {
                            temp = new ListViewItem();
                            temp.Text = g.schoolyear;
                            temp.SubItems.Add(g.semester);
                            temp.SubItems.Add(g.coursename);
                            temp.SubItems.Add(g.credit.ToString());
                            temp.SubItems.Add(g.mark.ToString());
                            temp.SubItems.Add(g.gp.ToString());
                            temp.SubItems.Add(g.coursecategory);
                            this.show_gpa.Items.Add(temp);
                        }
                    }
                    break;
                case 2:
                    foreach (Gpa g in Gpas)
                    {
                        if (g.semester==choose_semester.Text)
                        {
                            temp = new ListViewItem();
                            temp.Text = g.schoolyear;
                            temp.SubItems.Add(g.semester);
                            temp.SubItems.Add(g.coursename);
                            temp.SubItems.Add(g.credit.ToString());
                            temp.SubItems.Add(g.mark.ToString());
                            temp.SubItems.Add(g.gp.ToString());
                            temp.SubItems.Add(g.coursecategory);
                            this.show_gpa.Items.Add(temp);
                        }
                    }
                    break;
                case 3:
                    foreach (Gpa g in Gpas)
                    {
                        if ((g.schoolyear == choose_academic_year.Text)&& 
                            (g.semester == choose_semester.Text))
                        {
                            temp = new ListViewItem();
                            temp.Text = g.schoolyear;
                            temp.SubItems.Add(g.semester);
                            temp.SubItems.Add(g.coursename);
                            temp.SubItems.Add(g.credit.ToString());
                            temp.SubItems.Add(g.mark.ToString());
                            temp.SubItems.Add(g.gp.ToString());
                            temp.SubItems.Add(g.coursecategory);
                            this.show_gpa.Items.Add(temp);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("switch error");
                    break;
            }//end of switch
            this.show_gpa.EndUpdate();
        }
    }
}
