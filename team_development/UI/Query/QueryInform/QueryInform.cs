using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace team_development.UI.QueryInform
{
    public partial class QueryNotification : Form
    {
        public Form1 form1;
        GetInfo getInfo = new GetInfo();
        public QueryNotification()
        {
            InitializeComponent();          
            DataGridViewRowCollection rows = dataGridViewNotifocation.Rows;
            HtmlDocument html = getInfo.EnterWeb();
            //infocontent.Text = html.Body.InnerHtml;
        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RIndex = e.RowIndex;
            int CIndex = e.ColumnIndex;
            if (RIndex == 0&& CIndex == 0)
            {
                TurnToForm(new QueryInformArticle());   
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InquiryNotification_Load(object sender, EventArgs e)
        {
           
        }
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }
    }
}
