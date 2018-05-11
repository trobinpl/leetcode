using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = RemoveElement(new[] { 2 }, 3);
        }

        static int RemoveElement(int[] nums, int val)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            int elementToDeleteIndex = -1;
            int lastGoodElementIndex = -1;
            for(int i = 0; i<nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    elementToDeleteIndex = i;
                    for(int j = elementToDeleteIndex; j<nums.Length; j++)
                    {
                        if(nums[j] != val)
                        {
                            Swap(elementToDeleteIndex, j, nums);
                            lastGoodElementIndex = elementToDeleteIndex;
                            break;
                        }
                    }
                }
                else
                {
                    lastGoodElementIndex++;
                }
            }

            if(lastGoodElementIndex == -1)
            {
                return 0;
            }

            return lastGoodElementIndex + 1;
        }

        static void Swap(int i1, int i2, int[] nums)
        {
            int temp = nums[i2];
            nums[i2] = nums[i1];
            nums[i1] = temp;
        }
    }
}
