using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = NumJewelsInStones("aA", "aAAbbbb");
        }

        static public int NumJewelsInStones(string J, string S)
        {
            int counter = 0;
            HashSet<char> jewels = new HashSet<char>(J);
            foreach(char stone in S)
            {
                if (jewels.Contains(stone))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
