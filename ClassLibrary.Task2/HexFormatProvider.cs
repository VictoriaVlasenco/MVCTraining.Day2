using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Task2
{
    public class HexadecimalNumberFormatProvider : IFormatProvider, ICustomFormatter
    {
        private static readonly string[] HexCharacters = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split();

        IFormatProvider parent;  

        public HexadecimalNumberFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public HexadecimalNumberFormatProvider(IFormatProvider parent)
        {
            this.parent = parent;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider prov)
        {
            if (arg == null || format != "H")
                return string.Format(parent, "{0:" + format + "}", arg);

            return ConvertToHex((int)arg);
        }

        private static string ConvertToHex(int number)
        {
            bool isNegative = false;
            if (number < 0) 
            {
                number *= -1;
                number --;
                isNegative = true;
            }
            var result = new StringBuilder();
            while (number != 0)
            {
                int mod = number%16;
                result.Insert(0, isNegative ? HexCharacters[15 - mod] : HexCharacters[mod]);
                number /= 16;
            }
            result.Insert(0,"0x");
            return result.ToString();
        }
    }
}
