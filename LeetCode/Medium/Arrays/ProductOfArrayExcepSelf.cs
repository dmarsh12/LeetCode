namespace LeetCode.Medium.Arrays;

public static class ProductOfArrayExcepSelf
{
    public static int[] Execute(int[] nums)
    {
        var result = new int[nums.Length];

        var prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        var suffix = 1;
        for (var j = nums.Length-1; j >= 0; j--)
        {
            result[j] *= suffix;
            suffix *= nums[j];
        }

        return result;
    }
}