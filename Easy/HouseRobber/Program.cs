using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Rob(new int[] { 1, 2, 3, 1 });
            int r2 = Rob(new int[] { 2, 7, 9, 3, 1 });
            int r3 = Rob(new int[] { });
            int r4 = Rob(new int[] { 1 });
        }

        static public int Rob(int[] nums)
        {
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i % 2 == 0)
                {
                    firstSum += nums[i];
                }
                else
                {
                    secondSum += nums[i];
                }
            }
            return Math.Max(firstSum, secondSum);
        }
    }
}
