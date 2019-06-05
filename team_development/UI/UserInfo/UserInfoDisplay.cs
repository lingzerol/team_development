using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using team_development.FormLib;

namespace team_development.UI.UserInfo
{
    public partial class UserInfoDisplay : Form
    {
        

        public UserInfoDisplay()
        {
            InitializeComponent();
            if (File.Exists("UserInfo.xml"))
            {
                UserInfo user = (UserInfo)Storage.Load("UserInfo.xml");
                GlobalData.userInfo = user;
                StudentNumberTextBox.Text = GlobalData.userInfo.StudentNumber;
                StudentNameTextBox.Text = GlobalData.userInfo.StudentName;
                DormNumberTextBox.Text = GlobalData.userInfo.DormNumber;
                Cryptography g = new Cryptography();
                SZJDPasswordTextBox.Text = g.Decrypt(GlobalData.userInfo.SZJDPassword);
                JWXTPasswordTextBox.Text = g.Decrypt(GlobalData.userInfo.JWXTPassword);
                switch (GlobalData.userInfo.College)
                {
                    case 0:
                        radioButton_cahs.Checked = true;
                        break;
                    case 1:
                        radioButton_translate.Checked = true;
                        break;
                    case 2:
                        radioButton_nb.Checked = true;
                        break;
                    case 3:
                        radioButton_it.Checked = true;
                        break;
                    case 4:
                        radioButton_ele.Checked = true;
                        break;
                    case 5:
                        radioButton_pack.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ((Form1)this.ParentForm).TurnForm(new UserInfoSetting());
        }

        private void User1_Load(object sender, EventArgs e)
        {

        }

        private void Save() {
            Log.log.Info("Click infochange");
            Log.log.Info("Save UserInfo ");

            GlobalData.userInfo.StudentNumber = StudentNumberTextBox.Text;
            GlobalData.userInfo.StudentName = StudentNameTextBox.Text;
            GlobalData.userInfo.DormNumber = DormNumberTextBox.Text;
            GlobalData.userInfo.SZJDPassword = SZJDPasswordTextBox.Text;
            GlobalData.userInfo.JWXTPassword = JWXTPasswordTextBox.Text;

            if (radioButton_cahs.Checked)
            {
                GlobalData.userInfo.College = 0;
            }
            else if (radioButton_translate.Checked)
            {
                GlobalData.userInfo.College = 1;
            }
            else if (radioButton_nb.Checked)
            {
                GlobalData.userInfo.College = 2;
            }
            else if (radioButton_it.Checked)
            {
                GlobalData.userInfo.College = 3;
            }
            else if (radioButton_ele.Checked)
            {
                GlobalData.userInfo.College = 4;
            }
            else if (radioButton_pack.Checked)
            {
                GlobalData.userInfo.College = 5;
            }
            else {
                GlobalData.userInfo.College = -1;
            }
            Cryptography g = new Cryptography();
            GlobalData.userInfo.SZJDPassword = g.Encryption(GlobalData.userInfo.SZJDPassword);
            GlobalData.userInfo.JWXTPassword = g.Encryption(GlobalData.userInfo.JWXTPassword);

            Storage.Save(GlobalData.userInfo, "UserInfo.xml");
        } 
        private void infochange_Click(object sender, EventArgs e)
        {
            Save();
            AbsenceWordManager.FromName = GlobalData.userInfo.StudentName;
            MessageBox.Show("修改成功！");
        }

 

        private void show_password_CheckedChanged_1(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                //复选框被勾选，明文显示
                JWXTPasswordTextBox.PasswordChar = new char();
                SZJDPasswordTextBox.PasswordChar = new char();
            }
            else
            {
                //复选框被取消勾选，密文显示
                JWXTPasswordTextBox.PasswordChar = '*';
                SZJDPasswordTextBox.PasswordChar = '*';
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
