using System.Collections.Generic;
using System.Linq;

/*
942. DI String Match
Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.

Return any permutation A of [0, 1, ..., N] such that for all i = 0, ..., N-1:

If S[i] == "I", then A[i] < A[i+1]
If S[i] == "D", then A[i] > A[i+1]
*/

namespace LeetCodeSolutions
{
    class Nr942DIStringMatch
    {
        public int[] DiStringMatch(string S)
        {
            List<int> temporaryHolder = new List<int>();
            List<int> result = new List<int>();
            for (int i = 0; i < S.Length + 1; i++)
            {
                temporaryHolder.Add(i);
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    result.Add(temporaryHolder[0]);
                    temporaryHolder.RemoveAt(0);
                }
                else if (S[i] == 'D')
                {
                    result.Add(temporaryHolder.Last());
                    temporaryHolder.RemoveAt(temporaryHolder.Count - 1);
                }
            }
            result.Add(temporaryHolder.First());
            return result.ToArray();
        }
    }
}
