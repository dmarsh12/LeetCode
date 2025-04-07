using System.Text;

namespace LeetCode.Easy.Strings;

public static class ReverseVowels
{
    public static string Execute(string word)
    {
        var stack = new Stack<char>();
        var lookup = new HashSet<char>()
        {
            'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
        };
        
        var result = new StringBuilder();
        foreach (var letter in word.Where(letter => lookup.Contains(letter)))
            stack.Push(letter);

        foreach (var letter in word)
        {
            if (lookup.Contains(letter))
            {
                result.Append(stack.Pop());
                continue;
            }

            result.Append(letter);
        }

        return result.ToString();
    }
}