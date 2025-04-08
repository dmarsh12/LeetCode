namespace LeetCode.Medium.Arrays;

public static class IncreasingTriplet
{
    public static bool Execute(int[] nums)
    {
        if (nums == null || nums.Length < 3)
            return false;

        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= first)
            {
                first = num;
                continue;
            }

            if (num <= second)
            {
                second = num;
                continue;
            }

            return true;
        }

        return false;
    }
}