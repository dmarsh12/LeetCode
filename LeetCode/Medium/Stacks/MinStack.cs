// namespace LeetCode.Stacks.Medium;
//
// public class MinStack
// {
//     private Stack<(int Value, int Min)> _stack;
//     private int min;
//     
//     public MinStack()
//     {
//         _stack = new Stack<(int Value, int Min)>();
//     }
//     
//     public void Push(int val)
//     {
//         if (_stack.Count == 0 || val < min)
//             min = val;
//         
//         _stack.Push((val, min));
//         
//         _stack.Push(val);
//     }
//     
//     public void Pop()
//     {
//         var popped = _stack.Pop();
//         _values.Remove(popped);
//     }
//     
//     public int Top()
//     {
//         if (_stack.TryPeek(out var top))
//             return top;
//         return 0;
//     }
//     
//     public int GetMin()
//     {
//         _values.Sort();
//         return _values[0];
//     }
// }
//
// /**
// }