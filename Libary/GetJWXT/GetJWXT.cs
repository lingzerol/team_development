using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.GetJWXT
{
    public delegate void ValidateImageEventHandler(Bitmap bitmap);
    public delegate void HTMLEventHandler(string html);

    public class GetJWXT
    {
        WebBrowser web = new WebBrowser();
        System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);

        ValidateImageEventHandler validateImageEventHandler;
        HTMLEventHandler htmlEventHandler;

        public GetJWXT(ValidateImageEventHandler validateImageEventHandler, HTMLEventHandler htmlEventHandler)
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Web_DocumentCompleted);
            this.validateImageEventHandler = validateImageEventHandler;
            this.htmlEventHandler = htmlEventHandler;
        }


        public void GetValidateImage()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/");

            Wait();

            HtmlElement validateImg = web.Document.Images[1];
            validateImg.Style = "position: absolute; z-index: 9999; top: 0px; left: 0px";
            Bitmap clip = new Bitmap(validateImg.ClientRectangle.Width, validateImg.ClientRectangle.Height);
            web.DrawToBitmap(clip, new Rectangle(new Point(), validateImg.ClientRectangle.Size));
            validateImageEventHandler(clip);
        }

        public void Login(string username, string pwd, string validate)
        {
            web.Document.GetElementById("txtYHBS").SetAttribute("value", username);
            web.Document.GetElementById("txtYHMM").SetAttribute("value", pwd);
            web.Document.GetElementById("txtFJM").SetAttribute("value", validate);
            web.Document.GetElementById("btnLogin").InvokeMember("click");

            Wait();
        }

        public void GetCourseList()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx");
            Wait();
            htmlEventHandler(web.Document.Body.InnerHtml);
        }

        public void GetGPA()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/Cjgl/Cjgl_Cjcx_WdCj.aspx");
            Wait();

            web.Document.GetElementById("lbtnQuery").InvokeMember("click");
            Wait();

            htmlEventHandler(web.Document.Body.InnerHtml);
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
        }

        private void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            { Application.DoEvents(); }
        }
    }
}
