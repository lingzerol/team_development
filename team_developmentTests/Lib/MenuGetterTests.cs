using Microsoft.VisualStudio.TestTools.UnitTesting;
using team_development.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_development.UI.CourseSelection;
using System.Windows.Forms;

namespace team_development.Lib.Tests
{
    [TestClass()]
    public class MenuGetterTests
    {
        [TestMethod()]
        public void GetMenuTest()
        {
            Assert.AreEqual(MenuGetter.GetMenu(MenuType.JWXT,SubMenuType.CourseSelection), MenuGetter.CourseSelectionInstance);
        }
    }
}