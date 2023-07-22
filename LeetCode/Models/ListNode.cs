using System;

namespace LeetCode.Models
{
    public class ListNode
    {
        public int val;
        private ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            Next = next;
        }

        public ListNode Next
        {
            get => next;
            set => next = value;
        }
    }
}

