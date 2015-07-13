using System;
using ClassLibrary.Task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEuclidMethod
{
    [TestClass]
    public class TestEuclid
    {
        [TestMethod]
        public void EuclidGCD_1071_462_Expected21()
        {
            int gcd = Euclid.GetGcd(1071, 462);
            Assert.AreEqual(21, gcd);
        }

        [TestMethod]
        public void EuclidGCD_1071_462_21_Expected21()
        {
            int gcd = Euclid.GetGcd(1071, 462, 21);
            Assert.AreEqual(21, gcd);
        }
        [TestMethod]
        public void EuclidGCD_1071_462_21_7Expected7()
        {
            int gcd = Euclid.GetGcd(1071, 462, 21, 7);
            Assert.AreEqual(7, gcd);
        }

        [TestMethod]
        public void EuclidGCD_Minus21_Minus7Expected_Minus7()
        {
            int gcd = Euclid.GetGcd(-21, -7);
            Assert.AreEqual(-7, gcd);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EuclidGCD_1071ExpectedException()
        {
            int gcd = Euclid.GetGcd(1071);
        }
    }
}
