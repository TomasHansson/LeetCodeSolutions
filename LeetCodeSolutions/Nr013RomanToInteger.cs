/*
13. Roman To Integer
Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
*/

namespace LeetCodeSolutions
{
    class Nr013RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i == s.Length - 1)
                        result++;
                    else if (s[i + 1] == 'X' || s[i + 1] == 'V')
                        result--;
                    else
                        result++;
                }
                else if (s[i] == 'V')
                    result += 5;
                else if (s[i] == 'X')
                {
                    if (i == s.Length - 1)
                        result += 10;
                    else if (s[i + 1] == 'L' || s[i + 1] == 'C')
                        result -= 10;
                    else
                        result += 10;
                }
                else if (s[i] == 'L')
                    result += 50;
                else if (s[i] == 'C')
                {
                    if (i == s.Length - 1)
                        result += 100;
                    else if (s[i + 1] == 'D' || s[i + 1] == 'M')
                        result -= 100;
                    else
                        result += 100;
                }
                else if (s[i] == 'D')
                    result += 500;
                else if (s[i] == 'M')
                    result += 1000;
            }
            return result;
        }
    }
}
