using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            int r2 = MaxSubArray(new int[] { 0, -6, 4, -2, 3, -2 });
        }

        static int MaxSubArray(int[] nums)
        {
            return MaxSubArray(nums, 0, nums.Length - 1);

        }

        static int MaxSubArray(int[] nums, int low, int high)
        {
            if (low == high)
            {
                return nums[low];
            }
            else
            {
                int mid = (low + high) / 2;
                int leftSum = MaxSubArray(nums, low, mid);
                int rightSum = MaxSubArray(nums, mid + 1, high);
                int crossSum = MaxCrossingSubarray(nums, low, mid, high);

                return Math.Max(leftSum, Math.Max(rightSum, crossSum));
            }
        }

        static int MaxCrossingSubarray(int[] nums, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int rightSum = int.MinValue;
            int maxLeft = -1;
            int maxRight = -1;
            int sum = 0;
            for (int i = mid; i >= low; i--)
            {
                sum = sum + nums[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }
            sum = 0;
            for (int i = mid + 1; i <= high; i++)
            {
                sum = sum + nums[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = i;
                }
            }

            return leftSum + rightSum;
        }
    }
}
