namespace LeetCode.Hashmaps.Easy;

public static class TwoSum
{
    public static int[] Execute(int[] nums, int target)
    {
        var lookup = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            lookup.TryAdd(nums[i], i);

            var desired = target - nums[i];
            if (lookup.TryGetValue(desired, out var result) && result != i)
                return new[] { i, result };
        }
        
        return new int[] { };
    }
}