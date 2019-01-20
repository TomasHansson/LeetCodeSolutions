/*
938. Range Sum of BST
Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
The binary search tree is guaranteed to have unique values.

Note:
The number of nodes in the tree is at most 10000.
The final answer is guaranteed to be less than 2^31.
*/

namespace LeetCodeSolutions
{
    class Nr938RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;

            if (root.val >= L && root.val <= R)
                return root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
            else
                return RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
