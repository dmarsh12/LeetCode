using System.Runtime.InteropServices.ComTypes;

namespace LeetCode.Medium;

public static class CanJump2
{
    // new int[] {2, 1, 3, , 5}
    public static int Execute(int[] nums)
    {
        if (nums == null || nums.Length <= 1) 
            return 0;
        
        var jumps = 0;
        var currentJumpEnd = 0;
        var farthest = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            if (i == currentJumpEnd)
            {
                jumps++;
                currentJumpEnd = farthest;
                if (currentJumpEnd >= nums.Length - 1)
                    break;
            }
        }

        return jumps;
    }
}