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

namespace team_development.UI.JWXT
{
    public delegate void Refresh();
    public partial class JwxtLogin : Form
    {
        private PyJWXT pyJwxt = null;
        private Refresh refresh;

        public JwxtLogin(string username, string password, Refresh refresh)
        {
            InitializeComponent();
            this.refresh = refresh;
            pyJwxt = new PyJWXT(username, password, ValidateImage);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (!pyJwxt.GetAll(getValidate.Text)){
                pyJwxt.Retry();
            } else
            {
                refresh();
                this.Close();
                
            }
            
        }

        private void ValidateImage_Click(object sender, EventArgs e)
        {
            pyJwxt.Retry();
        }

        private void JwxtLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            JwxtSingleton.SetNull();
        }
    }
}
