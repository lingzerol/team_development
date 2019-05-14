using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.GetJWXT;

namespace team_development.UI.JWXT
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MatchSchemeItem matchSchemeItem = Lib.GetJWXT.GetJWXT.jwxt.GetMatchSchemeItem(Lib.GetJWXT.GetJWXT.jwxt.GetMatchScheme().Body.InnerHtml);
            
        }
    }
}
