using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            Rotate(nums1, 6);
        }

        static void Rotate(int[] nums, int k)
        {
            if(nums.Length == 0)
            {
                return;
            }

            if(k <= 0)
            {
                return;
            }

            Rot(nums, k);
        }

        static int[] Rot(int[] nums, int k)
        {
            if (k == 1)
            {
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    Swap(nums, i, i - 1);
                }
            }

            if(k > 1)
            {
                nums = Rot(Rot(nums, k - 1), 1);
            }

            return nums;
        }

        static void Swap(int[] nums, int source, int target)
        {
            int temp = nums[target];
            nums[target] = nums[source];
            nums[source] = temp;
        }
    }
}
