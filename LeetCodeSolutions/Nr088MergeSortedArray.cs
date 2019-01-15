/*
88. Merge Sorted Array
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:
The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
*/

namespace LeetCodeSolutions
{
    class Nr088MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int currentPositionNums1 = m - 1;
            int currentPositionNums2 = n - 1;
            int insertPosition = m + n - 1;

            while (currentPositionNums1 >= 0 && currentPositionNums2 >= 0)
            {
                if (nums1[currentPositionNums1] >= nums2[currentPositionNums2])
                {
                    nums1[insertPosition--] = nums1[currentPositionNums1];
                    nums1[currentPositionNums1--] = 0;
                }
                else
                {
                    nums1[insertPosition--] = nums2[currentPositionNums2--];
                }
            }

            while (currentPositionNums2 >= 0)
            {
                nums1[insertPosition--] = nums2[currentPositionNums2--];
            }
        }
    }
}
