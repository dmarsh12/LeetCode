using System;
namespace LeetCode.Easy
{
	public class MyQueueWithStack
	{

        private Stack<int> StackOne = new Stack<int>();
        private Stack<int> StackTwo = new Stack<int>();

        public void Push(int x)
        {
            StackOne.Push(x);
        }

        public int Pop()
        {
            while (StackOne.Count > 0)
                StackTwo.Push(StackOne.Pop());

            var result = StackTwo.Pop();

            while (StackTwo.Count > 0)
                StackOne.Push(StackTwo.Pop());

            return result;
        }

        public int Peek()
        {
            while (StackOne.Count > 0)
                StackTwo.Push(StackOne.Pop());

            var result = StackTwo.Peek();

            while (StackTwo.Count > 0)
                StackOne.Push(StackTwo.Pop());

            return result;
        }

        public bool Empty()
        {
            return StackOne.Count == 0;
        }
    }
}

