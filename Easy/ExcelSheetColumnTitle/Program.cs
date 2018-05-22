using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = ConvertToTitle(701);
            string r2 = ConvertToTitle(1020);
            string r3 = ConvertToTitle(52);
            string r4 = ConvertToTitle(104);
            string r5 = ConvertToTitle(208);
        }

        public static string ConvertToTitle(int n)
        {
            Stack<char> letters = new Stack<char>();
            while(n > 0)
            {
                n--;
                int letterNumber = n % 26;
                letters.Push((char)('A' + letterNumber));
                n = n / 26;
            }

            return new string(letters.ToArray());
        }
    }
}
