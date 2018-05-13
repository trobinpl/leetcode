using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
        }

        static int SearchInsert(int[] nums, int target)
        {
            int searchResult = BinarySearch(nums, target);
            if(searchResult == -1)
            {
                for(int i=nums.Length - 1; i>=0; i--)
                {
                    if(nums[i] < target)
                    {
                        return i + 1;
                    }
                    if(i == 0)
                    {
                        return 0;
                    }
                }
            }

            return searchResult;
        }

        static int BinarySearch(int[] nums, int target)
        {
            int index = Search(nums, 0, nums.Length - 1, target);
            return index;
        }

        static int Search(int[] nums, int start, int end, int target)
        {
            int middle = (start + end) / 2;

            if (nums.Length == 0 || start == end)
            {
                return -1;
            }

            if(target < nums[middle])
            {
                end = middle;
            }
            else
            {
                start = middle + 1;
            }

            if (target == nums[middle])
            {
                return middle;
            }

            return Search(nums, start, end, target);
        }
    }
}
