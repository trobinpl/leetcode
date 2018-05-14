using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        /*
         * Say you have an array for which the ith element is the price of a given stock on day i.

           If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

           Note that you cannot sell a stock before you buy one.
           [7,1,5,3,6,4] -> 5 (6 - 1)
           [7,6,4,3,1] -> 0 (no transaction)
        */
        static void Main(string[] args)
        {
            int r = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            int r2 = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }

        static int[] TransformToChangeInTime(int[] nums)
        {
            int last = nums[0];
            for(int i=1; i<=nums.Length - 1; i++)
            {
                int diff = nums[i] - last;
                last = nums[i];
                nums[i] = diff;
            }

            nums[0] = 0;

            return nums;
        }

        static int MaxProfit(int[] prices)
        {
            if(prices.Length == 0)
            {
                return 0;
            }
            int[] changeInPricesInTime = TransformToChangeInTime(prices);
            int potentialProfit = MaxSubarray(changeInPricesInTime, 0, changeInPricesInTime.Length - 1);

            return (potentialProfit >= 0) ? potentialProfit : 0;
        }

        static int MaxSubarray(int[] nums, int low, int high)
        {
            if(low == high)
            {
                return nums[low];
            }
            else
            {
                int mid = (low + high) / 2;
                int leftSum = MaxSubarray(nums, low, mid);
                int rightSum = MaxSubarray(nums, mid + 1, high);
                int crossingSum = MaxCrossingSubarray(nums, low, mid, high);

                return Math.Max(leftSum, Math.Max(rightSum, crossingSum));
            }
        }

        static int MaxCrossingSubarray(int[] nums, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int rightSum = int.MinValue;
            int sum = 0;

            for(int i=mid; i>=low; i--)
            {
                sum = sum + nums[i];
                if(sum > leftSum)
                {
                    leftSum = sum;
                }
            }

            sum = 0;

            for(int i = mid + 1; i <= high; i++)
            {
                sum = sum + nums[i];
                if(sum > rightSum)
                {
                    rightSum = sum;
                }
            }

            return leftSum + rightSum;
        }
    }
}
