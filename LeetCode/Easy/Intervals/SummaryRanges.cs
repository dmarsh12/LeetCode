namespace LeetCode.Intervals.Easy;

// https://leetcode.com/problems/summary-ranges/?envType=study-plan-v2&envId=top-interview-150
public static class SummaryRanges
{
    public static IList<string> Execute(int[] nums)
    {
        var result = new List<string>();
        switch (nums.Length)
        {
            case 0:
                return new List<string>();
            case 1:
                return new List<string>() { nums[0].ToString() };
        }

        var start = $"{nums[0]}";
        var end = "";
        for (int i = 1; i < nums.Length; i++)
        {
            var current = nums[i];
            var previous = nums[i - 1];
            if (current - previous == 1)
            {
                end = $"->{current}";
                continue;
            }
            
            result.Add($"{start}{end}");

            if (i == nums.Length)
            {
                result.Add($"{current}");
                break;
            }
            
            start = $"{nums[i]}";
            end = string.Empty;
        }
        
        result.Add($"{start}{end}");

        return result;
    }
}