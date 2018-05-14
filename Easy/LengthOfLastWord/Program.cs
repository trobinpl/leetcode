using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {
        /*
         * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

           If the last word does not exist, return 0.

           Note: A word is defined as a character sequence consists of non-space characters only.

           "Hello World" -> 5
        */
        static void Main(string[] args)
        {
            int r = LengthOfLastWord("Hello World asd lol asdasdasd");
            int r2 = LengthOfLastWord("a ");
            int r3 = LengthOfLastWord("     a      ");
        }

        static int LengthOfLastWord(string s)
        {
            
            if(s.Length == 0)
            {
                return 0;
            }

            s = s.Trim();

            for (int i=s.Length - 1; i>=0; i--)
            {
                if(s[i] == ' ')
                {
                    return s.Length - 1 - i;
                }
            }

            if(s.Length > 0)
            {
                return s.Length;
            }

            return 0;
        }
    }
}
