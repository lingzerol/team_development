using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using System.Windows.Forms;
using Lib.GetJWXT;
using team_development.FormLib;
using team_development.UI.UserInfo;
using team_development.UI.JWXT;

namespace team_development.UI.MatchScheme
{
    public partial class MatchScheme : Form
    {

        List<Control> collection;
        public MatchScheme()
        {
            InitializeComponent();
            collection = new List<Control>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Log.log.Info("CALL tableLayoutPane11_Paint function.");
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MatchScheme_Load(object sender, EventArgs e)
        {
            RemoveText();
            MatchSchemeItem matchSchemeItem = AnalyseJWXT.GetMatchSchemeItem();
            if(matchSchemeItem != null)
            {
                MessageBox.Show("加载匹配培养方案完成");
                for (int i = 0; i < matchSchemeItem.needs.Count; i++)
                {
                    AddText(matchSchemeItem.needs[i], 3, i + 1);
                }
                for (int i = 0; i < matchSchemeItem.study.Count; i++)
                {
                    AddText(matchSchemeItem.study[i], 4, i + 1);
                }
                for (int i = 0; i < matchSchemeItem.lefts.Count; i++)
                {
                    AddText(matchSchemeItem.lefts[i], 5, i + 1);
                }
            }
            else
            {
                MessageBox.Show("请刷新");
            }
         
        }


        
        private void AddText(string str,int column, int row)
        {
            Label lb = new Label();
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            collection.Add(lb);
            this.tableLayoutPanel1.Controls.Add(lb, column, row);
        }

        private void RemoveText()
        {
            for(int i=0; i<collection.Count; i++)
            {
                this.tableLayoutPanel1.Controls.Remove(collection[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Log.log.Info("Click Refresh button In MatchScheme Form.");
            if (GlobalData.userInfo.StudentNumber == null || GlobalData.userInfo.JWXTPassword == null )
            {
                MessageBox.Show("请完善您的个人信息", "出现错误");
                this.Hide();
                MenuGetter.GetMenu(MenuType.Nothing);
                ((Form1)(this.ParentForm)).TurnForm(MenuType.UserInfo);
            } else
            {
                Cryptography g = new Cryptography();
                JwxtLogin jwxtLogin = JwxtLoginSingleton.GetInstance(GlobalData.userInfo.StudentNumber, g.Decrypt(GlobalData.userInfo.JWXTPassword), refresh);
                jwxtLogin.Show();
            }
        }

        private void refresh()
        {
            RemoveText();
            MatchSchemeItem matchSchemeItem = AnalyseJWXT.GetMatchSchemeItem();
            if (matchSchemeItem != null)
            {
                MessageBox.Show("加载匹配培养方案完成");
                for (int i = 0; i < matchSchemeItem.needs.Count; i++)
                {
                    AddText(matchSchemeItem.needs[i], 3, i + 1);
                }
                for (int i = 0; i < matchSchemeItem.study.Count; i++)
                {
                    AddText(matchSchemeItem.study[i], 4, i + 1);
                }
                for (int i = 0; i < matchSchemeItem.lefts.Count; i++)
                {
                    AddText(matchSchemeItem.lefts[i], 5, i + 1);
                }
            }
            else
            {
                MessageBox.Show("刷新失败");
            }
        }
    }
}
