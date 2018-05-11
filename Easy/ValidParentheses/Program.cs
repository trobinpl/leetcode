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
            //bool test1 = ValidParentheses("()");
            //bool test2 = ValidParentheses("([{}])");
            //bool test3 = ValidParentheses("()[]{()}");
            //bool test4 = ValidParentheses("({[}])");
            //bool test5 = ValidParentheses("(([]){})");
            bool test6 = ValidParentheses("){");
        }

        static bool ValidParentheses(string s)
        {
            if(s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            for(int i = 0; i<=s.Length - 1; i++)
            {
                if(OpenBracket(s[i]))
                {
                    stack.Push(Complementary(s[i]));
                }
                else if (stack.Count > 0 && stack.Peek() == s[i])
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;
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

        static bool OpenBracket(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }
    }
}
