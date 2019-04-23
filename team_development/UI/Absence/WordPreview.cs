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
    public partial class WordPreview : Form
    {
        public WordPreview()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //word预览 -> 填写请假条
            TurnToForm(new AbsenceInput());
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            //打开文件保存对话框
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "word文档(*.docx)|*.docx|测试用(*.txt)|*.txt";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true; //保存上次打开目录
            
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveDialog.FileName.ToString(); //文件路径
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\")+1);
            }

        }
    }
}
