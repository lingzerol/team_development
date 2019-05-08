using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace team_development.UI.QueryWaterElectricity
{
    public partial class QueryWaterElectricity : Form
    {
        Lib.GetElectricCharge.GetElectricCharge elec = new Lib.GetElectricCharge.GetElectricCharge();
        AutoResetEvent obj = new AutoResetEvent(false);//使用信号量

        //使页面加载完毕
        public void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }
        }

        public QueryWaterElectricity()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //显示网页
            webBrowser1.Navigate("http://202.116.25.12/login.aspx");

            //使页面加载完毕
            Wait();

            //登录
            elec.Login(Dorm.Text, webBrowser1);

            Wait();

            //下拉框切换至当前剩余电量
            elec.DropList(webBrowser1);
            
        }

        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;//屏蔽脚本错误
            obj.Set();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text= elec.GetElectric(webBrowser1);
            }
            catch { }
        }
    }
}
