using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetJWXT;
using System.Windows.Forms;

namespace team_developmentTests
{
    /// <summary>
    /// GetGpaTest 的摘要说明
    /// </summary>
    [TestClass]
    public class GetGpaTest
    {
        GetJWXT jwxttest = new GetJWXT();
        string validate = "";
        public GetGpaTest()
        {
            Form2 f2 = new Form2();
            if (f2.DialogResult == DialogResult.OK)
            {
                validate = f2.validatetext;
            }
            jwxttest.GetValidateImage();
            
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
        public void Logintest()
        {
            try
            {
                jwxttest.Login("2016052351", "liangzp1818", validate);
            }
            catch (Exception e)
            {
                MessageBox.Show("login fail");
                Assert.Fail();
            }
        }
    }
}
