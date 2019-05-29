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
using Lib;
using Lib.GetMealCard;
using team_development.FormLib;
using team_development.UI.Query.QueryMealCard;

namespace team_development.UI.QueryMealCard
{
    public partial class QueryMealcard : Form
    {
        Geticas getIcas = Geticas.Icas;
        public QueryMealcard()
        {
            InitializeComponent();
            refresh();
        }

        private void MealcardInquiry_Load(object sender, EventArgs e)
        {

        }            
        private void QueryMealCard()
        {
            try
            {
                String str = getIcas.Query();
                str = str.Substring(str.IndexOf("更换头像"));
                str = str.Substring(str.IndexOf("t01>"));
                textBox2.Text = str.Substring(str.IndexOf("t01>") + 4, str.IndexOf("</S") - str.IndexOf("t01>") - 4);
                str = str.Substring(str.IndexOf("t02>"));
                textBox1.Text = str.Substring(str.IndexOf("t02>") + 4, str.IndexOf("</S") - str.IndexOf("t02>") - 4);
                str = str.Substring(str.IndexOf("余额"));
                textBox3.Text = str.Substring(str.IndexOf("nt>") + 3, str.IndexOf("</S") - str.IndexOf("nt>") - 3);
                str = str.Substring(str.IndexOf("<FONT class=green>"));
                textBox4.Text = str.Substring(str.IndexOf("reen>") + 5, str.IndexOf("/F") - str.IndexOf("reen>") - 6);
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败，请稍后再试");
            }
           }
        private void QueryMealcard_Load(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Refresh button In MatchScheme Form.");
            if (GlobalData.userInfo.StudentNumber == null || GlobalData.userInfo.JWXTPassword == null)
            {
                MessageBox.Show("请完善您的个人信息", "出现错误");
                this.Hide();
                MenuGetter.GetMenu(MenuType.Nothing);
                ((Form1)(this.ParentForm)).TurnForm(MenuType.UserInfo);
            }
            else
            {
                
                SzjdLogin szjdLogin = SzjdLoginSingleton.GetInstance(GlobalData.userInfo.StudentNumber, "040939", refresh);
                szjdLogin.Show();
            }

        }
        private void refresh()
        {
            string content = File.ReadAllText(@"mealcard.txt", Encoding.UTF8);
            textBox1.Text = "电气信息学院";
            textBox2.Text = GlobalData.userInfo.StudentName;
            textBox3.Text = content;
            textBox4.Text = "正常";
        }
    }
}
