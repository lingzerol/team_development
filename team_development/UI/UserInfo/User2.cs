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
    public partial class User2 : Form
    {
        public User2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dlr = MessageBox.Show("您选择了：", "...", btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void User2_Load(object sender, EventArgs e)
        {

        }
    }
}
