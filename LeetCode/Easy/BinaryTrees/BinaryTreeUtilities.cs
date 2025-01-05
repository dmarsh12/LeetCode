using LeetCode.Models;

namespace LeetCode.Easy;

public static class BinaryTreeUtilities
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
    public static bool IsSymmetric(TreeNode root)
    {
        if (root != null)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }

            if (root.left == null || root.right == null)
            {
                return false;
            }

            if (root.left.val != root.right.val)
            {
                return false;
            }
        }

        return IsSymmetric(root.left) && IsSymmetric(root.right);
    }
}