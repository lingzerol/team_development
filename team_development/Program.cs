using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development
{
    static class Program
    {
        //testdwt 3.22 15:26
        //testlzp 3.19 22:55
        //testwhw 3.19 23:16
        //testHwx 3.20 20:21
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
