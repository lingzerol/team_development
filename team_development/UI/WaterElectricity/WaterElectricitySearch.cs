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
    public partial class WaterElectricitySearch : Form
    {
        public WaterElectricitySearch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //确定进入显示水电费页面
            TurnToForm(new WaterElectricityShow());
        }
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
