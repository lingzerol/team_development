using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        Lib.GetJWXT.GetJWXT getJWXT= new Lib.GetJWXT.GetJWXT();
        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = getJWXT.GetValidateImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getJWXT.Login(username.Text, pwd.Text, validate.Text);
            content.Text = getJWXT.GetMatchScheme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HttpHeader header = new HttpHeader();
            header.accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";
            header.contentType = "application/x-www-form-urlencoded";
            header.method = "POST";
            header.userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
            header.encoding = HTMLHelper.UTF8;
            HTMLHelper helper = new HTMLHelper();
            string data = "email=13680332197&icode=&origURL=http%3A%2F%2Fwww.renren.com%2Fhome&domain=renren.com&key_id=1&captcha_type=web_login&password=99fe9c53d03011474f8894566c2d3e793a95ec6a59fed21ec7236ba004db2f8c&rkey=553c71cba52ca648be9e47d3eab3dce5&f=http%253A%252F%252Fwww.renren.com%252F970594843";
            helper.Login("http://www.renren.com/PLogin.do", header, data);

            content.Text = helper.Get("http://www.renren.com/970594843", header);
        }
    }
}
