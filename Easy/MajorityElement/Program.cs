using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MajorityElement(new int[] { 3, 2, 3 });
            int r2 = MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            int r3 = MajorityElement(new int[] { 1 });
            int r4 = MajorityElement(new int[] { 1, 1, 2, 2 });
        }

        static int MajorityElement(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray();
            int majorityTreshold = nums.Length / 2;
            int currentMajorityElement = nums[0];
            int currentMajorityCount = 0;
            for (int i = 0; i<nums.Length; i++)
            {
                if(currentMajorityElement == nums[i])
                {
                    currentMajorityCount++;
                    if (currentMajorityCount > majorityTreshold)
                    {
                        return currentMajorityElement;
                    }
                }
                else
                {
                    currentMajorityElement = nums[i];
                    currentMajorityCount = 1;
                }
            }

            return currentMajorityElement;
        }
    }
}
