using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSteinMethod
{
    [TestClass]
    public class TestStein
    {
        [TestMethod]
        public void SteinGCD_1071_462_Expected21()
        {
            int gcd = Euclid.GetBinaryGcd(1071, 462);
            Assert.AreEqual(21, gcd);
        }
    }
}
