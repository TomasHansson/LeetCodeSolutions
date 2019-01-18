/*
335. Self Crossing
You are given an array x of n positive numbers. You start at point (0,0) and moves x[0] metres to the north, then x[1] metres to the west, 
x[2] metres to the south, x[3] metres to the east and so on. In other words, after each move your direction changes counter-clockwise.

Write a one-pass algorithm with O(1) extra space to determine, if your path crosses itself, or not.
*/

namespace LeetCodeSolutions
{
    class Nr335SelfCrossing
    {
        public bool IsSelfCrossing(int[] x)
        {
            int[,] table = new int[10000, 10000];
            int currentX = 5000;
            int currentY = 5000;
            table[currentX, currentY]++;
            int direction = (int)Direction.North;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = x[i]; j > 0; j--)
                {
                    if (direction == (int)Direction.North)
                        currentY++;
                    else if (direction == (int)Direction.West)
                        currentX--;
                    else if (direction == (int)Direction.South)
                        currentY--;
                    else if (direction == (int)Direction.East)
                        currentX++;

                    if (++table[currentX, currentY] > 1)
                        return true;
                }

                if (direction == (int)Direction.North)
                    direction = (int)Direction.West;
                else if (direction == (int)Direction.West)
                    direction = (int)Direction.South;
                else if (direction == (int)Direction.South)
                    direction = (int)Direction.East;
                else if (direction == (int)Direction.East)
                    direction = (int)Direction.North;
            }
            return false;
        }

        public enum Direction
        {
            North = 1,
            West = 2,
            South = 3,
            East = 4
        }
    }
}
