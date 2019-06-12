using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public class PyNotifications
    {
        
        Thread thread = null;
        FileStream fs = null;

        public PyNotifications()
        {
        }
        private Process getProcess(string file) {
            Process proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\GetNotifications\"+file;
            //proc.StartInfo.Arguments = username + " " + password;

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            return proc;
        }
        public void Init()
        {
            Log.log.Info("Receive notifications from official website.");
            Process proc = getProcess("Get_Notifications.exe");
            Process inform_proc = getProcess("inform.exe");
            Process sino_proc = getProcess("sina.exe");
            proc.Start();
            inform_proc.Start();
            sino_proc.Start();

            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();//关键，等待外部程序退出后才能往下执行}
            //Response.Write(output);//输出
            proc.Close();
            //MessageBox.Show("跑完了");
            inform_proc.WaitForExit();
            inform_proc.Close();
            sino_proc.WaitForExit();
            sino_proc.Close();
        }
    }
}
