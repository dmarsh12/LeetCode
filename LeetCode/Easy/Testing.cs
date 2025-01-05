namespace LeetCode.Easy;

public static class Testing
{
    public static int Test(int[] nums)
    {
        var lookup = new Dictionary<int, int>();        
        var current = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var currentValue = nums[i];
            if (lookup.TryGetValue(currentValue, out var foundValue))
            {
                if (foundValue >= 2) 
                    continue;
                
                lookup[currentValue]++;
                nums[current] = currentValue;
                current++;
            }
            else
            {
                lookup[currentValue] = 1;
                nums[current] = currentValue;
                current++;
            }
        }

        return current;
    }
}