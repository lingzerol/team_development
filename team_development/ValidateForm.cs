using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.GetJWXT;
using Lib;
using team_development.FormLib;
using team_development.UI.UserInfo;
using team_development.UI;
using Lib.GetElectricCharge;
using Lib.GetNotifications;

namespace team_development
{
    public partial class ValidateForm : Form
    {
        //private GetJWXT jwxt = GetJWXT.jwxt;
        private PyJWXT pyJwxt = null;
        private Geticas getIcas = Geticas.Icas;
        private Waiting wait = new Waiting();
        public ValidateForm()
        {
            InitializeComponent();
            //ValidateImage.Image = jwxt.GetValidateImage();
            if(GlobalData.userInfo.JWXTPassword == null || GlobalData.userInfo.StudentNumber == null || GlobalData.userInfo.SZJDPassword == null || GlobalData.userInfo.DormNumber == null) {
                MessageBox.Show("请完善您的个人信息", "出现错误");
                this.Hide();
                MenuGetter.GetMenu(MenuType.Nothing);
                Form1 form = new Form1();
                form.TurnForm(MenuType.UserInfo);
                form.ShowDialog();
                Application.ExitThread();
            } else
            {
                Cryptography g = new Cryptography();
                pyJwxt = new PyJWXT(GlobalData.userInfo.StudentNumber, g.Decrypt(GlobalData.userInfo.JWXTPassword), ValidateImage);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            Cryptography g = new Cryptography();
            //bool result = jwxt.Login(GlobalData.userInfo.StudentNumber, g.Decrypt(GlobalData.userInfo.JWXTPassword), getValidate.Text);
            getIcas.Login(GlobalData.userInfo.StudentNumber,g.Decrypt(GlobalData.userInfo.SZJDPassword));
            PyNotifications getNoti = new PyNotifications();
          
            //wait.StartKiller();
            this.Hide();
            MenuGetter.GetMenu(MenuType.Nothing);
            Form1 form = new Form1();
            //if (!result)
            //{
            //    MessageBox.Show("密码或验证码错误", "Error");
            //    form.TurnForm(MenuType.UserInfo);
            //}
            if (!pyJwxt.GetAll(getValidate.Text))
            {
                form.TurnForm(MenuType.UserInfo);
            }
            form.ShowDialog();
            Application.ExitThread();
        }

        private void ValidateImage_Click(object sender, EventArgs e)
        {
            //ValidateImage.Image = jwxt.GetValidateImage();
            pyJwxt.Retry();
        }

        private void ValidateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
