using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class BalancedBinaryTree
    {

        public static void ExampleOne()
        {
            var root = new TreeNode(3, new(9), new(20, new(15), new(7)));
            Console.WriteLine(IsBalanced(root));
        }

        private bool res = true;
        public static bool IsBalanced(TreeNode root)
        {

            //if the root is null return true since it has a height of 0
            if (root == null)
            {
                return true;
            }

            //Depth first search starting from the root with a height of 0
            DFS(root, 0);

            return res;
        }

        private static int DFS(TreeNode node, int h)
        {

            // if the node is null return 0
            if (node == null)
                return 0;

            // declare left and right heights
            int lh = DFS(node.left, h + 1),
            rh = DFS(node.right, h + 1);

            // if the differences between the two is greater than one response = false.
            if (Math.Abs(lh - rh) > 1)
                res = false;

            //return max height + 1
            return Math.Max(lh, rh) + 1;
        }
    }
}
