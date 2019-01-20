using System.Linq;

/*
771. Jewels and Stones
You're given strings J representing the types of stones that are jewels, and S representing the stones you have. 
Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. 
Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/

namespace LeetCodeSolutions
{
    class Nr771JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int numberOfJewels = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (J.Contains(S[i]))
                    numberOfJewels++;
            }
            return numberOfJewels;
        }
    }
}
