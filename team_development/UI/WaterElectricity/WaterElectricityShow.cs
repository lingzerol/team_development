using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.WaterElectricity
{
    public partial class WaterElectricityShow : Form
    {
        public WaterElectricityShow()
        {
            InitializeComponent();
        }
        
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            //返回查询水电费页面
            TurnToForm(new WaterElectricitySearch());
        }
    }
}
