using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = AddBinary("1", "111");
        }

        static string AddBinary(string a, string b)
        {
            StringBuilder resultSb = new StringBuilder();
            // To make code easier I make sure, that I always add shorter number to longer -> 100 + 10, even if a = 10 and b = 100
            if(b.Length > a.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }

            int argumentLength = a.Length;
            IEnumerable<char> prependedB;
            string tempB = b;
            for(int i=0; i < argumentLength - b.Length; i++)
            {
                prependedB = tempB.Prepend('0');
                tempB = new string(prependedB.ToArray());
            }
            b = tempB;

            int overflow = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int x = int.Parse(a[i].ToString());
                int y = int.Parse(b[i].ToString());

                int sum = x + y + overflow;
                overflow = sum > 1 ? 1 : 0;

                resultSb.Insert(0, sum % 2);
            }

            if(overflow == 1)
            {
                resultSb.Insert(0, "1");
            }

            return resultSb.ToString();

        }
    }
}
