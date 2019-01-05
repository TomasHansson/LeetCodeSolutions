using System.Collections;

/*
20. Valid Parentheses
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.

Note that an empty string is also considered valid.
*/

namespace LeetCodeSolutions
{
    class Nr020ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s == null || s.Length == 0)
                return true;

            int numberOfOpenParanthes = 0;
            int numberOfOpenCurly = 0;
            int numberOfOpenBracket = 0;
            Stack openedTypes = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    numberOfOpenParanthes++;
                    openedTypes.Push((int)Type.Paranthes);
                }
                if (s[i] == '{')
                {
                    numberOfOpenCurly++;
                    openedTypes.Push((int)Type.Curly);
                }
                if (s[i] == '[')
                {
                    numberOfOpenBracket++;
                    openedTypes.Push((int)Type.Bracket);
                }
                if (s[i] == ')')
                {
                    if (numberOfOpenParanthes == 0 || (int)openedTypes.Pop() != (int)Type.Paranthes)
                        return false;
                    numberOfOpenParanthes--;
                }
                if (s[i] == '}')
                {
                    if (numberOfOpenCurly == 0 || (int)openedTypes.Pop() != (int)Type.Curly)
                        return false;
                    numberOfOpenCurly--;
                }
                if (s[i] == ']')
                {
                    if (numberOfOpenBracket == 0 || (int)openedTypes.Pop() != (int)Type.Bracket)
                        return false;
                    numberOfOpenBracket--;
                }
            }
            return openedTypes.Count == 0;
        }

        public enum Type
        {
            Paranthes = 1,
            Curly = 2,
            Bracket = 3
        }
    }
}
