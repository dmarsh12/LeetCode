using System;
using LeetCode.Models;

namespace LeetCode.Easy
{
	public static class ReverseLinkedList
	{

		public static ListNode ExampleOne()
		{
			var head = new ListNode()
			{
				val = 5,
				next = new ListNode()
				{
					val = 4,
					next = new ListNode()
					{
						val = 3
					}
				}
			};

			return Reverse(head);
		}

		public static ListNode Reverse(ListNode head)
		{
			ListNode result = null;
			while (head != null)
			{
				result = new ListNode(head.val, result);
				head = head.next;
			}

			return result;
		}
	}
}

