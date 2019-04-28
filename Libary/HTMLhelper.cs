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
        CookieContainer cookies = null;
        string strCookies = string.Empty;
        private static void setDefaultRequest(HttpHeader header, HttpWebRequest request)
        {
            request.Method = header.method;
            request.Accept = header.accept;
            request.UserAgent = header.userAgent;
            request.ContentType = header.contentType;
        }
        //建立会话，并获取验证码
        public Image GetValidateImage(string url,HttpHeader header)
        {
            cookies = new CookieContainer();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = header.accept;
            request.Method = header.method;
            request.UserAgent =header.userAgent;
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

        public string Login(string url,HttpHeader header, CookieContainer cookieContainer, string postData)
        {
            HttpWebRequest request = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            setDefaultRequest(header, request);
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

        public string Post(string url, string postData) {

        }

        public static string GetHtml(string getUrl, CookieContainer cookieContainer, HttpHeader header)
        {
            HttpWebRequest request = null;
            HttpWebResponse httpWebResponse = null;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(getUrl);
                setDefaultRequest(header,request);
                request.CookieContainer = cookieContainer;
                request.ServicePoint.ConnectionLimit = header.maxTry;
                request.Referer = getUrl;

                httpWebResponse = (HttpWebResponse)request.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                request.Abort();
                httpWebResponse.Close();
                return html;
            }
            catch (Exception e)
            {
                if (request != null) request.Abort();
                if (httpWebResponse != null) httpWebResponse.Close();
                return string.Empty;
            }
        }
    }

    public class HttpHeader
    {
        public string contentType { get; set; }

        public string accept { get; set; }

        public string userAgent { get; set; }

        public string method { get; set; }

        public int maxTry { get; set; }

    }
}
