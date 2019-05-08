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
using System.Threading;
using Lib.GetElectricCharge;

namespace team_development.UI.QueryWaterElectricity
{
    public partial class QueryWaterElectricity : Form
    {
        AutoResetEvent obj = new AutoResetEvent(false);//使用信号量
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //使页面加载完毕

        public QueryWaterElectricity()
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timerTick);
            timer.Stop();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            GetElectricCharge.Login(Dorm.Text,new Lib.GetElectricCharge.SetElectricity(this.SetElectricity));
            timer.Start();

        }

        private void timerTick(object sender, EventArgs e)
        {
            timer.Stop();
            result.Text=GetElectricCharge.GetElectric();
        }

        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }


        private void SetElectricity(string degree)
        {

        }

        private void QueryWaterElectricity_Load(object sender, EventArgs e)
        {

        }

    }
}
