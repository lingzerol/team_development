using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_development.Lib;
namespace team_development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CourseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.JWXT, SubMenuType.C_S);
        }


        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.UserInfo);
        }
        public void TurnForm(MenuType MenuId,SubMenuType SubMenu=0)
        {
            TurnForm(MenuGetter.GetMenu(MenuId, SubMenu));
        }
        public void TurnForm(Form PannelForm) {
            PannelForm.TopLevel = false;
            PannelForm.FormBorderStyle = FormBorderStyle.None;
            PannelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1Content.Controls.Clear();
            this.Form1Content.Controls.Add(PannelForm);
            PannelForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbsenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.Absence);
        }

        private void InqueryEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.Query, SubMenuType.Q_Employ);
        }

        private void InqueryInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.Query, SubMenuType.Q_Inform);
        }

        private void InqueryCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.Query, SubMenuType.Q_Cost);
        }

        private void MatchSchemeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TurnForm(MenuType.JWXT, SubMenuType.MatchScheme);
        }
    }
}
