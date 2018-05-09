using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    
    class Program
    {
        /*
         * Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
         * 121 -> true
         * -121 -> false, From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
         * 10 -> false, Reads 01 from right to left. Therefore it is not a palindrome.
         */
        static void Main(string[] args)
        {
            IsPalindrome(121);
            IsPalindrome(-121);
            IsPalindrome(10);
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            return x == ReverseInteger(x);
        }

        static int ReverseInteger(int x)
        {
            int reversed = 0;
            while(x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x = x / 10;
            }

            return reversed;
        }
    }
}
