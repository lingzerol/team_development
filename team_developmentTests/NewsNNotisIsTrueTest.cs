using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Lib;
using System.Text.RegularExpressions;

namespace team_developmentTests
{
    /// <summary>
    /// NewsNNotisIsTrue 的摘要说明
    /// </summary>
    [TestClass]
    public class NewsNNotisIsTrueTest
    {
        Regex url = new Regex("[a-zA-z]+://[^\\s]*");
        Regex pubtime = new Regex("([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))");
        Regex title = new Regex("[\u4e00-\u9fa5]");

        public NewsNNotisIsTrueTest()
        {
            if (!File.Exists(@"Campus_notification.txt"))
            {
                PyNotifications notitest = new PyNotifications();
                notitest.Init();
            }
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void NotisIsTrue()
        {
            //Assert.IsTrue(File.Exists(@"Teacher_notification.txt"));
            //System.IO.StreamReader filetest = new StreamReader(@"Teacher_notification.txt");
            notistrue(@"Campus_notification.txt");
            notistrue(@"Teacher_notification.txt");
            notistrue(@"Student_notification.txt");
            notistrue(@"Lecture_notification.txt");
        }

        public void notistrue(string path) {
            Assert.IsTrue(File.Exists(path));
            System.IO.StreamReader filetest = new StreamReader(path);
            string titletest = filetest.ReadLine();
            string pubtimetest = filetest.ReadLine();
            string urltest = filetest.ReadLine();
            if (titletest == null || pubtimetest == null || urltest == null)
                Assert.Fail();

            Assert.IsTrue(url.IsMatch(urltest));

            Assert.IsTrue(pubtime.IsMatch(pubtimetest));

            Assert.IsTrue(title.IsMatch(titletest));
            filetest.Close();
        }
    }
}
