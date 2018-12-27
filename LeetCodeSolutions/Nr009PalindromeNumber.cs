using System;
using System.Linq;

/*
9. Palindrome Number
Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.
*/

namespace LeetCodeSolutions
{
    class Nr009PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            string xString = x.ToString();
            string reversed = new string(xString.Reverse().ToArray());
            if (xString == reversed)
                return true;
            return false;
        }
    }
}
