using Lib.GetJWXT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_developmentTests
{
    public partial class Form2 : Form
    {
        public string validatetext="";
        public Form2()
        {
            InitializeComponent();
            GetJWXT jwtx = new GetJWXT();
            validatetest.Image = jwtx.GetValidateImage();

            
        }

        private void validatetest_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validatetext = validatetexttest.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
