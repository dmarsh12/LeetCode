namespace LeetCode.Intervals.Medium;

public static class MergeIntervals
{
    public static int[][] Execute(int[][] intervals)
    {
        var result = new List<int []>();

        var sortedIntervals = intervals.OrderBy(x => x[0]).ToArray();

        var first = sortedIntervals[0];
        var firstStart = first[0];
        var firstEnd = first[^1];
        
        result.Add(new []{ firstStart, firstEnd});
        for (var i = 1; i < sortedIntervals.Length; i++)
        {
            var interval = sortedIntervals[i];

            var start = interval[0];
            var last = interval[^1];
            
            // not new range
            if (start < result[^1][1] && last <= result[^1][1])
                continue;

            // start bigger than prior 
            if (start <= result[^1][1])
            {
                result[^1][1] = Math.Max(result[^1][1], last);
                continue;
            }

            result.Add(new[] { start, last});
        }

        return result.ToArray();
    }
}