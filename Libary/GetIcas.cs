using mshtml;
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
        string url = "https://icas.jnu.edu.cn/cas/login";

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
            web.Navigate(url);
            Wait();
            web.Document.GetElementById("un").SetAttribute("value", username);
            web.Document.GetElementById("pd").SetAttribute("value", pwd);
            web.Document.GetElementById("index_login_btn").InvokeMember("click");
            //MessageBox.Show("click");
            Wait();
            return web.Document;
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public const int WM_CLOSE = 0x10;

        private void StartKiller()
        {
            Timer timer = new Timer();
            timer.Interval = 3000; //3秒启动 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            KillMessageBox();
            //停止Timer 
            ((Timer)sender).Stop();
        }

        private void KillMessageBox()
        {
            //按照MessageBox的标题，找到MessageBox的窗口 
            IntPtr ptr = FindWindow(null, "MessageBox");
            if (ptr != IntPtr.Zero)
            {
                //找到则关闭MessageBox窗口 
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }
        public String Query() {
            string cookieStr = web.Document.Cookie;
            foreach (string c in cookieStr.Split(';'))
            {
                string[] item = c.Split('=');
                if (item.Length == 2)
                {
                    InternetSetCookie(url, null, new Cookie(System.Web.HttpUtility.UrlEncode(item[0]).Replace("+", ""), System.Web.HttpUtility.UrlEncode(item[1]), "; expires = Session GMT", "/").ToString());
                }
            }//end of for
            web.Navigate("https://i.jnu.edu.cn/dcp/forward.action?path=/portal/portal&p=home");

            StartKiller();
            //MessageBox.Show("获取的Cookie为"+cookieStr, "MessageBox");
            MessageBox.Show("请稍等", "MessageBox");
            //StartKiller();

            String  str = web.Document.Body.InnerHtml;
            //web.Navigate(url);
            
            
            return str;
            //return web.Document;
        }

        private void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
            web.ScriptErrorsSuppressed = true;
        }
    }
}