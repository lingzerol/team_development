using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Lib.GetJWXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace team_developmentTests
{
    [TestClass]
    public class QueryGpaTest
    {
        GetJWXT jwxttest = new GetJWXT();
        [TestMethod]
        public void GpaTest()
        {
            try
            {
                if (!File.Exists(@"gpa.txt"))
                {
                    return;
                }
                StreamReader sr = new StreamReader(@"gpa.txt", Encoding.Default);
                string str = sr.ReadToEnd();
                List<Gpa> gpas = jwxttest.GetGpaList(str);
                if (gpas == null)
                    Assert.Fail();

            }
            catch (Exception e)
            {
                MessageBox.Show("getgpa fail");
                Assert.Fail();
            }
        }
    }
}
