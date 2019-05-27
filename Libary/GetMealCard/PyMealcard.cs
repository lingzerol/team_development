using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.GetMealCard
{
    public class PyMealcard
    {
        private string username;
        private string password;
        PictureBox validateBox = null;
        Process proc = new Process();
        public string code;
        Thread thread = null;
        FileStream fs = null;

        public PyMealcard(string username, string password)
        {
            this.username = username;
            this.password = password;
            //this.validateBox = validateBox;
            thread = new Thread(this.Init);
            thread.Start();
        }

        public void Init()
        {
            Log.log.Info("Receive the mealcard data from the shuzijida website.");
            proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\GetMealCard\mealcard.exe";
            proc.StartInfo.Arguments = username + " " + password;

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            code = "";
            code = proc.StandardOutput.ReadLine();

            if (code != null && code.Equals("1001"))
            {
                fs = File.OpenRead(System.AppContext.BaseDirectory + @"\valcode.png"); //OpenRead
                int filelength = 0;
                filelength = (int)fs.Length; //获得文件长度 
                Byte[] image = new Byte[filelength]; //建立一个字节数组 
                fs.Read(image, 0, filelength); //按字节流读取 
                System.Drawing.Image result = System.Drawing.Image.FromStream(fs);
                validateBox.Image = result;
            }
            else if (code == null)
            {
                MessageBox.Show("请检查你的网络");
            }
            else
            {
                MessageBox.Show("获取验证码失败");
            }

        }

        public void Retry()
        {
            if (fs != null)
            {
                fs.Close();
            }
            try
            {
                proc.StandardInput.WriteLine("-1");
                proc.WaitForExit();
                proc.Close();
                thread.Abort();
                thread = new Thread(this.Init);
                thread.Start();
            }
            catch (System.InvalidOperationException e)
            {
                MessageBox.Show("你点的太快了~~");
            }
        }

        public string GetAll(string validate)
        {
            if (code.Equals("1001"))
            {
                proc.StandardInput.WriteLine(validate);
                code = proc.StandardOutput.ReadLine();
                if (code.Equals("101"))
                {
                    code = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();
                    proc.Close();
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("验证码错误，请重试");
                    Retry();
                }
                return code;
            }
            else
            {
                return code;
            }
        }


    }
}
