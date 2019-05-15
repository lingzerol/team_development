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

namespace team_development.UI.QueryElectricity
{
    public partial class QueryElectricity : Form
    {
        private GetElectricCharge gec = new GetElectricCharge();

        public QueryElectricity()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            result.Text = gec.GetElectric(Dorm.Text);
        }

        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }


        private void QueryElectricity_Load(object sender, EventArgs e)
        {

        }
    }
}