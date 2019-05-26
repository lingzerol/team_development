﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lib
{
    public class PyNotifications
    {
        Process proc = new Process();
        Thread thread = null;
        FileStream fs = null;

        public PyNotifications()
        {
            thread = new Thread(this.Init);
            thread.Start();
        }

        public void Init()
        {
            Log.log.Info("Receive notifications from official website.");
            proc = new Process();
            proc.StartInfo.FileName = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\GetNotifications\Get_Notifications.exe";
            //proc.StartInfo.Arguments = username + " " + password;

            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardInput = true;

            proc.StartInfo.RedirectStandardOutput = true;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

        }
    }
}