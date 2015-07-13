using System;
using ClassLibrary.Task2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask2
{
    [TestClass]
    public class UnitTestFormatProvider
    {
        [TestMethod]
        public void ConvertDecimal_900_ToHexExpected_0x384()
        {
            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            Assert.AreEqual(string.Format(customFormatProvider, "{0:H}", 900), "0x384");
        }

        [TestMethod]
        public void ConvertDecimal_Minus900_ToHexExpected_0xC7C()
        {
            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            Assert.AreEqual(string.Format(customFormatProvider, "{0:H}", -900), "0xC7C");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConvertDecimal_Minus900_ToNonExistingFormat()
        {
            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            string s = string.Format(customFormatProvider, "{0:Z}", -900);
        }

        [TestMethod]
        public void ConvertDecimal_900_ToAnotherFormatUsingHexFormatter()
        {
            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            string s = string.Format(customFormatProvider, "{0:C}", 900);
            Assert.AreEqual(s, "900,00р.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void Convert_ABCD_ToHexadecimalExpectedException()
        {
            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            string s = string.Format(customFormatProvider, "{0:H}", "ABCD");
        }
    }
}
