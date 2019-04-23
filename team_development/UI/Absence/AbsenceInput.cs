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
    public partial class AbsenceInput : Form
    {
        public AbsenceInput()
        {
            InitializeComponent();
        }

        private void Absence_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_selectTemplate_Click(object sender, EventArgs e)
        {
            //填写请假条 -> 选择模板
            TurnToForm(new TemplateSelect());

        }

        private void btn_wordPreview_Click(object sender, EventArgs e)
        {
            //填写请假条 -> word预览
            TurnToForm(new WordPreview());
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
    }
}
