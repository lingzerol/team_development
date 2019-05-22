using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Lib.GetElectricCharge;
using team_development.UI.UserInfo;
using Lib;
using team_development.UI;

namespace team_development
{
    static class Program
    {        
        //testwhw
        //testlzp
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //GetElectricCharge.Login("3307");
            UserInfo user = (UserInfo)Storage.Load("UserInfo.xml");
            GlobalData.userInfo = user; 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalData.userInfo = user;
            Application.Run(new ValidateForm());
            //Application.Run(new TestForm());
        }
        
    }
}


