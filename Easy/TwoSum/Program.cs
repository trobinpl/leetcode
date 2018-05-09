using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        /*
           Given an array of integers, return indices of the two numbers such that they add up to a specific target.

           You may assume that each input would have exactly one solution, and you may not use the same element twice.
           [2, 7, 11, 15], target = 9 -> Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1]
        */
        static void Main(string[] args)
        {
            int[] A = { 3, 2, 3 };
            int[] indicies = Sum(A, 6);
            Console.WriteLine($"[{indicies[0]}, {indicies[1]}]");

            Console.ReadKey();
        }

        static int[] Sum(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>();
            
            // 1. y = x - t
            // 2. find y in A
            // better: use hasmap instead of arrays!
            for (int i = 0; i < nums.Length; i++)
            {
                int y = target - nums[i];
                if (numsDict.ContainsKey(y))
                {
                    return new int[] { numsDict[y], i };
                }

                if (!numsDict.ContainsKey(nums[i]))
                {
                    numsDict.Add(nums[i], i);
                }
            }

            return new int[2];
        }
    }
}
