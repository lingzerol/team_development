﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.CourseSelection
{
    public partial class CourseSelection : Form
    {
        public CourseSelection()
        {
            InitializeComponent();
            TableLoad();
        }

        private void Course_selection_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“visual_studioDataSet.course”中。您可以根据需要移动或删除它。


        }

        private void QueryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AFLToolStripMenuItem_Click(object sender, EventArgs e)// ask for leave
        {

        }

        private void TimingSelection_Click(object sender, EventArgs e)
        {
            Form ts = new TimeSetting();
            ts.ShowDialog();
        }


        private void CourseInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selection_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dlr = MessageBox.Show("...", "确认选课？", btn);
            if (dlr == DialogResult.OK)
            {
                dlr = MessageBox.Show("...", "已成功选课", btn);
            }
            
        }

        private void TableLoad() {
            this.CourseInfo.GridLines = true;

            this.CourseInfo.View = View.Details;
            this.CourseInfo.Scrollable = true;

            this.CourseInfo.Columns.Add("课程编号", 100, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("课程", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("学分", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("修学", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("类别", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("时间安排", 90, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("教师", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("上课地点", 90, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("备注", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("考试时间", 90, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("阶段", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("状态", 50, HorizontalAlignment.Center);
        }

        private void CourseInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}