using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.Search
{
    public partial class Notisditails : Form
    {
        public Notisditails(string url)
        {
            InitializeComponent();
            notisdetails.Navigate(url);
        }
    }
}
