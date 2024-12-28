namespace LeetCode.Medium;

public static class CanJump2
{
    public static int ExampleOne()
    {
        var nums = new int[] { 2, 3, 1, 1, 4 };

        if (nums.Length == 1)
            return 0;
        
        var max = 0;
        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > max)
                continue;

            max = Math.Max(max, i + nums[i]);

            if (max >= nums.Length - 1)
                return count+1;
            else
                count++;
        }   
        
        return count;
    }
}