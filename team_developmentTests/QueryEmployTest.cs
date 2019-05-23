using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using team_development.UI.QueryEmploy;

namespace team_developmentTests
{
    [TestClass]
    public class QueryEmployTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            QueryEmploy employ = new QueryEmploy();
            employ.Activate();
            String c = "dataGridViewOffer";
           employ.Controls.Find(c,true);
            
            //employ.Click()

        }
    }
}
