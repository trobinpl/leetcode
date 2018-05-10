using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        /*
         * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

           An input string is valid if:

           Open brackets must be closed by the same type of brackets.
           Open brackets must be closed in the correct order.

           Note that an empty string is also considered valid.
         * () -> true
         * ()[]{} -> true
         * (] -> false
         * ([)] -> false
         * {[]} -> true
         */
        static void Main(string[] args)
        {
            bool test1 = ValidParentheses("()");
            bool test2 = ValidParentheses("([{}])");
            bool test3 = ValidParentheses("()[]{()}");
            bool test4 = ValidParentheses("({[}])");
            bool test5 = ValidParentheses("(([]){})");
        }

        static bool ValidParentheses(string s)
        {
            if(s.Length % 2 != 0)
            {
                return false;
            }

            if(s.Length == 0)
            {
                return true;
            }

            char open = s[0];
            int complementaryIndex = FindFarestComplementary(open, s);
            if (complementaryIndex != -1 && complementaryIndex % 2 != 0)
            {
                s = string.Concat(s.Substring(1, complementaryIndex - 1), s.Substring(complementaryIndex + 1));

                return true && ValidParentheses(s);
            }

            return false;

            /* if(complementary not found)
             * we should have empty string
             */
        }

        static char Complementary(char c)
        {
            switch (c)
            {
                case '(':
                    return ')';
                case '{':
                    return '}';
                case '[':
                    return ']';
                default:
                    return ' ';
            }
        }

        static int FindFarestComplementary(char open, string s)
        {
            for(int i = s.Length - 1; i > 0; i--)
            {
                if(s[i] == Complementary(open))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
