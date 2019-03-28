using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {

        public static int global_max;
        public int LongestUnivaluePath(TreeNode root)
        {
            global_max = 0;
            Recursive(root);
            return global_max;
        }

        public static int Recursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left_max = 0; int right_max = 0;
            int curr_left = Recursive(root.left);
            int curr_right = Recursive(root.right);

            if (root.left != null && root.val == root.left.val)
            {
                left_max = curr_left + 1;
            }

            if (root.right != null && root.val == root.right.val)
            {
                right_max = curr_right + 1;
            }

            global_max = Math.Max(global_max, left_max + right_max);

            return Math.Max(left_max, right_max);
        }
    }
}