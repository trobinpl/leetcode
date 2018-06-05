using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeSumQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            NumArray obj = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            int r = obj.SumRange(0, 2);
            int r2 = obj.SumRange(2, 5);
            int r3 = obj.SumRange(0, 5);
            int r4 = obj.SumRange(0, 0);
            int r5 = obj.SumRange(0, 1);
            int r6 = obj.SumRange(1, 4);
            int r7 = obj.SumRange(3, 5);
            int r8 = obj.SumRange(5, 5);

            NumArray obj2 = new NumArray(new int[] { });
            
        }


    }
    public class NumArray
    {
        private int[] sums;
        public NumArray(int[] nums)
        {
            if(nums.Length == 0)
            {
                return;
            }

            sums = new int[nums.Length];
            sums[0] = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            if(i == 0)
            {
                return sums[j];
            }
            return sums[j] - sums[i - 1];
        }
    }
}
