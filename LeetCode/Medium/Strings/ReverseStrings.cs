using System.Text;

namespace LeetCode.Medium.Strings;

public static class ReverseStrings
{
    public static string Execute(string s)
    {
        var words = s.Split(' ');
        var stack = new Stack<string>();
        var result = new StringBuilder();

        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word))
                stack.Push(word);
        }

        while (stack.TryPop(out var word))
            result.Append(word).Append(' ');

        result.Length--;
        
        return result.ToString();
    }
}