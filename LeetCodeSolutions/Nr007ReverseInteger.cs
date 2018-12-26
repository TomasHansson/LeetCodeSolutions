using System;
using System.Linq;

/*
7. Reverse Integer
Given a 32-bit signed integer, reverse digits of an integer.
*/

namespace LeetCodeSolutions
{
    class Nr007ReverseInteger
    {
        public int Reverse(int x)
        {
            int sign = 1;
            string xString = x.ToString();
            if (xString[0] == '-')
            {
                sign = -1;
                xString = xString.Substring(1);
            }
            xString = new string(xString.ToCharArray().Reverse().ToArray());
            try
            {
                return Convert.ToInt32(xString) * sign;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
