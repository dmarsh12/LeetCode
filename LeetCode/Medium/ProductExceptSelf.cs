namespace LeetCode.Medium;

public static class ProductExceptSelf
{
    public static int[] Execute(int[] nums)
    {
        var result = new int[nums.Length - 1];
        
        for (int i = 0; i < result.Length; i++)
            result[i] = 1;
        
        var prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }
        
        var suffix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        
        return result;
    }
}