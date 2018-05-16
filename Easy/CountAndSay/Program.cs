using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAndSay
{
    class Program
    {
        /*
         * The count-and-say sequence is the sequence of integers with the first five terms as following:
         * 1. 1
         * 2. 11 (one 1)
         * 3. 21 (two 1)
         * 4. 1211 (one 2 one 1)
         * 5. 111221
         */
        static void Main(string[] args)
        {
            string r = CountAndSay(6);
        }

        static string CountAndSay(int n)
        {
            if(n == 1)
            {
                return "1";
            }

            StringBuilder currentStringBuilder = new StringBuilder();
            string previous = CountAndSay(n - 1);
            char current = previous[0];
            int counter = 0;
            for(int i=0; i<previous.Length; i++)
            {
                if(previous[i] == current)
                {
                    counter++;
                }
                else
                {
                    currentStringBuilder.AppendFormat("{0}{1}", counter, current);
                    counter = 1;
                    current = previous[i];
                }

                if(i == previous.Length - 1)
                {
                    currentStringBuilder.AppendFormat("{0}{1}", counter, current);
                }
            }

            return currentStringBuilder.ToString();
        }
    }
}
