using System;

/*
11. Container With Most Water
Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate(i, ai) n vertical lines are drawn such that the two endpoints of line i is at(i, ai) and(i, 0). 
Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.
*/

namespace LeetCodeSolutions
{
    class Nr011ContainerWithMostWater
    {
        public int MaxArea(int[] height) // The solution works but is too slow. Will need to re-work in the future.
        {
            int largestArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    if (j != i)
                    {
                        int largestHeight = Math.Min(height[i], height[j]);
                        int width = Math.Abs(i - j);
                        int area = largestHeight * width;
                        largestArea = area > largestArea ? area : largestArea;
                    }
                }
            }
            return largestArea;
        }
    }
}
