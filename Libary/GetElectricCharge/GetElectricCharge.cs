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
using Lib;
namespace Lib.GetElectricCharge
{


    public static class GetElectricCharge
    {
        static GetElectricCharge()
        {
        }

        public static double GetCharge(string dormNum)
        {
            return 0;
        }
        public static CookieContainer Login(string dormNum)
        {
            HttpHeader header=new HttpHeader();
            header.accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            header.method = "POST";
            header.userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36";
            header.maxTry = 5;
            header.contentType = "application/x-www-form-urlencoded";
            string data = "__LASTFOCUS=&__VIEWSTATE=%2FwEPDwULLTE5ODQ5MTY3NDlkZM4DISokA1JscbtlCdiUVQMwykIc&__VIEWSTATEGENERATOR=C2EE9ABB&__EVENTTARGET=&__EVENTARGUMENT=&__EVENTVALIDATION=%2FwEWBQLz%2BM6SBQK4tY3uAgLEhISACwKd%2B7q4BwKiwImNC7oxDnFDxrZR6l5WlUJDrpGZXrmN&hidtime=2019-04-26+19%3A53%3A31&txtname=" + dormNum + "&txtpwd=&ctl01=";
            CookieContainer cookieContainer = HTMLHelper.GetCooKie("http://202.116.25.12/login.aspx",data , header);
            return cookieContainer;
        }
    }
}