using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    class Program
    {
        /*
         * Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

           The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

           You may assume the integer does not contain any leading zero, except the number 0 itself.

            [1,2,3] -> [1, 2, 4]
            [4,3,2,1] -> [4, 3, 2, 2]
        */
        static void Main(string[] args)
        {
            int[] r = PlusOne(new int[] { 1, 2, 3, 9 });
            int[] r2 = PlusOne(new int[] { 9, 9 });
            int[] r3 = PlusOne(new int[] { 9 });
            int[] r4 = PlusOne(new int[] { 0, 9 });
        }

        static int[] PlusOne(int[] digits)
        {
            int sum = digits[digits.Length - 1] + 1;
            int overflow = sum > 9 ? 1 : 0;
            digits[digits.Length - 1] = sum % 10;

            for (int i=digits.Length - 2; i>=0; i--)
            {
                sum = digits[i] + overflow;
                overflow = sum > 9 ? 1 : 0;
                digits[i] = sum % 10;
            }

            // result will have one more position than input e.g. 999 + 1 = 1000
            if(overflow == 1)
            {
                int[] newDigits = new int[digits.Length + 1];
                for(int i=1; i<digits.Length - 1; i++)
                {
                    newDigits[i] = digits[i];
                }
                newDigits[0] = 1;
                digits = newDigits;
            }

            return digits;
        }
    }
}
