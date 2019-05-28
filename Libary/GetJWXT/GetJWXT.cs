using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Lib;
using mshtml;

namespace Lib.GetJWXT
{
    public class GetJWXT
    {

        public static GetJWXT jwxt = new GetJWXT();
        private WebBrowser web = new WebBrowser();
        public System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);
        private bool isNavigate = false;
        private bool isGetInto = false;
        private System.Threading.AutoResetEvent statusObj = new System.Threading.AutoResetEvent(false);

        public bool GetStatus()
        {
            bool result = false;
            statusObj.WaitOne();
            result = isGetInto;
            statusObj.Set();
            return result;
        }
        public void SetStatus(bool status)
        {
            statusObj.WaitOne();
            isGetInto = status;
            statusObj.Set();
        }

        public GetJWXT()
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebDocumentCompleted);
            web.ScriptErrorsSuppressed = true;
            web.Navigated += new WebBrowserNavigatedEventHandler(NavigatedEventHandler);
            statusObj.Set();
        }

        private void OnWebBrowserDocumentWindowError(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }



        private void NavigatedEventHandler(object sender, WebBrowserNavigatedEventArgs e)
        {
            IHTMLWindow2 win = (IHTMLWindow2)web.Document.Window.DomWindow;
            string s = "window.alert = null;\r\nwindow.confirm = null;\r\nwindow.open = null;\r\nwindow.showModalDialog = null;";
            win.execScript(s, "javascript");
            if (e.Url.AbsolutePath == "/areaTopLogo.aspx")
                SetStatus(true);
            else
                Log.log.Error("Get a null object from e.Url.AbsolutePath");
        }

        public Bitmap GetValidateImage()
        {
            //if (!isNavigate)
            // {
            //isGetInto = false;
            HtmlDocument document = web.Document;
            if (document != null)
            {
                document.ExecCommand("ClearAuthenticationCache", false, null);
            }
            
            web.Navigate("https://jwxt.jnu.edu.cn");
            Wait();
            isNavigate = true;
            //}

            Bitmap clip = null;
            try
            {
                HtmlElement validateImg = web.Document.Images[1];
                validateImg.Style = "position: absolute; z-index: 9999; top: 0px; left: 0px";
                clip = new Bitmap(validateImg.ClientRectangle.Width, validateImg.ClientRectangle.Height);
                web.DrawToBitmap(clip, new Rectangle(new Point(), validateImg.ClientRectangle.Size));
                //validateImageEventHandler(clip);
               
            }
            catch (Exception e)
            {
                MessageBox.Show("登陆失败");
            }
            return clip;
        }

        public bool Login(string username, string pwd,string validate)
        {
            //string validate = OCR.GetValidateCode(GetValidateImage());            
            web.Document.GetElementById("txtYHBS").SetAttribute("value", username);
            web.Document.GetElementById("txtYHMM").SetAttribute("value", pwd);
            web.Document.GetElementById("txtFJM").SetAttribute("value", validate);
            web.Document.GetElementById("btnLogin").InvokeMember("click");
            
            Wait();
            return isGetInto;
        }

        public HtmlDocument GetCourseList()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx");
            Wait();
            return web.Document;
        }

        public HtmlDocument SelectCourse()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Pk_RlRscx.aspx");
            Wait();
            web.Document.GetElementById("dlstKclb").SetAttribute("value", "122");
            web.Document.GetElementById("dlstXqu").SetAttribute("value", "珠海校区");
            web.Document.GetElementById("lbtnSearch").InvokeMember("click");
            Wait();

            return web.Document;
        }

        public HtmlDocument GetGPA()
        {
            try
            {
                web.Navigate("https://jwxt.jnu.edu.cn/Secure/Cjgl/Cjgl_Cjcx_WdCj.aspx");
                Wait();
                web.Document.GetElementById("lbtnQuery").InvokeMember("click");
                Wait();
            }
            catch (Exception)
            {
                Log.log.Error("Capture GPA Error,Please check your password.");
            }
            return web.Document;
        }

        public HtmlDocument GetMatchScheme()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/default.aspx");
            Wait();
            return web.Document;
        }

        private void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
            web.ScriptErrorsSuppressed = true;
            this.web.Document.Window.Error += OnWebBrowserDocumentWindowError;
        }

        private void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }
            
        }

        public MatchSchemeItem GetMatchSchemeItem(string str)
        {

            List<string> needs = new List<string>();
            List<string> study = new List<string>();
            List<string> lefts = new List<string>();

            Regex reg = new Regex(@"<TD class=needs>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                needs.Add(Ru);
            }

            reg = new Regex(@"<TD class=study>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                study.Add(Ru);
            }

            reg = new Regex(@"<TD class=lefts>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                lefts.Add(Ru);
            }

            MatchSchemeItem matchSchemeItem = new MatchSchemeItem(needs, study, lefts);
            return matchSchemeItem;
            
        }

        public List<Gpa> GetGpaList(string str)
        {
            List<Gpa> Gpas = new List<Gpa>();         
            Regex reg = new Regex(@"<td>[^<]*</td>", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            string item;
            int i = 0;
            string a = "";
            string schoolyear = "";
            string coursecode = "";
            string coursename = "";
            float credit = 0, mark = 0, gp = 0;
            string coursecategory = "";
            string itemlist = "";
            foreach (Match m in mc)
            {
                item = m.Value;
                Console.WriteLine(item);
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</td>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1).Trim();
                string rex = "[1-9][0-9][0-9][0-9]";
                if(Ru!= "&nbsp;"&&Ru!= "----"&&Ru!= "--------"&&Ru!= "------------------------------------------------")
                {
                    if (Regex.Match(Ru, rex).ToString() != "" && IsChina(Ru))
                          schoolyear = Ru;
                       // itemlist += Ru+"\n";
                    else
                    {
                        if (i != 0 || IsNumeric(Ru))
                        {
                            switch (i)
                            {
                                case 0:
                                    coursecode = Ru;

                                    break;
                                case 1:
                                    coursename = Ru;
                                    break;
                                case 2:
                                    coursecategory = Ru;
                                    break;
                                case 3:
                                    mark = Convert.ToSingle(Ru);
                                    break;
                                case 4:
                                    credit = Convert.ToSingle(Ru);
                                    break;
                                case 5:
                                    gp = Convert.ToSingle(Ru);
                                      Gpa gpa = new Gpa(schoolyear, coursecode, coursename, credit, mark, gp, coursecategory);
                                      Gpas.Add(gpa);
                                      
                                    break;
                            }
                            i++;
                            i = i % 6;
                            itemlist += Ru+"\n";
                        }
                    }
                }
                
            }
          //  MessageBox.Show(itemlist);
            return Gpas;
        }
        private static bool IsNumeric(string str) //接收一个string类型的参数,保存到str里
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空
                return false;                           //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里

            foreach (byte c in bytestr)                   //遍历这个数组里的内容
            {
                if (c < 48 || c > 57)                          //判断是否为数字
                {
                    return false;                              //不是，就返回False
                }
            }
            return true;                                        //是，就返回True
        }

        
        public bool IsChina(string CString)  //判断是否含有中文
        {
            bool BoolValue = false;
            for (int i = 0; i < CString.Length; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(CString.Substring(i, 1))) > Convert.ToInt32(Convert.ToChar(128)))
                {
                    BoolValue = true;
                }

            }
            return BoolValue;
        }
    }



    
}
