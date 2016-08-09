using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterCharge;

namespace BabySitterCharge_Test
{
    [TestClass]
    public class ChargeTest
    {
        [TestMethod]
        public void TestCharge()
        {
            BabySitter babySitter = new BabySitter();

            Assert.AreEqual(144, babySitter.getPayCharge("11 PM", "5 PM", "4 AM"));
        }
    }
}
