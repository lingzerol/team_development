using mshtml;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public HtmlDocument Login(string username, string pwd)
            {
            web.Navigate("https://icas.jnu.edu.cn/cas/login?service=http%3A%2F%2Fi.jnu.edu.cn%2Fdcp%2Findex.jsp");
            Wait();
            web.Document.GetElementById("un").SetAttribute("value", username);
            web.Document.GetElementById("pd").SetAttribute("value", pwd);
            web.Document.GetElementById("index_login_btn").InvokeMember("click");
            MessageBox.Show("click");
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