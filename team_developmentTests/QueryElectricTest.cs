using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetElectricCharge;
using System.Threading;

namespace team_developmentTests
{
    [TestClass]
    public class QueryElectricTest
    {
        GetElectricCharge gec = new GetElectricCharge();
        Mutex charge_mtx = new Mutex();
        string electric;

        public void SetElectricCharge(string charge)
        {
            charge_mtx.WaitOne();
            charge_mtx.ReleaseMutex();
            electric = charge;
        }

        [TestMethod]
        public void TestMethod1()
        {
            gec.GetElectric("3305", new SetCharge(this.SetElectricCharge));
            if (electric == null)
            {
                //Assert.Fail();
            }
        }
    }
}
