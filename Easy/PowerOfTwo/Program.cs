using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsPowerOfTwoNotEfficent(1);
            bool r2 = IsPowerOfTwoNotEfficent(16);
            bool r3 = IsPowerOfTwoNotEfficent(32);
            bool r4 = IsPowerOfTwoNotEfficent(218);

            bool r5 = IsPowerOfTwo(1);
            bool r6 = IsPowerOfTwo(16);
            bool r7 = IsPowerOfTwo(32);
            bool r8 = IsPowerOfTwo(218);
        }

        public static bool IsPowerOfTwo(int n)
        {
            return (n > 0) && ((n & (n - 1)) == 0);
        }

        public static bool IsPowerOfTwoNotEfficent(int n)
        {
            double p = n;
            while(p >= 1)
            {
                if (p == 1)
                {
                    return true;
                }

                p = p / 2.0;
            }

            return false;
        }
    }
}
