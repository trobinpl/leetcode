using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = TitleToNumber("A");
            int r2 = TitleToNumber("EB");
            int r3 = TitleToNumber("ZY");
            int r4 = TitleToNumber("AEF");
            int r5 = TitleToNumber("AZ");
        }

        public static int TitleToNumber(string s)
        {
            int result = 0;
            double i = s.Length - 1;
            foreach(char c in s)
            {
                result += (c - 64) * (int)Math.Pow(26.0, i);
                i--;
            }

            return result;
        }
    }
}
