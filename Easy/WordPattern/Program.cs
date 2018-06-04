using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = WordPattern("abba", "cat lol lol cat");
            bool r2 = WordPattern("aaaa", "dog cat cat dog");
            bool r3 = WordPattern("abba", "dog dog dog dog");
        }

        static bool WordPattern(string pattern, string str)
        {
            Dictionary<char, string> patternToString = new Dictionary<char, string>();
            Dictionary<string, char> stringToPattern = new Dictionary<string, char>();
            string[] strParts = str.Split();

            for(int i=0; i<strParts.Length; i++)
            {
                char currentPattern = pattern[i];
                string currentString = strParts[i];

                if (patternToString.ContainsKey(currentPattern))
                {
                    if (stringToPattern.ContainsKey(currentString))
                    {
                    }
                }
            }


            return true;
        }
    }
}
