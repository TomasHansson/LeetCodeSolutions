/*
27. Remove Element
Given an array nums and a value val, remove all instances of that value in-place and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.
*/

namespace LeetCodeSolutions
{
    class Nr027RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int valuesKept = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    valuesKept++;
                else if (nums[i] == val && i != nums.Length - 1)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != val)
                        {
                            nums[i] = nums[j];
                            nums[j] = val;
                            valuesKept++;
                            break;
                        }
                    }
                }
            }
            return valuesKept;
        }
    }
}
