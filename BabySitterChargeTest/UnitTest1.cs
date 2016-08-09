using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterCharge;

namespace BabySitterChargeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChargeOne()
        {
            BabySitter babySitter = new BabySitter();

            Assert.AreEqual(144, babySitter.getPayCharge("5 PM", "11 PM", "4 AM"));
        }
    }
}
