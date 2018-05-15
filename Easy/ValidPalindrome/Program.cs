using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    class Program
    {
        /*
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
         */
        static void Main(string[] args)
        {
            bool r = IsPalindrome("A man, a plan, a canal: Panama");
            bool r3 = IsPalindrome("A nut for a jar of tuna.");
            bool r4 = IsPalindrome("Al lets Della call Ed “Stella.”");
            bool r5 = IsPalindrome("Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era.");
            bool r2 = IsPalindrome("race a car");
            bool r6 = IsPalindrome("0P");
        }

        static bool IsPalindrome(string s)
        {
            StringBuilder normalizedStringBuilder = new StringBuilder();
            if(s == string.Empty)
            {
                return true;
            }

            foreach(char c in s)
            {
                if (char.IsLetter(c) || char.IsNumber(c))
                {
                    normalizedStringBuilder.Append(char.ToLower(c));
                }
            }

            string normalizedString = normalizedStringBuilder.ToString();
            int n = normalizedString.Length;
            int k = n / 2;
            int i = 0;
            int j = normalizedString.Length - 1;
            while(i<normalizedString.Length && j >= 0)
            {
                if(normalizedString[i] != normalizedString[j])
                {
                    return false;
                }

                if(i == j)
                {
                    return true;
                }

                i++;
                j--;
            }

            return true;
            //Stack<char> stack = new Stack<char>();
            //for(int i=0; i<n; i++)
            //{
            //    if(i < k)
            //    {
            //        stack.Push(normalizedString[i]);
            //    }
            //    else
            //    {
            //        if(normalizedString[i] != stack.Pop())
            //        {
            //            return false;
            //        }
            //    }
            //}

            //return stack.Count == 0;
        }
    }
}
