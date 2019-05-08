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
    public partial class AbsenceInput : Form
    {
        public AbsenceInput()
        {
            InitializeComponent();
        }

        private void Absence_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading AbsenceInput Form.");
        }

        private void SelectTemplate_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click SelectTemplate Button In AbsenceInput Form");
            //填写请假条 -> 选择模板
            TurnToForm(new TemplateSelect());

        }

        private void WordPreview_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click WordPreview Button In AbsenceInput Form");
            //填写请假条 -> word预览
            TurnToForm(new WordPreview());
        }

        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }
    }
}
