/*
709. To Lower Case
Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
*/

namespace LeetCodeSolutions
{
    class Nr709ToLowerCase
    {
        public string ToLowerCase(string str)
        {
            string result = "";
            foreach (char letter in str)
            {
                if (('A' <= letter) && (letter <= 'Z'))
                {
                    result = result + (char)(letter + 32);
                }
                else
                {
                    result = result + letter;
                }
            }
            return result;
        }
    }
}
