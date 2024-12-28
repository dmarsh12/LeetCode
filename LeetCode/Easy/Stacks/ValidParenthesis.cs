namespace LeetCode.Stacks.Easy;

public static class ValidParenthesis
{
    private static readonly Dictionary<char, char> lookup = new()
    {
        ['}'] = '{',
        [']'] = '[',
        [')'] = '('
    };

    private static readonly HashSet<char> InvalidFirstCharacters = new() { '}', ']', ')' };
    
    public static bool Execute(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            // If character is a closing bracket
            if (lookup.TryGetValue(c, out var expected))
            {
                // Check if stack is empty or the top of the stack does not match
                if (stack.Count == 0 || stack.Pop() != expected)
                    return false;
                continue;
            }

            // Push opening brackets onto the stack
            stack.Push(c);
        }

        // Valid if the stack is empty
        return stack.Count == 0;
    }
}