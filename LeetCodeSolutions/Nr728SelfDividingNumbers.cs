using System.Collections.Generic;

/*
728. Self Dividing Numbers
A self-dividing number is a number that is divisible by every digit it contains.

For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

Also, a self-dividing number is not allowed to contain the digit zero.

Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
*/

namespace LeetCodeSolutions
{
    class Nr728SelfDividingNumbers
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                string numberAsString = i.ToString();
                bool dividingNumber = true;
                for (int j = 0; j < numberAsString.Length; j++)
                {
                    if (i % char.GetNumericValue(numberAsString[j]) != 0)
                        dividingNumber = false;
                }
                if (dividingNumber)
                    result.Add(i);
            }
            return result;
        }
    }
}
