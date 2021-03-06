﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Lib;
using Lib.GetNotifications;
using System.Text.RegularExpressions;

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

            if (File.Exists(@"Campus_notification.txt"))
                File.Delete(@"Campus_notification.txt");
            //File.Delete(@"Lecture_notification.txt");
            //File.Delete(@"Student_notification.txt");
            //File.Delete(@"Teacher_notification.txt");
            if (File.Exists(@"baozhuang_news.txt"))
                File.Delete(@"baozhuang_news.txt");
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
        public void GetNotis()
        {
            Assert.IsFalse(File.Exists(@"Campus_notification.txt"));
            PyNotifications notitest = new PyNotifications();
            notitest.Init();
            Assert.IsTrue(File.Exists(@"Campus_notification.txt"));
        }

        [TestMethod]
        public void Getnews()
        {
            Assert.IsFalse(File.Exists(@"baozhuang_news.txt"));
            PyNews newstest = new PyNews();
            newstest.Init();
            Assert.IsTrue(File.Exists(@"baozhuang_news.txt"));
        }

       
    }
}