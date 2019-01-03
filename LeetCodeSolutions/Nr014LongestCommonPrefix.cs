using System;

/*
14. Longest Common Prefix
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

namespace LeetCodeSolutions
{
    class Nr014LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
            string result = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char testChar = strs[0][i];
                bool allCommon = true;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != testChar)
                    {
                        allCommon = false;
                        break;
                    }
                }
                if (allCommon)
                    result += testChar;
                else
                    break;
            }
            return result;
        }
    }
}
