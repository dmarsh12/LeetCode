namespace LeetCode.Stacks.Medium;

public class SimplifyPath
{
    public static string Execute(string s)
    {
        Stack<string> stack = new Stack<string>();
        string[] components = s.Split('/', StringSplitOptions.RemoveEmptyEntries);

        foreach (string component in components)
        {
            switch (component)
            {
                case ".":
                    continue;
                case "..":
                {
                    // Move up one directory if possible
                    if (stack.Count > 0)
                        stack.Pop();
                    continue;
                }
                default:
                    // Add directory or file to the stack
                    stack.Push(component);
                    break;
            }
        }

        // Build the simplified path
        var result = new List<string>(stack);
        result.Reverse(); // The stack needs to be reversed for correct path order

        return "/" + string.Join("/", result);
    }
}