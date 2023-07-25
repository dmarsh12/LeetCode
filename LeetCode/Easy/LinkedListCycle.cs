using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class LinkedListCycle
    {
        private static HashSet<ListNode> hashCodes = new();

        public static bool HasCycleMyAtttempt(ListNode head)
        {
            if (head != null)
            {
                if (hashCodes.Contains(head))
                {
                    return true;
                }
                else
                {
                    hashCodes.Add(head);
                    return HasCycleMyAtttempt(head.next);
                }
            }

            return false;
        }

        public static bool HasCycle(ListNode head) 
        {
            var visited = new HashSet<ListNode>();
            while (head != null)
            {
                if (visited.Contains(head)) return true;
                
                visited.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
