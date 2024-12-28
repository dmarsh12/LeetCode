using System.Globalization;
using System.Numerics;
using System.Text;
using LeetCode.Models;

namespace LeetCode.Medium.LinkedLists;

public class AddTwoNodes
{
    /*
     * So the foreach is building on the result node while still keeping a reference to it? Thus when you do temp = temp.next it doesn't impact the actual result value even though they share the same reference?
       Answer
       Exactly:
       
       Building on Result: The foreach loop builds the list by adding nodes after the initial result node, but result itself remains unchanged in terms of its reference. It's like result is anchoring the start of the list.
       Shared Reference: Initially, result and temp share the same reference (point to the same node). However, when you do temp = temp.next, you're updating what temp points to, not what result points to.
       
       Here's the key:
       
       Reference vs. Value: When you say temp = temp.next, you're not changing the result variable itself; you're changing where temp points. result still points to the original head node, which now has its next pointing to the new nodes you've created.
       Immutability of References: The reference stored in result (the memory address it points to) remains the same unless you explicitly change result itself. Thus, temp = temp.next only affects temp, moving it to the next node without altering result's reference.
       
       So, even though temp and result started with the same reference:
       
       result continues to point to the head of the list throughout the operation.
       temp moves through the list, but its movement does not impact the reference held by result.
       
       This approach allows you to extend the list while still being able to return the head, effectively using result as an anchor to the start of your linked list.
     */
    public static ListNode Execute(ListNode a, ListNode b)
    {
        // Convert list `a` to a reversed number string
        var aNumber = new StringBuilder();
        while (a != null)
        {
            aNumber.Insert(0, a.val); // Insert at the start to reverse
            a = a.next;
        }

        // Convert list `b` to a reversed number string
        var bNumber = new StringBuilder();
        while (b != null)
        {
            bNumber.Insert(0, b.val); // Insert at the start to reverse
            b = b.next;
        }

        // Calculate the sum of the numbers
        var sum = BigInteger.Parse(aNumber.ToString()) + BigInteger.Parse(bNumber.ToString());
        var sumString = sum.ToString();

        // Convert the result string back to a linked list
        var dummy = new ListNode(0);
        var temp = dummy;
        foreach (var c in sumString.Reverse()) // Reverse again for proper order
        {
            temp.next = new ListNode((int)Char.GetNumericValue(c));
            temp = temp.next;
        }

        return dummy.next;
    }
}