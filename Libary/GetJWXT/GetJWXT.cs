using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetJWXT
{
    public class GetJWXT
    {
        HTMLHelper htmlHelper = new HTMLHelper();

        public Image GetValidateImage()
        {
            HttpHeader header = new HttpHeader();
            header.accept = "*/*";
            header.userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            header.method = "GET";
            return htmlHelper.GetValidateImage("https://jwxt.jnu.edu.cn/ValidateCode.aspx", header);
        }

        public string Login(string username, string pwd, string validate)
        {
            HttpHeader header = new HttpHeader();
            string postData = "__VIEWSTATE=%2FwEPDwUKMjA1ODgwODUwMg9kFgJmD2QWAgIBDw8WAh4EVGV4dAUk5pqo5Y2X5aSn5a2m57u85ZCI5pWZ5Yqh566h55CG57O757ufZGRk9KoyGrj1hrb%2FxZF6g8lZ2QQ9do4%3D&__VIEWSTATEGENERATOR=C2EE9ABB&__EVENTVALIDATION=%2FwEWBwLR44D1DQKDnbD2DALVp9zJDAKi%2B6bHDgKC3IeGDAKt86PwBQLv3aq9B47pXW7QJikyEA9%2B7Kos193HV3sp&" +
                "txtYHBS=" + username +
                "&txtYHMM=" + pwd +
                "&txtFJM=" + validate +
                "&btnLogin=%B5%C7++++%C2%BC";
            return htmlHelper.Login("https://jwxt.jnu.edu.cn/Login.aspx", header, postData);
        }


        /// <summary>
        /// 所选课程
        /// </summary>
        /// <returns></returns>
        public string GetCourseList()
        {
            HttpHeader httpHeader = new HttpHeader();
            return htmlHelper.Get("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx", httpHeader);

        }


        /// <summary>
        /// 培养方案
        /// </summary>
        /// <returns></returns>
        public string GetMatchScheme()
        {
            HttpHeader httpHeader = new HttpHeader();
            return htmlHelper.Get("https://jwxt.jnu.edu.cn/default.aspx", httpHeader);
        }
    }
}
