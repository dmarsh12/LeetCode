using System.Collections.Immutable;

namespace LeetCode.Medium;

public static class hIndex
{
    public static int Execute()
    {
        var exampleOne = new int[] { 3, 0, 6, 1, 5 };

        Array.Sort(exampleOne);
        Array.Reverse(exampleOne);

        var result = 0;
        for (int i = 0; i < exampleOne.Length; i++)
        {
            if (exampleOne[i] >= i + 1)
                result = i + 1;
            else
                return result;
        }

        return 1;
    }
}