using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.Tests
{
    [TestClass]
    public class SearchTest
    {
        NoticeSearch search = new NoticeSearch();

        [TestInitialize]
        public void TestInitialize()
        {
            search.getHtml("6");
        }

        [TestMethod]
        public void getHtmlTest()
        {
            search.getHtml("6");
        }

        [TestMethod]
        public void getTextTest()
        {
            if (search.getText().Equals(null))
            {
                Assert.Fail();
            }
            
        }
    }
}
