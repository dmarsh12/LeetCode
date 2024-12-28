using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Medium;

// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
// Find two lines that together with the x-axis form a container, such that the container contains the most water.
// Return the maximum amount of water a container can store.
// Notice that you may not slant the container.
// https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=top-interview-150
public static class ContainerMostWater
{
    private static int[] ExampleOne = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

    public static int MaxArea(int[] height = null)
    {
        height ??= ExampleOne;
        var result = -1;
        var fullArea = -1;
        for (int i = 0; i < height.Length; i++)
        {
            var current = height[i];
            for (int j = i+1; j < height.Length; j++)
            {
                var iter = height[j];
                var maxHeight = Math.Min(iter, current);
                var currentMaxArea = (maxHeight*maxHeight);
                var length = (j + 1) - (i + 1);
                if (currentMaxArea * length > fullArea)
                    result = fullArea;
            }
        }

        return result;
    }
}