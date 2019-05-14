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
            try
            {
                if (search.getText().Equals(null))
                {
                    Assert.Fail();
                }
            }
            catch (Exception E)
            {
                Log.log.Error(E.ToString());
            }
        }
    }
}
