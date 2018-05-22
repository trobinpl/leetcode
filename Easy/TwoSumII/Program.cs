using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }

        static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 0)
            {
                return new int[] { };
            }

            int s = 0;
            int e = numbers.Length - 1;

            while(s < e)
            {
                int sum = numbers[s] + numbers[e];
                if(sum > target)
                {
                    e--;
                }
                if(sum < target)
                {
                    s++;
                }
                if(sum == target)
                {
                    return new int[] { s + 1, e + 1 };
                }
            }

            return new int[] { };
        }
    }
}
