using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetElectricCharge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Lib;

namespace Lib.GetElectricCharge.Tests
{
    [TestClass()]
    public class GetElectricChargeTests
    {
        GetElectricCharge electric = new GetElectricCharge();

        [TestMethod()]
        public void GetElectric()
        {
            string electricity = electric.GetElectric("3305");
            if (electricity == null)
            {
                Assert.Fail();
            }
        }
    }
}