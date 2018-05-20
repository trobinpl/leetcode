using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r = MyAtoi("trolo");
            int r2 = MyAtoi("              -142");
            //int r3 = MyAtoi("256");
            //int r4 = MyAtoi("2");
            int r5 = MyAtoi("-91283472332");
            int r6 = MyAtoi("91283472332");
            int r7 = MyAtoi("words and 987");
            int r8 = MyAtoi("4193 with words");
            int r9 = MyAtoi("3.1415");
            int r10 = MyAtoi("+1");
            int r11 = MyAtoi("  0000000000012345678");
            int r12 = MyAtoi("+-8");
        }

        static public int MyAtoi(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int negative = 1;
            int startOfNumberIndex = 0;
            int endOfNumberIndex = 0;
            str = str.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (currentChar == '-')
                {
                    negative = -1;
                    startOfNumberIndex = 1;
                    continue;
                }
                if(currentChar == '+')
                {
                    startOfNumberIndex = 1;
                    continue;
                }
                if (char.IsDigit(currentChar))
                {
                    endOfNumberIndex++;
                }
                if (!char.IsDigit(currentChar) )
                {
                    break;
                }
            }

            if (endOfNumberIndex == 0)
            {
                return 0;
            }

            double result = 0;
            string number = str.Substring(startOfNumberIndex, endOfNumberIndex);

            foreach (char c in number)
            {
                result = result * 10 + ParseNumber(c);

                if (result * negative < int.MinValue)
                {
                    return int.MinValue;
                }
                if (result * negative > int.MaxValue)
                {
                    return int.MaxValue;
                }
            }
            return (int)result * negative;
        }

        static public int ParseNumber(char c)
        {
            if (!char.IsDigit(c))
            {
                return -1;
            }

            switch (c)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return -1;
            }
        }
    }
}
