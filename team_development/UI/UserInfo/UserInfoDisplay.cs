using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.UserInfo
{
    public partial class UserInfoDisplay : Form
    {
        public UserInfoDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfoSetting f = new UserInfoSetting();
            f.Show();
        }

        private void User1_Load(object sender, EventArgs e)
        {

        }
    }
}
