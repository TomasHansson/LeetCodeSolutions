using System;
/*
4. FindMedianSortedArrays
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.
*/

namespace LeetCodeSolutions
{
    class Nr004FindMedianSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return FindMedian(nums2);
            else if (nums2.Length == 0)
                return FindMedian(nums1);
            else
            {
                int[] combined = new int[nums1.Length + nums2.Length];
                Array.Copy(nums1, combined, nums1.Length);
                Array.Copy(nums2, 0, combined, nums1.Length, nums2.Length);
                Array.Sort(combined);
                return FindMedian(combined);
            }
        }

        public double FindMedian(int[] numbers) // The helper-function made it a tad slower but more readable.
        {
            if (numbers.Length % 2 != 0)
                return numbers[numbers.Length / 2];
            else
                return (double)((double)numbers[numbers.Length / 2 - 1] + (double)numbers[numbers.Length / 2]) / 2;
                // Visual Studio complains that the casts are reduntant but without them the answer is incorrect.
        }
    }
}
