﻿using System;
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
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuType.JWXT, SubMenuType.C_S);
            this.Form1Content.Controls.Add(f);
            f.Show();
        }

        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
