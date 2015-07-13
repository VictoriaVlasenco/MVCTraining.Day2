using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Task2;
using ClassLibrary.Task3;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Euclid.GetGcd(1071, 462);
            //Console.WriteLine(a);
            //uint b = Euclid.GetBinaryGcd(1071, 462, 21);
            //Console.WriteLine(b);

            IFormatProvider customFormatProvider = new HexadecimalNumberFormatProvider();
            Console.WriteLine(string.Format(customFormatProvider, "{0} is {0:H}", -887689));
            Console.Read();
        }
    }
}
