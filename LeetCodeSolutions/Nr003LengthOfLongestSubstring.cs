using System.Collections.Generic;
using System.Linq;

/*
3. LengthOfLongestSubstring
Given a string, find the length of the longest substring without repeating characters.
*/

namespace LeetCodeSolutions
{
    class Nr003LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0 || s.Length == 1)
                return s.Length;

            List<int> substringLengths = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                HashSet<char> foundLetters = new HashSet<char>();
                char currentChar = s[i];
                foundLetters.Add(currentChar);
                int counter = i;
                while (counter + 1 != s.Length && !foundLetters.Contains(s[counter + 1]))
                {
                    currentChar = s[++counter];
                    foundLetters.Add(currentChar);
                }
                substringLengths.Add(counter - i + 1);
            }
            return substringLengths.Max();
        }
    }
}
