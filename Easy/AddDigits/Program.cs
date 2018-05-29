using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = AddDigits(38);
            int r2 = AddDigits(1853);
            int r3 = AddDigits(0);
        }

        static int AddDigits(int num)
        {
            // https://en.wikipedia.org/wiki/Digital_root#Congruence_formula
            return 1 + ((num - 1) % 9);
        }
    }
}
