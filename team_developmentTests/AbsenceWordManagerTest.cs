using System;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word = Microsoft.Office.Interop.Word;

namespace team_developmentTests
{
    [TestClass]
    public class AbsenceWordManagerTest
    {
        [TestMethod]
        public void GenerateWordTest()
        {
            String templatePath = AbsenceWordManager.DefaultTempalteDir + @"\暨南大学学生请假申请表.dot";
            Boolean result = false;
            AbsenceWordManager.GenerateWord(templatePath,
                AbsenceWordManager.ToName, AbsenceWordManager.Reason, AbsenceWordManager.Department, "00",
                AbsenceWordManager.StartTime.Year.ToString(), AbsenceWordManager.StartTime.Month.ToString(), AbsenceWordManager.StartTime.Day.ToString(),
                AbsenceWordManager.EndTime.Year.ToString(), AbsenceWordManager.EndTime.Month.ToString(), AbsenceWordManager.EndTime.Day.ToString(),
                AbsenceWordManager.FromName, AbsenceWordManager.StudentNum, AbsenceWordManager.Phone,
                DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), false, null);
            string dir = System.AppDomain.CurrentDomain.BaseDirectory + @"\";// templatePath.Substring(0, templatePath.LastIndexOf(@"\") + 1);
            string temporatyFile = dir + "temp.doc";

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

                String testString = "";
                if (doc.Bookmarks.Exists("ToName"))
                {
                    testString = doc.Bookmarks.get_Item("ToName").Range.Text;
                }
                result = testString.Equals(AbsenceWordManager.ToName);
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
            Assert.AreEqual(true, result);
            
        }
    }
}
