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

namespace team_development.UI.QueryMealCard
{
    public partial class QueryMealcard : Form
    {
        Geticas getIcas = new Geticas();
        public QueryMealcard()
        {
            InitializeComponent();
        }

        private void MealcardInquiry_Load(object sender, EventArgs e)
        {

        }

        private void query_Click(object sender, EventArgs e)
        {
            HtmlDocument html = getIcas.Login("2016052351", "104213");
            htmlcontent.Text=html.Body.InnerHtml;
        }
    }
}
