using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class ReverseLinkedList
    {

        static Stack<ListNode> ListNodes = new Stack<ListNode>();

        public static void ExampleOne()
        {
            ListNode head = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 3
                    }
                }
            };

            Console.WriteLine(ReverseList(head));
        }

        public static ListNode ReverseList(ListNode head)
        {

            ListNode previous = null;
            ListNode next = null;
            var current = head;

            while (current != null)
            {
                next = current.next; // the next node in the list
                current.next = previous; // the next value is the previous one, starts at null. since we always set next to previous, we only really need to make sure we get the head right which is setting the previous = current...
                previous = current; // the previously visited node is the current one which starts at the head
                current = next;
            }

            return previous;
        }
    }
}
