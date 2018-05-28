using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = ContainsDuplicateSort(new int[] { 1, 2, 3, 1 });
            bool r2 = ContainsDuplicateSort(new int[] { 9, 7, 1, 2, 3, 4 });
            bool r3 = ContainsDuplicateSort(new int[] { 1, 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

            bool r4 = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            bool r5 = ContainsDuplicate(new int[] { 9, 7, 1, 2, 3, 4 });
            bool r6 = ContainsDuplicate(new int[] { 1, 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        }

        static public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> values = new HashSet<int>();
            for(int i=0; i<nums.Length; i++)
            {
                if (!values.Add(nums[i]))
                {
                    return true;
                }
                
            }

            return false;
        }

        static public bool ContainsDuplicateSort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
            for(int i=1; i < nums.Length; i++)
            {
                if(nums[i - 1] == nums[i])
                {
                    return true;
                }
            }

            return false;
        }

        static public void Sort(int[] nums, int s, int e)
        {
            if (s < e)
            {
                int m = s + (e - s) / 2;
                Sort(nums, s, m);
                Sort(nums, m + 1, e);
                Merge(nums, s, m, e);
            }
        }

        static public void Merge(int[] nums, int s, int m, int e)
        {
            int i, j, k = 0;
            int n1 = m - s + 1;
            int n2 = e - m;

            int[] L1 = new int[n1];
            int[] L2 = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L1[i] = nums[s + i];
            }

            for (j = 0; j < n2; j++)
            {
                L2[j] = nums[m + 1 + j];
            }

            i = 0;
            j = 0;
            k = s;
            while(i < n1 && j < n2)
            {
                if(L1[i] <= L2[j])
                {
                    nums[k] = L1[i];
                    i++;
                }
                else
                {
                    nums[k] = L2[j];
                    j++;
                }
                k++;
            }

            while(i < n1)
            {
                nums[k] = L1[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                nums[k] = L2[j];
                j++;
                k++;
            }
        }
    }
}
