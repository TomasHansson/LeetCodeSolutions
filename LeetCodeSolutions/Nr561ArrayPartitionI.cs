using System;

/*
561. Array Partition I
Given an array of 2n integers, your task is to group these integers into n pairs of integer, 
say (a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.

Note:
n is a positive integer, which is in the range of [1, 10000].
All the integers in the array will be in the range of [-10000, 10000].
*/

namespace LeetCodeSolutions
{
    class Nr561ArrayPartitionI
    {
        public int ArrayPairSum(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                result += Math.Min(nums[i], nums[i + 1]);
            }
            return result;
        }
    }
}
