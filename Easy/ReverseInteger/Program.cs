using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        /*
         * Given a 32-bit signed integer, reverse digits of an integer.
         * 123 -> 321
         * -123 -> -321
         * 120 -> 21
         * 4120 -> 214
         */
        static void Main(string[] args)
        {
            Reverse(123);
            Reverse(-123);
            Reverse(120);
        }

        static int Reverse(int x)
        {
            long reversed = 0;

            while(x != 0)
            {
                reversed = reversed * 10 + x % 10;
                x = x / 10;
            }

            return (Math.Abs(reversed) > int.MaxValue) ? 0 : (int)reversed;
        }
    }
}
