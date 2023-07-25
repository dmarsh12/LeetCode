using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class MyQueue
    {
        private List<int> queue = new List<int>();

        public void Push(int x)
        {
            queue.Add(x);
        }

        public int Pop()
        {
            var result = queue[0];
            queue.Remove(result);
            return result;
        }

        public int Peek()
        {
            return queue[0];
        }

        public bool Empty()
        {
            return queue.Any();
        }
    }
}
