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

        public void Init()
        {
            Log.log.Info("Receive notifications from official website.");
            Process proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\Get_Notifications.exe";
            //proc.StartInfo.Arguments = username + " " + password;

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

            MessageBox.Show("跑完了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = null;
            thread = new Thread(this.Init);
            thread.Start();

        }
    }
}
