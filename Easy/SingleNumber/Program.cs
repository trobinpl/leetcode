using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    class Program
    {
        /*
         * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
         */
        static void Main(string[] args)
        {
            int r = SingleNumberMath(new int[] { 4, 1, 2, 1, 2 });
            int r2 = SingleNumberMath(new int[] { 2, 2, 1 });
            int r3 = SingleNumberMath(new int[] { 1, 1 });
            int r4 = SingleNumberMath(new int[] { 1 });
        }

        /* 2*a + 2*b + 2*c (sum of distinct values of nums times 2) - 2*a+2*b+c (every but one value twice) = c */
        static int SingleNumberMath(int[] nums)
        {
            int distinctSum = 2 * nums.Distinct().Sum();
            int sum = nums.Sum();

            return distinctSum - sum;
        }

        static int SingleNumber(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }
            nums = nums.OrderBy(x => x).ToArray();
            for(int i = 1; i< nums.Length; i += 2)
            {
                if(nums[i - 1] != nums[i])
                {
                    return nums[i - 1];
                }
                if(i == nums.Length - 2)
                {
                    return nums[nums.Length - 1];
                }
            }

            return -1;
        }

        static void Sort(int[] nums, int start, int end)
        {
            if(end > start)
            {
                int middle = (start + end) / 2;
                Sort(nums, start, middle);
                Sort(nums, middle + 1, end);
                Merge(ref nums, start, middle, end);
            }
        }

        static void Merge(ref int[] nums, int start, int middle, int end)
        {
            int[] result = new int[end - start + 1];
            int i = 0;
            int j = 0;
            int k = 0;
            int n1 = middle - start + 1;
            int n2 = end - middle;

            while (i < n1 && j < n2)
            {
                if(nums[start + i] <= nums[middle + 1 + j])
                {
                    result[k] = nums[start + i];
                    i++;
                }
                else
                {
                    result[k] = nums[middle + 1 + j];
                    j++;
                }
                k++;
            }

            while(i < n1)
            {
                result[k] = nums[start + i];
                i++;
                k++;
            }

            while(j < n2)
            {
                result[k] = nums[middle + 1 + j];
                j++;
                k++;
            }

            nums = result;
        }
    }
}
