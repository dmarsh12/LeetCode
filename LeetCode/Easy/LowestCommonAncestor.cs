using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class LowestCommonAncestor
    {
        public static void ExampleOne()
        {
            var root = new TreeNode(6, new(2, new(0, new(4, new(3, new(5))))), new(8, new(7), new(9)));
            var result = FindLowest(root, new(2), new(5));
            Console.WriteLine(result);
        }

        public static TreeNode FindLowest(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root is not null)
            {
                // Since both are less than the root, we know that it must be on the left side from here
                // As the lower number in a BST is on the left...
                if (p.val < root.val && q.val < root.val)
                    return FindLowest(root.left, p, q);

                // Since both are greater than the root, we know that we should search the ride side
                // as the larger number in a BST is on the right...
                if (p.val > root.val && q.val > root.val)
                    return FindLowest(root.right, p, q);
            }

            return root;
        }
    }
}
