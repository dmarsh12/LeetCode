using LeetCode.Models;

namespace LeetCode.Easy.LinkedList;

public class LinkedListHasCycle
{
    // https://leetcode.com/problems/linked-list-cycle/description/?envType=study-plan-v2&envId=top-interview-150
    public static bool Execute(ListNode head)
    {
        var values = new HashSet<ListNode>();
        if (head == null)
            return false;
        
        while (head.next != null)
        {
            if (!values.Add(head))
                return true;
            head = head.next;
        }

        return false;
    }

    public static bool ExecuteAlternative(ListNode head)
    {
        ListNode slow, fast;
        if (head == null)
            return false;

        slow = head;
        fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
                return true;
        }

        return false;
    }
}