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
<<<<<<< HEAD

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuType.UserInfo);
=======
        private void TurnForm(MenuType MenuId,SubMenuType SubMenu)
        {
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuId,SubMenu);
>>>>>>> b95d75f59fe20d26029a7d4f4b81f54109d7cdb5
            this.Form1Content.Controls.Add(f);
            f.Show();
        }
    }
}
