using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        }

        static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int desiredSum = (n * (n + 1)) / 2;

            int actualSum = 0;

            foreach(int num in nums)
            {
                actualSum += num;
            }

            return desiredSum - actualSum;
        }
    }
}
