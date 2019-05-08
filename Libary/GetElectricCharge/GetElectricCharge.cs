using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Collections.Specialized;
using Lib;
using System.Windows.Forms;
using System.Threading;

namespace Lib.GetElectricCharge
{

    public class GetElectricCharge
    {

        private WebBrowser webBrowser = new WebBrowser();
        private System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);
        public GetElectricCharge() {
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowserDocumentCompleted);
        }
        public void Login(string username)
        {
            //定义html元素 通过ID获取控件值
            webBrowser.Navigate("http://202.116.25.12/login.aspx");
            Wait();
            HtmlElement tbUserId = webBrowser.Document.GetElementById("txtname");
            HtmlElement btnSubmit = webBrowser.Document.GetElementById("ctl01");
            try
            {
                //设置元素value属性值 (用户名 密码值)
                tbUserId.SetAttribute("value", username);
                //执行元素的方法：如click submit
                btnSubmit.InvokeMember("click");
            }
            catch {
                //set error handling
            }
            DropList();
        }

        public void DropList()
        {
            //下拉框切换至当前剩余电量
            Wait();
            HtmlElement dropList = webBrowser.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_DDL_监控项目");
            try
            {
                dropList.InvokeMember("click");
            }
            catch { }

            //遍历一下集合获取OuterHtml
            HtmlElementCollection htmlele = webBrowser.Document.GetElementsByTagName("div");
            foreach (HtmlElement item in htmlele)
            {
                if (item.InnerText == "当前剩余电量")
                {
                    try
                    {
                        item.InvokeMember("click");
                    }
                    catch {
                    }
                    break;
                }
            }
        }
        
        public string GetElectric()
        {
            string Text = webBrowser.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_L_监视屏").InnerText + "度";
            return Text;
        }

        public void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;//屏蔽脚本错误
            obj.Set();
        }

        public void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }
        }
    }
}