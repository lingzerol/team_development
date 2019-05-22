using System;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace team_developmentTests
{
    [TestClass]
    public class AbsenceWordManagerTest
    {
        [TestMethod]
        public void GenerateWordTest()
        {
            String templatePath = AbsenceWordManager.DefaultTempalteDir + @"\暨南大学学生请假申请表.dot";
            Boolean result = AbsenceWordManager.GenerateWord(templatePath,
                AbsenceWordManager.ToName, AbsenceWordManager.Reason, AbsenceWordManager.Department, "00",
                AbsenceWordManager.StartTime.Year.ToString(), AbsenceWordManager.StartTime.Month.ToString(), AbsenceWordManager.StartTime.Day.ToString(),
                AbsenceWordManager.EndTime.Year.ToString(), AbsenceWordManager.EndTime.Month.ToString(), AbsenceWordManager.EndTime.Day.ToString(),
                AbsenceWordManager.FromName, AbsenceWordManager.StudentNum, AbsenceWordManager.Phone,
                DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), false, null);
            Assert.AreEqual(true, result);
            
        }
    }
}
