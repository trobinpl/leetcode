using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MyHammingWeight(11);
            int r2 = MyHammingWeight(128);
            int r3 = MyHammingWeight(128);
            int r4 = MyHammingWeight(128);
        }

        static int HammingWeight(uint n)
        {
            int counter = 0;
            for(int i = 0; i <= 31; i++)
            {
                if(((n >> i) & 1) == 1)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int MyHammingWeight(uint n)
        {
            int counter = 0;
            while(n > 0)
            {
                if(n % 2 == 1)
                {
                    counter++;
                }
                n /= 2;
            }
            return counter;
        }
    }
}
