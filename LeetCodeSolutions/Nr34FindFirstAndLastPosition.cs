/*
34. Find First and Last Position of Element in Sorted Array
Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

Your algorithm's runtime complexity must be in the order of O(log n).

If the target is not found in the array, return [-1, -1].
*/

namespace LeetCodeSolutions
{
    class Nr34FindFirstAndLastPosition
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0 || target > nums[nums.Length - 1] || target < nums[0])
                return new int[] { -1, -1 };

            int lowerIndex = -1;
            int upperIndex = -1;
            int lowerBound = 0;
            int upperBound = nums.Length - 1;
            while (lowerBound <= upperBound)
            {
                int searchIndex = (upperBound + lowerBound) / 2;
                if (nums[searchIndex] == target)
                {
                    lowerIndex = searchIndex;
                    upperIndex = searchIndex;
                    for (int i = lowerIndex - 1; i >= 0; i--)
                    {
                        if (nums[i] == target)
                            lowerIndex = i;
                        else
                            break;
                    }
                    for (int i = upperIndex + 1; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                            upperIndex = i;
                        else
                            break;
                    }
                    return new int[] { lowerIndex, upperIndex };
                }
                else if (nums[searchIndex] > target)
                    upperBound = searchIndex - 1;
                else
                    lowerBound = searchIndex + 1;
            }

            return new int[] { lowerIndex, upperIndex };
        }
    }
}
