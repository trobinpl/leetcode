using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementstrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = StrStr("hlello", "ll");
            int r2 = StrStr("aaaa", "bz");
            int r3 = StrStr("aaaa", "aaaa");
            int r4 = StrStr("", "aaaa");
            int r5 = StrStr("bbba", "aa");
        }

        static int StrStr(string haystack, string needle)
        {
            if (needle == string.Empty)
            {
                return 0;
            }

            if(haystack == string.Empty)
            {
                return -1;
            }

            int needleCounter = 0;
            for(int i=0; i<haystack.Length; i++)
            {
                if(haystack[i] == needle[needleCounter])
                {
                    while(needleCounter < needle.Length)
                    {
                        if(i + needleCounter < haystack.Length && haystack[i + needleCounter] == needle[needleCounter])
                        {
                            needleCounter++;
                        }
                        else
                        {
                            needleCounter = 0;
                            break;
                        }
                    }
                }

                if(needleCounter == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
