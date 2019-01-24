﻿/*
617. Merge Two Binary Trees
Given two binary trees and imagine that when you put one of them to cover the other, 
some nodes of the two trees are overlapped while the others are not.

You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, then sum node values
up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.
*/

namespace LeetCodeSolutions
{
    class Nr617MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return null;
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;

            TreeNode newRoot = new TreeNode(t1.val + t2.val);
            newRoot.left = MergeTrees(t1.left, t2.left);
            newRoot.right = MergeTrees(t1.right, t2.right);
            return newRoot;
        }
    }
}
