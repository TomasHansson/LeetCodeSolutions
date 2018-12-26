using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
8. String to Integer (atoi)
Implement atoi which converts a string to an integer.

The function first discards as many whitespace characters as necessary until the first non-whitespace character is found.
Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace 
characters, no conversion is performed.

If no valid conversion could be performed, a zero value is returned.
*/

namespace LeetCodeSolutions
{
    class Nr008StringToInteger
    {
        public int MyAtoi(string str)
        {
            str = str.TrimStart(' ');
            if (str == "")
                return 0;
            int sign = 1;
            if (str[0] == '+' || str[0] == '-')
            {
                if (str[0] == '-')
                    sign = -1;
                str = str.Substring(1);
            }
            string resultString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]) == false)
                    break;
                else
                    resultString = resultString + str[i];
            }
            if (resultString.Length == 0)
                return 0;
            try
            {
                return Convert.ToInt32(resultString) * sign;
            }
            catch (Exception)
            {
                if (sign == -1)
                    return int.MinValue;
                else
                    return int.MaxValue;
            }
        }
    }
}
