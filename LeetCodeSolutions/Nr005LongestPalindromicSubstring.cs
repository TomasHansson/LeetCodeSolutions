/*
5. Longest Palindromic Substring
Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.
*/

namespace LeetCodeSolutions
{
    class Nr005LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s) // The solution works but is too slow. Will need to re-work in the future.
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            if (s.Length < 2)
                return s;

            int longest = 0;
            string longestString = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s.Substring(i, j - i + 1).Equals(ReverseString(s.Substring(i, j - i + 1))) && s.Substring(i, j - i + 1).Length > longest)
                    {
                        longest = s.Substring(i, j - i + 1).Length;
                        longestString = s.Substring(i, j - i + 1);
                    }
                }
            }
            return longestString;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            System.Array.Reverse(arr);
            return new string(arr);
        }
    }
}
