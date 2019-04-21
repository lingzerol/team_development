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
    public partial class CourseSelection : Form
    {
        public CourseSelection()
        {
            InitializeComponent();
        }

        private void Course_selection_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“visual_studioDataSet.course”中。您可以根据需要移动或删除它。


        }

        private void QueryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AFLToolStripMenuItem_Click(object sender, EventArgs e)// ask for leave
        {

        }

        private void TimingSelection_Click(object sender, EventArgs e)
        {
           
        }


        private void CourseInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selection_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dlr = MessageBox.Show("您选择了：", "...", btn);
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
