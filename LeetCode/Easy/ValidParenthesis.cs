using System;
namespace LeetCode.Easy
{

    /*Given a string s containing just the 
     * characters '(', ')', '{', '}', '[' and ']', 
     * determine if the input string is valid.

    An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.
 

    Example 1:

    Input: s = "()"
    Output: true
    Example 2:

    Input: s = "()[]{}"
    Output: true
    Example 3:

    Input: s = "(]"
    Output: false*/

	public static class ValidParenthesis
	{
        public static bool IsValid(string s)
        {
            var lookup = new Dictionary<char, char>()
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };

            if (s.Length % 2 != 0)
                return false;

            if (s.Length == 2)
                return lookup.TryGetValue(s[1], out var expected) && expected == s[0];

            Stack<char> stack = new Stack<char>();

            HashSet<char> invalidFirstCharacters = new() { '}', ')', ']' };

            foreach (var character in s)
            {
                if (stack.Count == 0 && invalidFirstCharacters.Contains(character))
                {
                    return false;
                }
                else if (lookup.TryGetValue(character, out var expected))
                {
                    if (stack.Peek() != expected)
                        return false;

                    stack.Pop();
                }
                else
                {
                    stack.Push(character);
                }
            }

            return stack.Count == 0;
        }

    }
}

