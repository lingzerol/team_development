using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Process proc = new Process();
        }

        public object Response { get; private set; }

        public void Init(string url)
        {
            Log.log.Info("Receive notifications from official website.");
            Process proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\GetNotifications\Get_Article.exe";
            proc.StartInfo.Arguments = url;

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
            MessageBox.Show("跑完了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://zh.jnu.edu.cn/df/0d/c8379a319245/page.htm";
            Thread thread = null;
            //thread = new Thread(Init(url));
            thread.Start();

        }
    }
}
