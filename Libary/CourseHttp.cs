using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class CourseHttp
    {
        CookieContainer cookies = null;
        string strCookies = string.Empty;

        //建立会话，并获取验证码
        public Image GetValidateImage(string url)
        {
            //string url = "https://jwxt.jnu.edu.cn/ValidateCode.aspx";  //验证码页面
            cookies = new CookieContainer();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "*/*";
            request.Method = "GET";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            request.CookieContainer = new CookieContainer(); //暂存到新实例
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //获取图片
            MemoryStream ms = null;
            using (var stream = response.GetResponseStream())
            {
                Byte[] buffer = new Byte[response.ContentLength];
                int offset = 0, actuallyRead = 0;
                do
                {
                    actuallyRead = stream.Read(buffer, offset, buffer.Length - offset);
                    offset += actuallyRead;
                }
                while (actuallyRead > 0);
                ms = new MemoryStream(buffer);
            }
            response.Close();

            cookies = request.CookieContainer; //保存cookies
            strCookies = request.CookieContainer.GetCookieHeader(request.RequestUri); //把cookies转换成字符串

            //转为Image
            Image img = new Bitmap(ms);
            return img;
        }

        public string Login(string url, CookieContainer cookieContainer, string postData)
        {
            //string url = "https://jwxt.jnu.edu.cn/Login.aspx";   //登录页面
            HttpWebRequest request = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            request.Accept = "*/*;";
            request.UserAgent = "Mozilla/5.0";
            request.ContentType = "application/x-www-form-urlencoded";
            request.AllowAutoRedirect = true;
            request.CookieContainer = cookieContainer;
            request.KeepAlive = true;

            //string postData = string.Format("username={0}&password={1}&Validate={2}&isautologin=1&Submit=", txtUserName.Text, txtPassword.Text, txtValidate.Text);  //这里按照前面FireBug中查到的POST字符串做相应修改。

            //将postdata放入请求
            byte[] postdatabyte = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = postdatabyte.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(postdatabyte, 0, postdatabyte.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //账号，密码，验证码输错了会出错

            string strWebData = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
            {
                strWebData = reader.ReadToEnd();
            }
            response.Close();
            return strWebData;
        }

        public string GetHtml(string url, string postData)
        {
            return Login(url, cookies, ""); //带着cookie即可保持登陆状态
        }

        public string GetCourseList(string username, string pwd, string validate)
        {
            string postData = "__VIEWSTATE=%2FwEPDwUKMjA1ODgwODUwMg9kFgJmD2QWAgIBDw8WAh4EVGV4dAUk5pqo5Y2X5aSn5a2m57u85ZCI5pWZ5Yqh566h55CG57O757ufZGRk9KoyGrj1hrb%2FxZF6g8lZ2QQ9do4%3D&__VIEWSTATEGENERATOR=C2EE9ABB&__EVENTVALIDATION=%2FwEWBwLR44D1DQKDnbD2DALVp9zJDAKi%2B6bHDgKC3IeGDAKt86PwBQLv3aq9B47pXW7QJikyEA9%2B7Kos193HV3sp&" +
                "txtYHBS=" + username +
                "&txtYHMM=" + pwd +
                "&txtFJM=" + validate +
                "&btnLogin=%B5%C7++++%C2%BC";
            Login("https://jwxt.jnu.edu.cn/Login.aspx", cookies, postData);  //登陆，得先获取验证码建立会话
            String str = GetHtml("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx", "");  //所选的全部课程，这里不需要postData
            return str;
        }

    }
}

//例子
//CourseHttp courseHttp = new CourseHttp();
//private void button2_Click(object sender, EventArgs e)
//{
//    this.pictureBox1.Image = courseHttp.GetValidateImage("https://jwxt.jnu.edu.cn/ValidateCode.aspx");
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    txt_content.Text = courseHttp.GetCourseList(name.Text, pwd.Text, Expwd.Text);
//}
