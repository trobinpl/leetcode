using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        /*
         * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
         * I -> 1, V -> 5, X -> 10, L -> 50, C -> 100, D -> 500, M -> 1000
         * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
         * Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
         * The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
         * - I can be placed before V (5) and X (10) to make 4 and 9.
         * - X can be placed before L (50) and C (100) to make 40 and 90. 
         * - C can be placed before D (500) and M (1000) to make 400 and 900.
         * Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
         */
        static void Main(string[] args)
        {
            //Console.WriteLine(RomanToInt("I"));
            //Console.WriteLine(RomanToInt("II"));
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("DCXXI"));
            //Console.WriteLine(RomanToInt("IV"));
            //Console.WriteLine(RomanToInt("V"));
            //Console.WriteLine(RomanToInt("VI"));
            //Console.WriteLine(RomanToInt("VII"));
            //Console.WriteLine(RomanToInt("VIII"));
            //Console.WriteLine(RomanToInt("IX"));
            //Console.WriteLine(RomanToInt("IX"));
            //Console.WriteLine(RomanToInt("X"));
            //Console.WriteLine(RomanToInt("IX"));
            //Console.WriteLine(RomanToInt("CD"));
            //Console.WriteLine(RomanToInt("CM"));

            Console.ReadKey();
        }

        static int RomanToInt(string s)
        {
            switch (s)
            {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
            }

            // result = RomanToInt(s[0].ToString()) +/- RomanToInt(s.Substring(1));
            int current = RomanToInt(s[0].ToString());
            int next = RomanToInt(s.Substring(1));

            if (current >= next || next < 5)
            {
                return current + next;
            }
            else
            {
                return next - current;
            }
        }
    }
}
