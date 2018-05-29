using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsAnagram("anagram", "nagaram");
            bool r2 = IsAnagram("rat", "car");
        }

        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            var sCount = CountChars(s);
            var tCount = CountChars(t);
            foreach(var pair in sCount)
            {
                if(!tCount.ContainsKey(pair.Key) || tCount[pair.Key] != pair.Value)
                {
                    return false;
                }
            }
            return true;
        }

        static Dictionary<char, int> CountChars(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }

            return charCount;
        }
    }
}
