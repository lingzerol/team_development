using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lib.GetJWXT
{


    public class GetJWXT
    {
        WebBrowser web = new WebBrowser();
        System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);


        public GetJWXT()
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Web_DocumentCompleted);
            
        }

        public Bitmap GetValidateImage()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/");

            Wait();

            HtmlElement validateImg = web.Document.Images[1];
            validateImg.Style = "position: absolute; z-index: 9999; top: 0px; left: 0px";
            Bitmap clip = new Bitmap(validateImg.ClientRectangle.Width, validateImg.ClientRectangle.Height);
            web.DrawToBitmap(clip, new Rectangle(new Point(), validateImg.ClientRectangle.Size));
            //validateImageEventHandler(clip);
            return clip;
        }

        public void Login(string username, string pwd, string validate)
        {
            web.Document.GetElementById("txtYHBS").SetAttribute("value", username);
            web.Document.GetElementById("txtYHMM").SetAttribute("value", pwd);
            web.Document.GetElementById("txtFJM").SetAttribute("value", validate);
            web.Document.GetElementById("btnLogin").InvokeMember("click");

            Wait();
            }

        public HtmlDocument GetCourseList()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx");
            Wait();
            return web.Document;
        }

        public HtmlDocument GetGPA()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/Cjgl/Cjgl_Cjcx_WdCj.aspx");
            Wait();

            web.Document.GetElementById("lbtnQuery").InvokeMember("click");
            Wait();

            return web.Document;
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
        public List<Gpa> GetGpaList(string str) {
            List<Gpa> Gpas = new List<Gpa>();
            Regex reg = new Regex(@"<TD>[^<]*</TD>", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            string item;
            int i = 0;
            string a = "";
            string schoolyear = "";
            string semester = "";
            string coursename = "";
            float credit = 0, mark = 0, gp = 0;
            string coursecategory = "";
            foreach (Match m in mc)
            {
                item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                if (!Ru.Equals(""))
                {
                    switch (i)
                    {
                        case 0:
                            schoolyear = Ru;
                            break;
                        case 1:
                            semester = Ru;
                            break;
                        case 2:
                            coursename = Ru;
                            break;
                        case 3:
                            credit = Convert.ToSingle(Ru);
                            break;
                        case 4:
                            mark = Convert.ToSingle(Ru);
                            break;
                        case 5:
                            gp = Convert.ToSingle(Ru);
                            break;
                        case 9:
                            coursecategory = Ru;

                            Gpa gpa = new Gpa(schoolyear, semester, coursename, credit, mark, gp, coursecategory);
                            Gpas.Add(gpa);
                            break;
                    }
                    i++;
                    i = i % 11;

                }
            }
            return Gpas;
        }
    }
}
