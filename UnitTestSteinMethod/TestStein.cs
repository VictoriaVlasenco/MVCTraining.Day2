using System;
using ClassLibrary.Task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSteinMethod
{
    [TestClass]
    public class TestStein
    {
        [TestMethod]
        public void SteinGCD_1071_462_Expected21()
        {
            uint gcd = Euclid.GetBinaryGcd(1071, 462);
            Assert.AreEqual((uint)21, gcd);
        }

        [TestMethod]
        public void SteinGCD_1071_462_21Expected21()
        {
            uint gcd = Euclid.GetBinaryGcd(1071, 462, 21);
            Assert.AreEqual((uint)21, gcd);
        }

        [TestMethod]
        public void SteinGCD_1071_462_21_7Expected7()
        {
            uint gcd = Euclid.GetBinaryGcd(1071, 462, 21, 7);
            Assert.AreEqual((uint)7, gcd);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SteinGCD_1071ExpectedException()
        {
            uint gcd = Euclid.GetBinaryGcd(1071);
        }
    }
}
