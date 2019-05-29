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
        Timer timer = new Timer();
        public TimeSetting()
        {
            Log.log.Info("LOADING form TimeSetting.");
            InitializeComponent();

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;

                //timer.Tick += Timer1_Tick_1;
                timer.Interval = 1000;
                Log.log.Info("Click OKButton in TimeSetting Form.");

                DateTime timeend = Convert.ToDateTime(EndTime.Text);
                TimeSpan ts = timeend.Subtract(DateTime.Now).Duration();
                label3.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";
                timer.Start();
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("时间输入有误，请重新输入！");
                return;
            }
        }

        private void TimeSetting_Load(object sender, EventArgs e)
        {
            EndTime.Text = "2019/6/15 20:00:00";           
            timer1.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click CancelButton in TimeSetting Form.");
            timer.Stop();
            this.Close();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {

            //this.timer1.Start();//计时器开始运行
            try
            {
                DateTime timeend = Convert.ToDateTime(EndTime.Text);
                TimeSpan ts = timeend.Subtract(DateTime.Now).Duration();
                label3.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";
                if (timeend <= DateTime.Now)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("选课成功");
                    this.Close();
                }
            }
            catch
            {
                
            
        }
            finally
            {
            }
            
        }
    }
}
