using System;
using System.Collections.Generic;

/*
1. Two Sum
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/

namespace LeetCodeSolutions
{
    class Nr001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int indexOfFirstNumber = 0;
            int indexOfSecondNumber = 0;
            Dictionary<int, int> complements = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    complements.Add(target - nums[i], i);
                }
                catch (Exception)
                {
                    // Don't do anything if the complement already exists.
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (complements.ContainsKey(nums[i]) && i != complements[nums[i]])
                {
                    indexOfFirstNumber = i;
                    indexOfSecondNumber = complements[nums[i]];
                    break;
                }
            }
            return new int[] { indexOfFirstNumber, indexOfSecondNumber };
        }
    }
}
