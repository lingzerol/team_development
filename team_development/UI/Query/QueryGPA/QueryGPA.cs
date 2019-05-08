using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.QueryGPA
{
    public partial class QueryMark : Form
    {
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

            this.show_gpa.Columns.Add("课程代码", 90, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程名称", 120, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程绩点", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程状态", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程类别", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学分", 80, HorizontalAlignment.Center);

        }

        private void GpaInquiry_Load(object sender, EventArgs e)
        {

        }

        private void Show_gpa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void student_id_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
