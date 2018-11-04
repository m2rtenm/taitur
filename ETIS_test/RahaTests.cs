using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ETIS.Domain;

namespace ETIS_test
{
    [TestClass]
    public class RahaTests
    {
        [TestMethod]
        public void TestAreEqual()
        {
            var raha1 = new Raha(40, "EUR");
            var raha2 = new Raha(40, "EUR");

            Assert.IsTrue(raha1.Equals(raha2));
        }

        [TestMethod]
        public void TestAreNotEqual1()
        {
            var raha1 = new Raha(40, "EUR");
            var raha2 = new Raha(50, "EUR");

            Assert.IsFalse(raha1.Equals(raha2));
        }

        [TestMethod]
        public void TestAreNotEqual2()
        {
            var raha1 = new Raha(40, "EUR");
            var raha2 = new Raha(40, "EEK");

            Assert.IsFalse(raha1.Equals(raha2));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEiSaaLuuaIlmaValuutataRaha()
        {
            new Raha(50, null);
        }
    }
}
