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
using System.Drawing;

namespace Lib
{
    public class HTMLHelper
    {
        public const int UTF8 = 1;
        public const int DEFAULT = 2;

        CookieContainer cookies = null;
        string strCookies = string.Empty;

        /// <summary>
        /// 并获取验证码
        /// </summary>
        /// <param name="url">验证码页面的url，如https://jwxt.jnu.edu.cn/ValidateCode.aspx</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public Image GetValidateImage(string url, HttpHeader header)
        {
            cookies = new CookieContainer();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = header.accept;
            request.Method = header.method;
            request.UserAgent = header.userAgent;
            request.CookieContainer = new CookieContainer(); //暂存到新实例
            //MessageBox.Show("response之前：" + request.CookieContainer.GetCookieHeader(request.RequestUri));
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //MessageBox.Show("response之后：" + request.CookieContainer.GetCookieHeader(request.RequestUri));
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

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="url">登陆页面，如https://jwxt.jnu.edu.cn/Login.aspx</param>
        /// <param name="header">请求头</param>
        /// <param name="postData">postdatas</param>
        /// <returns></returns>
        public string Login(string url, HttpHeader header, string postData)
        {
            Boolean setCookie = false;
            HttpWebRequest request = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = header.method;
            request.Accept = header.accept;
            request.UserAgent = header.userAgent;
            request.ContentType = header.contentType;
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;

            if (cookies == null)
            {
                setCookie = true;
                cookies = new CookieContainer();
                request.CookieContainer = new CookieContainer();
            }
            else
            {
                request.CookieContainer = cookies;
            }

            //MessageBox.Show("response之前：" + request.CookieContainer.GetCookieHeader(request.RequestUri));

            if (header.method == "POST")
            {
                //将postdata放入请求
                byte[] postdatabyte = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = postdatabyte.Length;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(postdatabyte, 0, postdatabyte.Length);
                }
            }


            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //账号，密码，验证码输错了会出错
            //MessageBox.Show("response之后：" + request.CookieContainer.GetCookieHeader(request.RequestUri));
            //MessageBox.Show(response.Headers.Get("Set-Cookie"));

            if (setCookie)
            {
                cookies = request.CookieContainer; //将cookies保存到本对象中
                strCookies = request.CookieContainer.GetCookieHeader(request.RequestUri); //字符串格式的cookie
            }

            string strWebData = string.Empty;

            if (header.encoding == HTMLHelper.UTF8)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    strWebData = reader.ReadToEnd();
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
                {
                    strWebData = reader.ReadToEnd();
                }
            }

            response.Close();
            return strWebData;
        }


        /// <summary>
        /// POST请求
        /// </summary>
        /// <param name="url">请求的页面</param>
        /// <param name="header">请求头</param>
        /// <param name="postData">data</param>
        /// <returns></returns>
        public string Post(string url, HttpHeader header, string postData)
        {
            HttpWebRequest request = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";//header.method;
            request.Accept = header.accept;
            request.UserAgent = header.userAgent;
            request.ContentType = header.contentType;
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;

            if (cookies == null)
            {
                return "";
            }
            else
            {
                request.CookieContainer = cookies;
            }

            //将postdata放入请求
            byte[] postdatabyte = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = postdatabyte.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(postdatabyte, 0, postdatabyte.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string strWebData = string.Empty;

            if (header.encoding == HTMLHelper.UTF8)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    strWebData = reader.ReadToEnd();
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
                {
                    strWebData = reader.ReadToEnd();
                }
            }

            response.Close();
            return strWebData;
        }


        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="url">请求的页面</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public string Get(string url, HttpHeader header)
        {
            HttpWebRequest request = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";//header.method;
            request.Accept = header.accept;
            request.UserAgent = header.userAgent;
            request.ContentType = header.contentType;
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;

            if (cookies == null)
            {
                return "";
            }
            else
            {
                request.CookieContainer = cookies;
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string strWebData = string.Empty;

            if (header.encoding == HTMLHelper.UTF8)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    strWebData = reader.ReadToEnd();
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
                {
                    strWebData = reader.ReadToEnd();
                }
            }

            response.Close();
            return strWebData;
        }
    }

    public class HttpHeader
    {
        public HttpHeader()
        {
            method = "POST";
            accept = "*/*;";
            userAgent = "Mozilla/5.0";
            contentType = "application/x-www-form-urlencoded";
            encoding = HTMLHelper.DEFAULT;
        }

        public string contentType { get; set; }

        public string accept { get; set; }

        public string userAgent { get; set; }

        public string method { get; set; }

        public int encoding { get; set; }
    }
}
