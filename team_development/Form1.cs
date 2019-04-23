using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_development.Lib;
using team_development.UI.InqueryEmploy;
using team_development.UI.InqueryInform;
namespace team_development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CourseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.JWXT, SubMenuType.C_S);
        }


        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnForm(MenuType.UserInfo);
        }
        private Form TurnForm(MenuType MenuId,SubMenuType SubMenu=0)
        {
            this.Form1Content.Controls.Clear();
            Form f = MenuGetter.GetMenu(MenuId,SubMenu);
            this.Form1Content.Controls.Add(f);
            f.Show();
            return f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InqueryInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquiryNotification inform=(InquiryNotification)TurnForm(MenuType.Query, SubMenuType.Q_Inform);
            inform.TransfEvent += frm_TransfEvent;
        }

        private void InqueryEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquiryOffer employ= (InquiryOffer)TurnForm(MenuType.Query, SubMenuType.Q_Employ);
            employ.TransfEvent += frm_TransfEvent;
        }
        //委托响应函数
        void frm_TransfEvent(string value)
        {
            switch (value)
            {
                case "Inform":
                    NotificationArticle InfotmArticle=(NotificationArticle)TurnForm(MenuType.Query, SubMenuType.Q_Inform_Article);
                    InfotmArticle.TransfEvent += frm_TransfEvent;                
                    break;
                case "Employ":
                    OfferArticle EmployArticle = (OfferArticle)TurnForm(MenuType.Query, SubMenuType.Q_Employ_Article);
                    EmployArticle.TransfEvent += frm_TransfEvent;
                    break;
                case "InformReturn":                 
                    InquiryNotification InformReturn = (InquiryNotification)TurnForm(MenuType.Query, SubMenuType.Q_Inform);
                    InformReturn.TransfEvent += frm_TransfEvent;
                    break;
                case "EmployReturn":
                    InquiryOffer EmployReturn = (InquiryOffer)TurnForm(MenuType.Query, SubMenuType.Q_Employ);
                    EmployReturn.TransfEvent += frm_TransfEvent;
                    break;
            }
        }
    }

}

