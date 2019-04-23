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
    public partial class UserInfoSetting : Form
    {
        public UserInfoSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dlr = MessageBox.Show("修改成功！", "通知", btn);
            ((Form1)this.ParentForm).TurnForm(new UserInfoDisplay());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form1)this.ParentForm).TurnForm(new UserInfoDisplay());
        }

        private void User2_Load(object sender, EventArgs e)
        {

        }
    }
}
