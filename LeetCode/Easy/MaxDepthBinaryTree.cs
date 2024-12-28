using LeetCode.Models;

namespace LeetCode.Easy;

public static class MaxDepthBinaryTree
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftDepth = MaxDepth(root.left);
        var rightDepth = MaxDepth(root.right);
        
        Console.WriteLine($"Left depth is {leftDepth}");
        Console.WriteLine($"Right depth is {rightDepth}");

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}