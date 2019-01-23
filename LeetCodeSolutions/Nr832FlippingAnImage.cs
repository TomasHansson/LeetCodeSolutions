/*
832. Flipping an Image
Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed. 
For example, flipping [1, 1, 0] horizontally results in [0, 1, 1].

To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. 
For example, inverting [0, 1, 1] results in [1, 0, 0].
*/

namespace LeetCodeSolutions
{
    class Nr832FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            foreach (int[] row in A)
            {
                int i = 0, j = row.Length - 1;
                while (i < j)
                {
                    int placeHolder = row[i];
                    row[i] = row[j];
                    row[j] = placeHolder;
                    i++;
                    j--;
                }
            }
            foreach (int[] row in A)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    row[i] = row[i] == 1 ? 0 : 1;
                }
            }
            return A;
        }
    }
}
