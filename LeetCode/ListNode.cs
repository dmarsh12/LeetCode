using System;
namespace LeetCode
{
	public class ListNode
	{
		public int val;
        private ListNode next;
        public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.Next = next;
		}

        public ListNode Next
		{
			get => next;
			set => next = value;
		}
    }
}

