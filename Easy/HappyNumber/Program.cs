using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsHappy(1);
            bool r1 = IsHappy(7);
            bool r2 = IsHappy(10);
            bool r3 = IsHappy(13);
            bool r4 = IsHappy(19);
            bool r5 = IsHappy(23);
            bool r6 = IsHappy(70);
            bool r7 = IsHappy(79);
            bool r8 = IsHappy(188);
            bool r9 = IsHappy(208);
            bool r10 = IsHappy(1000);
            bool r11 = IsHappy(998);
            bool r12 = IsHappy(874);
            bool r13 = IsHappy(25);
            bool r14 = IsHappy(145);
            bool r15 = IsHappy(29);
            bool r16 = IsHappy(20);
            bool r17 = IsHappy(37);
        }

        static public bool IsHappy(int n)
        {
            int slow =  n;
            int fast = n;
            do
            {
                slow = PowerDigits(slow);
                fast = PowerDigits(PowerDigits(fast));
            }
            while (slow != 1 && slow != fast);

            return slow == 1 ? true : false;
        }

        static public bool IsHappyHash(int n)
        {
            HashSet<int> sums = new HashSet<int>();
            while(n != 1)
            {
                n = PowerDigits(n);
                // detect cycle
                if (sums.Contains(n))
                {
                    return false;
                }
                sums.Add(n);
            }

            return true;
        }

        static int PowerDigits(int n)
        {
            double sum = 0;
            while(n > 0)
            {
                sum += Math.Pow(n % 10, 2);
                n /= 10;
            }
            return (int)sum;
        }
    }
}
