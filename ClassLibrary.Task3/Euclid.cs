using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ClassLibrary.Task3
{
    public class Euclid
    {
        public static int GetGcd(int a, int b)
        {
            int temp;
            using (new OperationTimer("Euclid GCD"))
            {
                while (b != 0)
                {
                    temp = b;
                    b = a%b;
                    a = temp;
                }
            }
            return a;
        }
        public static int GetGcd(int a, int b, int c)
        {
            return GetGcd(GetGcd(a, b), c);
        }

        public static int GetGcd(params int[] args)
        {
            int gcd = args[0];
            if (args.Length < 2)
                throw new Exception("Too few arguments in function");

            for (int i = 1; i < args.Length; i++)
            {
                gcd = GetGcd(gcd, args[i]);
            }
            return gcd;
        }

        public static uint GetBinaryGcd(uint a, uint b)
        {
            int shiftCount;

            using (new OperationTimer("Stein GCD"))
            {
                if (a == 0)
                    return b;
                if (b == 0)
                    return a;
                for (shiftCount = 0; ((a | b) & 1) == 0; shiftCount++)
                {
                    a >>= 1;
                    b >>= 1;
                }
                while ((a & 1) == 0)
                    a >>= 1;

                do
                {
                    while ((b & 1) == 0)
                        b >>= 1;
                    if (a > b)
                    {
                        Swap(ref a, ref b);
                    }
                    b = b - a;
                } while (b != 0);
                a = a << shiftCount;
            }
            return a;
        }

        public static uint GetBinaryGcd(uint a, uint b, uint c)
        {
            return GetBinaryGcd(GetBinaryGcd(a, b), c);
        }
        public static uint GetBinaryGcd(params uint[] args)
        {
            uint gcd = args[0];
            if (args.Length < 2)
            {
                throw new Exception("Too few arguments in function");
            }
            for (int i = 1; i < args.Length; i++)
            {
                gcd = GetBinaryGcd(gcd, args[i]);
            }
            return gcd;
        }
       


        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
