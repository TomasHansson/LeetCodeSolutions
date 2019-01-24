/*
657. Robot Return to Origin
There is a robot starting at position (0, 0), the origin, on a 2D plane. 
Given a sequence of its moves, judge if this robot ends up at (0, 0) after it completes its moves.

The move sequence is represented by a string, and the character moves[i] represents its ith move. 
Valid moves are R (right), L (left), U (up), and D (down). If the robot returns to the origin after 
it finishes all of its moves, return true. Otherwise, return false.

Note: The way that the robot is "facing" is irrelevant. "R" will always make the robot move to the right once, 
"L" will always make it move left, etc. Also, assume that the magnitude of the robot's movement is the same for each move.
*/

namespace LeetCodeSolutions
{
    class Nr657RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            if (moves.Length % 2 != 0)
                return false;
            int horizontal = 0, vertical = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                    vertical++;
                else if (moves[i] == 'D')
                    vertical--;
                else if (moves[i] == 'R')
                    horizontal++;
                else if (moves[i] == 'L')
                    horizontal--;
            }
            return horizontal == 0 && vertical == 0;
        }
    }
}
