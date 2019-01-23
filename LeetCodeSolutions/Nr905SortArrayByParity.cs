using System.Collections.Generic;

/*
905. Sort Array By Parity
Given an array A of non-negative integers, return an array consisting of all the even elements of A, 
followed by all the odd elements of A.

You may return any answer array that satisfies this condition.
*/

namespace LeetCodeSolutions
{
    class Nr905SortArrayByParity
    {
        public int[] SortArrayByParity(int[] A)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    result.Insert(0, A[i]);
                else
                    result.Add(A[i]);
            }
            return result.ToArray();
        }
    }
}
