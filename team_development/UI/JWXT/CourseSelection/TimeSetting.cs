using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Lib;
namespace team_development.UI.CourseSelection
{
    public partial class TimeSetting : Form
    {
        private Timer timer = new Timer();
        public TimeSetting()
        {
            Log.log.Info("LOADING form TimeSetting.");
            InitializeComponent();
            
            timer.Tick += timer1_Tick_1;
            timer.Interval = 1000;
            timer.Stop();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click OKButton in TimeSetting Form.");
            DateTime timeend = Convert.ToDateTime(EndTime.Text);
            TimeSpan ts = timeend.Subtract(DateTime.Now).Duration();
            label3.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";
            timer.Start();

        }

        private void TimeSetting_Load(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.ToString();
            EndTime.Text = "2019/5/25 20:00:00";           
            TimeNow.ReadOnly = true;
            timer1.Enabled = true;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click CancelButton in TimeSetting Form.");
            timer.Stop();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            this.timer1.Interval = 5000;
            //this.timer1.Start();//计时器开始运行
            DateTime timeend = Convert.ToDateTime(EndTime.Text);
            TimeSpan ts = timeend.Subtract(DateTime.Now).Duration();
            TimeNow.Text = DateTime.Now.ToString();
            label3.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";
            if (timeend<=DateTime.Now)
            {
                MessageBox.Show("选课成功");
                this.Close();
            }
        }
    }
}
