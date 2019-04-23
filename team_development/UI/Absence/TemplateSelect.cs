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
    public partial class TemplateSelect : Form
    {
        public TemplateSelect()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            Panel parent = (Panel)this.Parent;
            parent.Controls.Clear();

            //Form templateSelect = new TemplateSelect();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = System.Windows.Forms.DockStyle.Fill;

            parent.Controls.Add(f);
            f.Show();
        }

        private void btn_templatePreview_Click(object sender, EventArgs e)
        {
            //选择模板 -> 预览模板
            TurnToForm(new TemplatePreview());
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //选择模板 -> 填写请假条
            //TODO 数据转移
            TurnToForm(new AbsenceInput());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // 选择模板->填写请假条
            TurnToForm(new AbsenceInput());
        }
    }
}
