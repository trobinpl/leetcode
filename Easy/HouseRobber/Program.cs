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
            int r4 = Rob(new int[] { 226, 174, 214, 16, 218, 48, 153, 131, 128, 17, 157, 142, 88, 43, 37, 157, 43, 221, 191, 68, 206, 23, 225, 82, 54, 118, 111, 46, 80, 49, 245, 63, 25, 194, 72, 80, 143, 55, 209, 18, 55, 122, 65, 66, 177, 101, 63, 201, 172, 130, 103, 225, 142, 46, 86, 185, 62, 138, 212, 192, 125, 77, 223, 188, 99, 228, 90, 25, 193, 211, 84, 239, 119, 234, 85, 83, 123, 120, 131, 203, 219, 10, 82, 35, 120, 180, 249, 106, 37, 169, 225, 54, 103, 55, 166, 124 });
        }

        static public int Rob(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            if(nums.Length == 1)
            {
                return nums[0];
            }
            if(nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            List<int> totals = new List<int>() { nums[0], Math.Max(nums[0], nums[1]) };
            
            for(int i = 2; i<nums.Length; i++)
            {
                totals.Add(Math.Max(nums[i] + totals[i - 2], totals[i - 1]));
            }

            return totals.Last();
        }

        static int RobValue(int[] nums, int start)
        {
            if(nums.Length - start == 1)
            {
                return nums[start];
            }

            if(nums.Length - start == 2)
            {
                return Math.Max(nums[start], nums[start+1]);
            }

            int oneChoice = nums[start];
            int secondChoice = nums[start + 1];

            if(start + 2 < nums.Length)
            {
                oneChoice += RobValue(nums, start + 2);
            }

            if(start + 1 + 2 < nums.Length)
            {
                secondChoice += RobValue(nums, start + 1 + 2);
            }

            return Math.Max(oneChoice, secondChoice);
        }
    }
}
