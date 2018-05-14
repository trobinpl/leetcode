using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        /*
         * Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

           Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        */
        static void Main(string[] args)
        {
            int r = RemoveDuplicates(new int[] { 1, 2, 3, 4, 5 });
        }

        static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int distinct = 1;

            for (int i=1; i<nums.Length; i++)
            {
                if(nums[i] > nums[i - 1])
                {
                    nums[distinct] = nums[i];
                    distinct++;
                }
            }

            return distinct;
        }
    }
}
