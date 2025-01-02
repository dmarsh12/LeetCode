using System.Text;

namespace LeetCode.Medium;

public static class CanJump
{
    public static bool ExampleOne()
    {
        var nums = new int[] { 2, 3, 1, 1, 4 };

        var max = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > max)
                return false;

            max = Math.Max(max, i + nums[i]);

            if (max > nums.Length - 1)
                return true;
        }   
        
        return false;
    }
}