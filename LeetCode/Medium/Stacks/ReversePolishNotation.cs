using System.Collections;

namespace LeetCode.Medium;

public static class ReversePolishNotation
{
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/description/?envType=study-plan-v2&envId=top-interview-150
    public static int Execute(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            if (Int32.TryParse(token, out var number))
            {
                stack.Push(number);
                continue;
            }
            
            var a = stack.Pop();
            var b = stack.Pop();
                
            switch (token)
            {
                case "+":
                    stack.Push(a + b);
                    break;
                case "-":
                    stack.Push(b - a);
                    break;
                case "/":
                    stack.Push(b / a);
                    break;
                case "*":
                    stack.Push(a * b);
                    break;
            }
        }

        return stack.Pop();
    }
}