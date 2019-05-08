using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Lib
{
    public class AbsenceWordManager
    {
        public static List<string> templatesFilePath = new List<string>();
        public static int selectedIndex = 0;
        public static string selectedTemplateName = "";

        public static string GetSelectedFile()
        {
            if (templatesFilePath.Count > selectedIndex)
                return templatesFilePath[selectedIndex];
            else
                return "";
        }

        public static void OpenTemplate(string templatePath, RichTextBox richTextBox)
        {
            if (!File.Exists(templatePath))
            {
                MessageBox.Show(string.Format("{0}  模版文件不存在，请先设置模版文件。", templatePath));
                return;
            }

            Word.Application app = new Word.Application(); //创建一个Word应用程序实例
            Word.Document doc = null;  //生成的文档

            object missing = System.Reflection.Missing.Value; //初始化默认值
            object file = templatePath;
            object readOnly = false;//不是只读
            object isVisible = false;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref file, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                doc.ActiveWindow.Selection.WholeStory();//全选word文档中的数据
                doc.ActiveWindow.Selection.Copy();//复制数据到剪切板
                richTextBox.Paste();//richTextBox粘贴数据
                                    //richTextBox1.Text = doc.Content.Text;//显示无格式数据
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }
        }

        public static void GenerateWord(string templatePath, string toName, string reason,
            string dayLast, string startMonth, string startDay, string endMonth, string endDay,
            string fromName, string studentNum, string phone, string year, string month,
            string day, bool isSave, RichTextBox richTextBox)
        {
            if (!File.Exists(templatePath))
            {
                MessageBox.Show(string.Format("{0}  模版文件不存在，请先设置模版文件。", templatePath));
                return;
            }

            string dir = templatePath.Substring(0, templatePath.LastIndexOf(@"\") + 1);
            string temporatyFile = dir + "temp1.docx";
            File.Copy(templatePath, temporatyFile, true);

            Word.Application app = new Word.Application(); //创建一个Word应用程序实例
            Word.Document doc = null;  //生成的文档

            object missing = System.Reflection.Missing.Value; //初始化默认值
            object file = temporatyFile;
            object readOnly = false;//不是只读
            object isVisible = false;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref file, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                //填写
                doc.Bookmarks.get_Item("ToName").Range.Text = toName;
                doc.Bookmarks.get_Item("Reason").Range.Text = reason;
                doc.Bookmarks.get_Item("DayLast").Range.Text = dayLast;
                doc.Bookmarks.get_Item("StartMonth").Range.Text = startMonth;
                doc.Bookmarks.get_Item("StartDay").Range.Text = startDay;
                doc.Bookmarks.get_Item("EndMonth").Range.Text = endMonth;
                doc.Bookmarks.get_Item("EndDay").Range.Text = endDay;
                doc.Bookmarks.get_Item("FromName").Range.Text = fromName;
                doc.Bookmarks.get_Item("StudentNum").Range.Text = studentNum;
                doc.Bookmarks.get_Item("Phone").Range.Text = phone;
                doc.Bookmarks.get_Item("Year").Range.Text = year;
                doc.Bookmarks.get_Item("Month").Range.Text = month;
                doc.Bookmarks.get_Item("Day").Range.Text = day;

                if (isSave)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Word Document(*.docx)|*.docx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string wordName = sfd.FileName;

                        doc.SaveAs(wordName, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing);
                    }
                }
                else
                {
                    doc.ActiveWindow.Selection.WholeStory();//全选word文档中的数据
                    doc.ActiveWindow.Selection.Copy();//复制数据到剪切板
                    richTextBox.Paste();//richTextBox粘贴数据
                                        //richTextBox1.Text = doc.Content.Text;//显示无格式数据
                }
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }

        }
    }
}
