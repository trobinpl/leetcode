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
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] a = Merge(nums1, nums2);
            nums1 = CombineArrays(nums1, nums2, m);
        }

        //static int[] Sort(int[] array, int start, int end)
        //{
        //    if(array.Length == 1)
        //    {
        //        return array;
        //    }

        //    int mid = (start + end) / 2;
        //    int[] left = Sort(array, start, mid);
        //    int[] right = Sort(array, mid + 1, end);
        //}

        static int[] Merge(int[] a, int[] b)
        {
            int index = 0;
            int[] result = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            while(i < a.Length && j < b.Length)
            {
                if(a[i] < b[j])
                {
                    result[index] = a[i];
                    i++;
                }
                else
                {
                    result[index] = b[j];
                    j++;
                }
                index++;
            }

            while(i < a.Length)
            {
                result[index] = a[i];
                i++;
                index++;
            }

            while(j < b.Length)
            {
                result[index] = b[j];
                j++;
                index++;
            }

            return result;
        }

        static int[] CombineArrays(int[] a, int[] b, int numberOfNonEmptyElementsInA)
        {
            for(int i=0; i<b.Length; i++)
            {
                a[numberOfNonEmptyElementsInA + i] = b[i]; 
            }
            return a;
        }
    }
}
