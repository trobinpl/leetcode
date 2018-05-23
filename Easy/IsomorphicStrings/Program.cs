using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsomorphicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsIsomorphic("paper", "title");
            bool r2 = IsIsomorphic("foo", "bar");
            bool r5 = IsIsomorphic("ab", "aa");
            bool r3 = IsIsomorphic("", "");
            bool r4 = IsIsomorphic(null, null);
        }

        static public bool IsIsomorphic(string s, string t)
        {
            if(s == null || t == null || s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> map = new Dictionary<char, char>();

            for(int i=0; i<s.Length; i++)
            {
                char corresponding = t[i];
                if (map.ContainsKey(s[i]))
                {
                    if(corresponding != map[s[i]])
                    {
                        return false;
                    }
                }
                else if (map.ContainsValue(t[i]))
                {
                    return false;
                }
                else
                {
                    map.Add(s[i], t[i]);
                }
            }

            return true;
        }
    }
}
