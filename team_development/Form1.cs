using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
              this.Form1Content.Controls.Clear();
              Form f = MenuGetter.GetMenu(MenuType.JWXT, SubMenuType.C_S);
              this.Form1Content.Controls.Add(f);
              f.Show();          
        }




        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QueryEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Form1Content.Controls.Clear();
            InquiryOffer f = (InquiryOffer)MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Employ);
            this.Form1Content.Controls.Add(f);
            f.Show();
            //注册事件
            f.TransfEvent += frm_TransfEvent;


        }

        private void QueryInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Form1Content.Controls.Clear();
            InquiryNotification f = (InquiryNotification)MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Inform);
            this.Form1Content.Controls.Add(f);
            f.Show();
            f.TransfEvent += frm_TransfEvent;
           
        }
        //事件处理方法
        void frm_TransfEvent(string value)    
        {
            switch (value)
            {
                case "Inform":
                    this.Form1Content.Controls.Clear();
                    NotificationArticle Inform = (NotificationArticle)MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Inform_Article);
                    this.Form1Content.Controls.Add(Inform);
                    Inform.Show();
                    Inform.TransfEvent += frm_TransfEvent;

                    break;
                case "Employ":
                    this.Form1Content.Controls.Clear();
                    OfferArticle Employ =(OfferArticle) MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Employ_Article);
                    this.Form1Content.Controls.Add(Employ);
                    Employ.Show();
                    Employ.TransfEvent += frm_TransfEvent;

                    break;
                case "InformReturn":
                    this.Form1Content.Controls.Clear();
                    InquiryNotification InformReturn = (InquiryNotification) MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Inform);
                    this.Form1Content.Controls.Add(InformReturn);
                    InformReturn.Show();
                    InformReturn.TransfEvent += frm_TransfEvent;
                    break;
                case "EmployReturn":
                    this.Form1Content.Controls.Clear();
                    InquiryOffer EmployReturn = (InquiryOffer)MenuGetter.GetMenu(MenuType.Query, SubMenuType.Q_Inform);
                    this.Form1Content.Controls.Add(EmployReturn);
                    EmployReturn.Show();
                    EmployReturn.TransfEvent += frm_TransfEvent;
                    break;
            }
        }
        }
        
    }

