using System.Text;

namespace LeetCode.Medium.Strings;

public static class StringCompression
{
    public static int Execute(char[] c)
    {
        if (c == null || c.Length == 0)
            return 0;

        var result = new StringBuilder();
        int count = 1;

        for (int i = 1; i <= c.Length; i++)
        {
            if (i < c.Length && c[i] == c[i - 1])
            {
                count++;
            }
            else
            {
                result.Append(c[i - 1]);
                if (count > 1)
                    result.Append(count);
                count = 1;
            }
        }

        // Update the original array `c` with the new characters
        for (int i = 0; i < result.Length; i++)
            c[i] = result[i];

        return result.Length;
    }
}