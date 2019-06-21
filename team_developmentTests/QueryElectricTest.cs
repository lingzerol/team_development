using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetElectricCharge;
using System.Threading;
using Lib;

namespace team_developmentTests
{
    [TestClass]
    public class QueryElectricTest
    {
        GetElectricCharge gec = new GetElectricCharge();
        Waiting wait = new Waiting();
        Mutex charge_mtx = new Mutex();
        string previous_charge = null;
        string electric = null ;

        public void SetElectricCharge(string charge)
        {
            charge_mtx.WaitOne();
            charge_mtx.ReleaseMutex();
            electric = charge;
        }

        public bool IsOK()
        {
            bool ok = false;
            charge_mtx.WaitOne();
            if (electric != previous_charge)
                ok = true;
            charge_mtx.ReleaseMutex();
            return ok;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            gec.GetElectric("3305", new SetCharge(this.SetElectricCharge));
            previous_charge = electric;
            wait.StartKiller(true, 1000, IsOK);
        }

        [TestMethod]
        public void TestMethod1()
        {
            wait.StartKiller(true, 1000, IsOK);
            if (electric == null)
            {
                Assert.Fail();
            }
        }
    }
}
