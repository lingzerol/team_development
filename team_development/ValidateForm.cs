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

namespace team_development
{
    public partial class ValidateForm : Form
    {
        private GetJWXT jwxt = GetJWXT.jwxt;
        private Geticas getIcas = Geticas.Icas;
        private Waiting wait = new Waiting();
        public ValidateForm()
        {
            InitializeComponent();
            ValidateImage.Image = jwxt.GetValidateImage();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            Cryptography g = new Cryptography();
            bool result =jwxt.Login(GlobalData.userInfo.StudentNumber, g.Decrypt(GlobalData.userInfo.JWXTPassword), getValidate.Text);
            getIcas.Login(GlobalData.userInfo.StudentNumber,g.Decrypt(GlobalData.userInfo.SZJDPassword));
            

            wait.StartKiller();
            if (result)
            {
                this.Hide();
                MenuGetter.GetMenu(MenuType.Nothing);
                string str = jwxt.GetCourseList().Body.InnerHtml;
                new Form1().ShowDialog();
                Application.ExitThread();
            }
        }

        private void ValidateImage_Click(object sender, EventArgs e)
        {
            ValidateImage.Image = jwxt.GetValidateImage();
        }

        private void ValidateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
