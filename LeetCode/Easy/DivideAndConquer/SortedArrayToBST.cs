using LeetCode.Models;

namespace LeetCode.Easy.DivideAndConquer;

public static class SortedArrayToBST
{
    // public static TreeNode Execute(int[] nums)
    // {
    //     var halfway = nums.Length / 2;
    //     TreeNode left = null;
    //     TreeNode right = null;
    //     TreeNode result = new TreeNode(nums[0]);
    //
    //     var isLeft = false;
    //     var isRight = false;
    //     TreeNode current = new TreeNode(nums[0]);
    //     for (int i = 0; i < halfway; i++)
    //     {
    //         if (isLeft && !isRight)
    //         {
    //             current.left = new TreeNode(nums[i]);
    //             isLeft = false;
    //         }
    //         else if (isRight && !isLeft)
    //         {
    //             current.right = new TreeNode(nums[i]);
    //             isRight = false;
    //         }
    //         else
    //         {
    //             result.left.left = n
    //         }
    //     }
    //
    //     for (int i = 0; i > halfway; i++)
    //     {
    //         
    //     }
    //
    //     return new TreeNode(nums[0], left, right);
    //}
}