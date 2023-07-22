using System;
using LeetCode.Models;

namespace LeetCode.Easy
{
    public class MergeSortedLists
	{
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            ListNode temp = new ListNode(0);
            ListNode current = temp;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    temp.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    temp.Next = l2;
                    l2 = l2.Next;
                }

                if (l1 != null && l2 != null)
                    temp = temp.Next; // any changes to next impact current next. 
            }

            if (l1 != null)
                temp.Next = l1;

            if (l2 != null)
                temp.Next = l2;

            return current.Next;
        }

        public void Example()
        {
            var l1 = new ListNode() { val = 1, Next = new ListNode() { val = 2, Next = new ListNode() { val = 4 } } };
            var l2 = new ListNode() { val = 1, Next = new ListNode() { val = 3, Next = new ListNode() { val = 4 } } };
            Console.WriteLine(MergeSortedLists.MergeTwoLists(l1, l2));
        }
    }
}

