namespace LeetCode.Medium.SlidingWindow;

public static class MinSizeSubArraySum
{
    public static int Execute(int target, int[] nums)
    {
        int result = int.MaxValue, left = 0, current = 0;
        for (var right = 0; right < nums.Length; right++)
        {
            current += nums[right];
            while (current >= target)
            {
                current -= nums[left];
                result = Math.Min(result, right - left + 1);
                left++;
            }
        }
        
        return result == int.MaxValue ? 0 : result;
    }
}