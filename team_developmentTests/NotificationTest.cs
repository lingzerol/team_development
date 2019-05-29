using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Lib;
using Lib.GetNotifications;

namespace team_developmentTests
{
    /// <summary>
    /// NotificationTest 的摘要说明
    /// </summary>
    [TestClass]
    public class NotificationTest
    {
        [TestInitialize]
        public void Init()
        {
            if (!File.Exists(@"jnu_news.txt") || !File.Exists(@"Campus_notification.txt") || !File.Exists(@"Lecture_notification.txt") || !File.Exists(@"Student_notification.txt") || !File.Exists(@"Teacher_notification.txt"))
            {
                PyNotifications notitest = new PyNotifications();
                notitest.Init();
                PyNews getnews = new PyNews();
                getnews.Init();
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
        public void Txtget()
        {
            Assert.IsTrue(File.Exists(@"jnu_news.txt"));
            Assert.IsTrue(File.Exists(@"Campus_notification.txt"));
            Assert.IsTrue(File.Exists(@"Lecture_notification.txt"));
            Assert.IsTrue(File.Exists(@"Teacher_notification.txt"));
        }
    }
}
