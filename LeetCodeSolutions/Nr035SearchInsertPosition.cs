/*
35. Search Insert Position
Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.
*/

namespace LeetCodeSolutions
{
    class Nr035SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (target < nums[0])
                return 0;
            if (target > nums[nums.Length - 1])
                return nums.Length;

            int insertIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] < target)
                    insertIndex = i;
                else
                    return insertIndex + 1;
            }

            return insertIndex;
        }
    }
}
