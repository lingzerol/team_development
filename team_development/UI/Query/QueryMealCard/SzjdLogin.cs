using Lib.GetMealCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.Query.QueryMealCard
{
    public delegate void Refresh();
    public partial class SzjdLogin : Form
    {
        private PyMealcard pyMeal = null;
        private Refresh refresh;

        public SzjdLogin(string username, string password, Refresh refresh)
        {
            InitializeComponent();
            this.refresh = refresh;
            pyMeal = new PyMealcard(username, password, ValidateImage);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (!pyMeal.GetAll(getValidate.Text))
            {
                pyMeal.Retry();
            }
            else
            {
                refresh();
                this.Close();

            }

        }

        private void ValidateImage_Click(object sender, EventArgs e)
        {
            pyMeal.Retry();
        }

        private void JwxtLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            pyMeal.Destroy();
            SzjdLoginSingleton.SetNull();
        }

        private void Confirm_Click1(object sender, EventArgs e)
        {
            if (!pyMeal.GetAll(getValidate.Text))
            {
                pyMeal.Retry();
            }
            else
            {
                refresh();
                this.Close();

            }

        }

        private void ValidateImage1_Click(object sender, EventArgs e)
        {
            pyMeal.Retry();
        }

        private void JwxtLogin1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pyMeal.Destroy();
            SzjdLoginSingleton.SetNull();
        }
    }
}

