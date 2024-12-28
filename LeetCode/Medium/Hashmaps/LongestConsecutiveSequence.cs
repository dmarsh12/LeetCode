namespace LeetCode.Hashmaps.Medium;

public class LongestConsecutiveSequence
{
    public static int Execute(int[] nums)
    {
        if (nums.Length == 1)
            return 1;

        if (nums.Length == 0)
            return 0;
        
        var currentMax = 1;
        var result = 1;
        Array.Sort(nums);
        var sortedHashSet = nums.ToHashSet().ToList();
        for (var i = 1; i < sortedHashSet.Count; i++)
        {
            if (sortedHashSet[i] - sortedHashSet[i-1] == 1)
            {
                currentMax++;
                if (currentMax > result)
                    result = currentMax;
                continue;
            }

            currentMax = 1;
        }

        return result;
    }
}