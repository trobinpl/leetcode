using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(r);
        }

        public static void MoveZeroes(int[] nums)
        {
            for (int lastZero = 0, i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    Swap(nums, lastZero++, i);
                }
            }
        }

        public static void Swap(int[] nums, int source, int target)
        {
            int temp = nums[target];
            nums[target] = nums[source];
            nums[source] = temp;
        }
    }
}
