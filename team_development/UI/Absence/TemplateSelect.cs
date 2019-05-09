using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.Absence
{
    public partial class TemplateSelect : Form
    {

        public TemplateSelect()
        {
            InitializeComponent();
        }

        private void TurnToForm(Form f)
        {
            Log.log.Info("Call TurnToForm Function");
            Panel parent = (Panel)this.Parent;
            if(parent == null)
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

        private void TemplatePreview_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Preview Button In TemplateSelect Form.");
            //选择模板 -> 预览模板
            TurnToForm(new TemplatePreview());
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Confirm Button In TemplateSelect Form.");
            //选择模板 -> 填写请假条
            //TODO 数据转移
            TurnToForm(new AbsenceInput());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Cancel Button In TemplateSelect Form.");
            // 选择模板->填写请假条
            TurnToForm(new AbsenceInput());
        }

        private void TemplateSelect_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading TemplateSelect Function");

            this.TemplateList.Items.Clear();
            foreach (string filePath in AbsenceWordManager.templatesFilePath)
            {
                this.TemplateList.Items.Add(Path.GetFileNameWithoutExtension(filePath));
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Update Button In TemplateSelect Form.");
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "选择模板文件夹";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string templateDir = dialog.SelectedPath;  //选中的文件夹的路径

                List<string> templates = GetWordTemplateList(templateDir);

                this.TemplateList.Items.Clear();
                AbsenceWordManager.templatesFilePath.Clear();
                //加入所有的*.dot文件
                foreach (string filePath in templates)
                {
                    AbsenceWordManager.templatesFilePath.Add(filePath);
                    this.TemplateList.Items.Add(Path.GetFileNameWithoutExtension(filePath));
                }
            }
        }
        
        private List<string> GetWordTemplateList(string templateDir)
        {
            Log.log.Info("Call GetWordTemplateList In TemplateSelect");

            List<string> ret = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(templateDir);
            FileInfo[] fileInfo = dir.GetFiles("*.dot");
            if (fileInfo.Length != 0)
            {
                foreach (FileInfo f in fileInfo)
                {
                    ret.Add(f.FullName);
                }
            }
            return ret;
        }

        private void TemplateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.log.Info("Select ListBox Item In TemplateSelect.");
            //TODO: 取消时回退
            AbsenceWordManager.selectedIndex = TemplateList.SelectedIndex;
        }
    }
}
