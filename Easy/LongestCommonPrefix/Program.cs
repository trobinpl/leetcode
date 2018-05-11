using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        /*
         * Write a function to find the longest common prefix string amongst an array of strings.

           If there is no common prefix, return an empty string "".
           ["flower","flow","flight"] -> "fl"
           ["dog","racecar","car"] -> ""
         */
        static void Main(string[] args)
        {
            string lcp = LCP(new string[] { "flower", "flow", "flight", "fun", "force", "funnel" });
            string lcp1 = LCP(new string[] { "car", "flow" });
        }

        static string LCP(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            return LCP(strs, 0, strs.Length - 1);
        }

        static string LCP(string[] strs, int left, int right)
        {
            if (left == right)
            {
                return strs[left];
            }

            int middle = (left + right) / 2;
            string leftLCP = LCP(strs, left, middle);
            string rightLCP = LCP(strs, middle + 1, right);
            return CommonPrefix(leftLCP, rightLCP);
        }

        static string CommonPrefix(string s1, string s2)
        {
            int maximumCommonStringPrefixLength = Math.Min(s1.Length, s2.Length);
            string result = string.Empty;
            for (int i = 0; i < maximumCommonStringPrefixLength; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1.Substring(0, i);
                }
            }

            return s1.Substring(0, maximumCommonStringPrefixLength);
        }
    }
}
