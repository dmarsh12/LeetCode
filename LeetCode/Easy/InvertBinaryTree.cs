using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class InvertBinaryTree
    {
        public static void ExampleOne()
        {

            var root = new TreeNode(4, new(2, new(1, null, null), new(3, null, null)), new(7, new(6, null, null), new(9, null, null)));
            Console.WriteLine(InvertTree(root));
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {
                var temp = root.left;
                root.left = InvertTree(root.right);
                root.right = InvertTree(temp);
            }

            return root;
        }
    }
}
