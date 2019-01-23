using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
804. Unique Morse Code Words
International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, 
as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. 
For example, "cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-"). 
We'll call such a concatenation, the transformation of a word.

Return the number of different transformations among all words we have.
*/

namespace LeetCodeSolutions
{
    class Nr804UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCode = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            List<string> wordsInMorseCode = new List<string>();
            foreach (string word in words)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    stringBuilder.Append(morseCode[word[i] - 97]);
                }
                wordsInMorseCode.Add(stringBuilder.ToString());
            }
            return wordsInMorseCode.Distinct().Count();
        }
    }
}
