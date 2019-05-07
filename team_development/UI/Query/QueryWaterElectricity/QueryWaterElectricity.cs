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
        public QueryWaterElectricity()
        {
            InitializeComponent();
            
        }

        AutoResetEvent obj = new AutoResetEvent(false);//使用信号量

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://202.116.25.12/login.aspx");         //显示网页

            //使页面加载完毕
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }

            //定义html元素 通过ID获取控件值
            HtmlElement tbUserId = webBrowser1.Document.GetElementById("txtname");
            HtmlElement btnSubmit = webBrowser1.Document.GetElementById("ctl01"); 
 
            try {
                //设置元素value属性值 (用户名 密码值)
                tbUserId.SetAttribute("value", Dorm.Text);
                //执行元素的方法：如click submit
                btnSubmit.InvokeMember("click");
            }
            catch { }
            

            //使页面加载完毕
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }

            //下拉框切换至当前剩余电量
            HtmlElement dropDown = webBrowser1.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_DDL_监控项目");
            try
            {
                dropDown.InvokeMember("click");
            }
            catch { }

            //遍历一下集合获取OuterHtml
            HtmlElementCollection htmlele = webBrowser1.Document.GetElementsByTagName("div");
            foreach (HtmlElement item in htmlele)
            {
                if (item.InnerText == "当前剩余电量")
                {
                    try
                    {
                        item.InvokeMember("click");
                    }
                    catch { }                   
                }
            }
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

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = webBrowser1.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_L_监视屏").InnerText + "度（如果数值不对，请重新点击刷新）";
            }
            catch { }
        }
    }
}
