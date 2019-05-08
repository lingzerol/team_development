using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.Absence
{
    public partial class WordPreview : Form
    {
        public WordPreview()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Cancel Button In WordPreview Form");
            //word预览 -> 填写请假条
            TurnToForm(new AbsenceInput());
        }

        private void TurnToForm(Form f)
        {
            Log.log.Info("Call TurnToForm Function");
            Panel parent = (Panel)this.Parent;
            if (parent == null)
            {
                Log.log.Error("Panel Widget Is Null In Function TurnToForm In TemplateSelect Form");
                return;
            }
            parent.Controls.Clear();

            //Form templateSelect = new TemplateSelect();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = System.Windows.Forms.DockStyle.Fill;

            parent.Controls.Add(f);
            f.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Save Button In WordPreview Form");
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

        private void WordPreview_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading WordPreview Form");
        }
    }
}
