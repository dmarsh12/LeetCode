namespace LeetCode.Hashmaps.Easy;

public static class ContainsNearbyDuplicates
{
    // Example
    // 1, 2, 3, 1
    // k = 3
    // abs(0 - 3) >= 3
    public static bool Execute(int[] nums, int k)
    {
        var lookup = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var currentNumber = nums[i];
            if (lookup.TryAdd(currentNumber, i))
                continue;

            var lookupValue = lookup[currentNumber];
            var result = Math.Abs(lookupValue - i);
            if (result <= k)
                return true;
            lookup[currentNumber] = i;
        }

        return false;
    }
}