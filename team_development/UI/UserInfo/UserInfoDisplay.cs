using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace team_development.UI.UserInfo
{
    public partial class UserInfoDisplay : Form
    {
        

        public UserInfoDisplay()
        {
            InitializeComponent();

            UserInfo user=(UserInfo)Storage.Load("UserInfo.xml");
            GlobalData.userInfo = user;
                StudentNumberTextBox.Text = GlobalData.userInfo.StudentNumber;
                StudentNameTextBox.Text = GlobalData.userInfo.StudentName;
                DormNumberTextBox.Text = GlobalData.userInfo.DormNumber;
                MealCardTextBox.Text = GlobalData.userInfo.MealCard;

                Cryptography g = new Cryptography();
                SZJDPasswordTextBox.Text = g.Decrypt(GlobalData.userInfo.SZJDPassword);
                JWXTPasswordTextBox.Text = g.Decrypt(GlobalData.userInfo.JWXTPassword);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ((Form1)this.ParentForm).TurnForm(new UserInfoSetting());
        }

        private void User1_Load(object sender, EventArgs e)
        {

        }

        private void infochange_Click(object sender, EventArgs e)
        {
            Log.log.Info("click infochange");
            UserInfo user = new UserInfo();
            user.StudentNumber = StudentNumberTextBox.Text;
            user.StudentName = StudentNameTextBox.Text;
            user.DormNumber = DormNumberTextBox.Text;
            user.MealCard = MealCardTextBox.Text;
            user.SZJDPassword = SZJDPasswordTextBox.Text;
            user.JWXTPassword = JWXTPasswordTextBox.Text;
            MessageBox.Show("修改成功！");

            Cryptography g = new Cryptography();
            user.SZJDPassword=g.Encryption(user.SZJDPassword);
            user.JWXTPassword=g.Encryption(user.JWXTPassword);

            Storage.Save(user, "UserInfo.xml");
        }
    }
}
