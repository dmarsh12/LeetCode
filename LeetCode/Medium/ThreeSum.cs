using System.Collections.Generic;

namespace LeetCode.Medium;

public static class ThreeSum
{
    public static int[] ExampleOne = new[] { 1, -2, 1, 0};

    public static IList<IList<int>> Execute(int[] nums = null)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length <= 2)
            return new List<IList<int>>();

        Array.Sort(nums); // sort 
        int start = 0;
        
        while (start < nums.Length - 2)
        {
            var target = nums[start] * -1;
            var left = start + 1;
            var right = nums.Length - 1;

            var current = nums[start];
            
            while (left < right)
            {
                
                if (nums[left] + nums[right] > target)
                {
                    --right; // Greater than target gotta be less since sorted
                }
                else if (nums[left] + nums[right] < target)
                {
                    ++left; // Less than target gotta be greater since sorted
                }
                else
                {
                    var solution = new List<int>() { current, nums[left], nums[right] }; // found a mmatch
                    result.Add(solution);
                    while (left < right && nums[left] == solution[1]) // move right until we are passed the second value to avoid duplicates
                        ++left;
                    while (left < right && nums[right] == solution[2]) // move left until we are away from third value to avoid duplicate answers
                        --right;
                }
            }

            // Skip starting duplicates
            while (start < nums.Length - 2 && nums[start] == current)
                ++start;
        }

        return result;
    }
}