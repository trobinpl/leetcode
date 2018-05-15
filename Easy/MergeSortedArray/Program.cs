using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    class Program
    {
        /*
         * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
         * - The number of elements initialized in nums1 and nums2 are m and n respectively.
         * - You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
         * nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6] n = 3 -> [1,2,2,3,5,6]
         */
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 0, 0, 0, 0, 0 };
            int[] b = new int[] { 2, 3, 4, 5, 6 };
            Merge(a, 1, b, 5);
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] tempA = new int[m];

            for(int k=0; k < m; k++)
            {
                tempA[k] = nums1[k];
            }

            int index = 0;
            int i = 0;
            int j = 0;
            while (i < m && j < n)
            {
                if (tempA[i] <= nums2[j])
                {
                    nums1[index] = tempA[i];
                    i++;
                }
                else
                {
                    nums1[index] = nums2[j];
                    j++;
                }
                index++;
            }

            while (i < m)
            {
                nums1[index] = tempA[i];
                i++;
                index++;
            }
            while (j < n)
            {
                nums1[index] = nums2[j];
                j++;
                index++;
            }
        }
    }
}
