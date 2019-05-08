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


        public void Login(string username, WebBrowser web)
        {
            //定义html元素 通过ID获取控件值
            HtmlElement tbUserId = web.Document.GetElementById("txtname");
            HtmlElement btnSubmit = web.Document.GetElementById("ctl01");

            try
            {
                //设置元素value属性值 (用户名 密码值)
                tbUserId.SetAttribute("value", username);
                //执行元素的方法：如click submit
                btnSubmit.InvokeMember("click");
            }
            catch { }
        }

        public void DropList(WebBrowser web)
        { 
            //下拉框切换至当前剩余电量
            HtmlElement dropList = web.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_DDL_监控项目");
            try
            {
                dropList.InvokeMember("click");
            }
            catch { }

            //遍历一下集合获取OuterHtml
            HtmlElementCollection htmlele = web.Document.GetElementsByTagName("div");
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
        
        public string GetElectric(WebBrowser web)
        {
            string Text = web.Document.GetElementById("RegionPanel1_Region2_GroupPanel1_ContentPanel1_L_监视屏").InnerText + "度";
            return Text;
        }
    }
}