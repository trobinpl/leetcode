using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UglyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsUgly(1);
            bool r2 = IsUgly(14);
            bool r3 = IsUgly(8);
            bool r4 = IsUgly(6);
        }

        static bool IsUgly(int num)
        {
            if (num <= 0)
            {
                return false;
            }

            if (num == 1)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return IsUgly(num / 2);
            }
            else if (num % 3 == 0)
            {
                return IsUgly(num / 3);
            }
            else if (num % 5 == 0)
            {
                return IsUgly(num / 5);
            }

            return false;
        }
    }
}
