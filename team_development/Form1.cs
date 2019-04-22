using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
              this.Form1Content.Controls.Clear();
              Form f = MenuGetter.GetMenu(MenuType.JWXT, SubMenuType.C_S);
              this.Form1Content.Controls.Add(f);
              f.Show();
              
           
        }




        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QueryEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Employ);
            this.Form1Content.Controls.Add(f);
            f.Show();
     
        }

        private void QueryInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Inform);
            this.Form1Content.Controls.Add(f);
            f.Show();
        }
        public void ChangeFomr1Content(Form F)
        {

            this.Form1Content.Controls.Clear();
            this.Form1Content.Controls.Add(F);
            F.Show();
        }


    }
}
