﻿using mshtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public class Geticas
    {
        private WebBrowser web = new WebBrowser();
        private System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);
        private System.Threading.AutoResetEvent statusObj = new System.Threading.AutoResetEvent(false);
        private bool isGetInto = false;

        public Geticas(){
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebDocumentCompleted);
            web.ScriptErrorsSuppressed = true;
            web.Navigated += new WebBrowserNavigatedEventHandler(NavigatedEventHandler);
            statusObj.Set();
        }
        private void Wait()
            {
                obj.Reset();
                while (obj.WaitOne(10, false) == false)
                {
                    Application.DoEvents();
                }
            }
        public void SetStatus(bool status)
        {
            statusObj.WaitOne();
            isGetInto = status;
            statusObj.Set();
        }
        private void NavigatedEventHandler(object sender, WebBrowserNavigatedEventArgs e)
        {
            IHTMLWindow2 win = (IHTMLWindow2)web.Document.Window.DomWindow;
            string s = "window.alert = null;";
            win.execScript(s, "javascript");
            if (e.Url.AbsolutePath == "/areaTopLogo.aspx")
                SetStatus(true);
            else
                Log.log.Error("Get a null object from e.Url.AbsolutePath");
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
        public HtmlDocument Login(string username, string pwd)
            {
            string url = "https://icas.jnu.edu.cn/cas/login?service=http%3A%2F%2Fi.jnu.edu.cn%2Fdcp%2Findex.jsp";
            web.Navigate(url);
            Wait();
            web.Document.GetElementById("un").SetAttribute("value", username);
            web.Document.GetElementById("pd").SetAttribute("value", pwd);
            web.Document.GetElementById("index_login_btn").InvokeMember("click");
            Wait();
            string cookieStr = web.Document.Cookie;
            //string[] cookstr = cookieStr.Split(';');
            foreach (string c in cookieStr.Split(';'))
            {
                string[] item = c.Split('=');
                if (item.Length == 2)
                {
                    InternetSetCookie(url, null, new Cookie(System.Web.HttpUtility.UrlEncode(item[0]).Replace("+", ""), System.Web.HttpUtility.UrlEncode(item[1]), "; expires = Session GMT", "/").ToString());
                }
            }//end of for
            web.Navigate(url);

            Wait();
            MessageBox.Show(cookieStr);
            //Wait();

            return web.Document;
        }

        private void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
            web.ScriptErrorsSuppressed = true;
        }
    }
}