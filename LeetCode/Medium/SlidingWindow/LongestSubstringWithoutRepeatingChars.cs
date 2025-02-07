using System.Text;

namespace LeetCode.Medium.SlidingWindow;

public static class LongestSubstringWithoutRepeatingChars
{
    public static int ExecuteWithSlidingWindow(string str)
    {
        if (string.IsNullOrEmpty(str)) 
            return 0;

        var lookup = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;

        while (right < str.Length)
        {
            if (!lookup.Add(str[right]))
            {
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                lookup.Remove(str[left]);
                left++;
            }
        }

        return maxLength;
    }

    public static int Execute(string str)
    {
        if (str.Length == 1)
            return 1;
        
        var result = 0;
        var lookup = new HashSet<char>();
        for (var i = 0; i < str.Length-1; i++)
        {
            lookup.Add(str[i]);
            var current = 1;
            for (var j = i + 1; j < str.Length; j++)
            {
                if (!lookup.Add(str[j]))
                {
                    if (current > result)
                        result = current;
                    lookup.Clear();
                    break;
                }
                current++;
                if (current > result)
                    result = current;
            }
        }

        return result;
    }
}