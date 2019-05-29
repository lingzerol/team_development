using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.GetNotifications
{
    public class PyNews
    {
        Process proc = new Process();
        Thread thread = null;
        FileStream fs = null;

        public PyNews() {
            thread = new Thread(this.Init);
            thread.Start();
        }

        public void Init()
        {
            Log.log.Info("Receive notifications from official website.");
            proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\GetNotifications\jnu_news.exe";
            //proc.StartInfo.Arguments = username + " " + password;

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();//关键，等待外部程序退出后才能往下执行}
            //Response.Write(output);//输出
            proc.Close();
            //MessageBox.Show("跑完了");
        }
    }
}
