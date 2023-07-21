using System;
namespace LeetCode.Medium
{
	public class AddTwoNumbers
	{
        public AddTwoNumbers()
        {

        }

		public ListNode Execute(ListNode l1, ListNode l2)
		{
			string numberOne = "";
			string numberTwo = "";

			bool numberOneFound = false;
			bool numberTwoFound = false;

			var currentListNodeOne = l1;
			var currentListNodeTwo = l2;

			while (!numberOneFound && !numberTwoFound)
            {

				numberOne += currentListNodeOne.val.ToString();
				if (!numberOneFound && currentListNodeOne.Next != null)
                {
					currentListNodeOne = currentListNodeOne.Next;
                }
				else
                {
					numberOneFound = true;
                }

				numberTwo += currentListNodeTwo.val.ToString();
				if (!numberTwoFound && currentListNodeTwo.Next != null)
				{
					currentListNodeTwo = currentListNodeTwo.Next;
				}
				else
				{
					numberTwoFound = true;
				}
			}

			var reverseOneArray = numberOne.ToCharArray().Reverse();
			var reverseTwoArray = numberTwo.ToCharArray().Reverse();

			string reverseOne = "";
			string reverseTwo = "";

			foreach (var character in reverseOneArray)
				reverseOne += character;

			foreach (var character in reverseTwoArray)
				reverseTwo += character;

			var reverseOneInteger = Convert.ToInt16(reverseOne);
			var reverseTwoInteger = Convert.ToInt16(reverseTwo);

			var resultString = (reverseOneInteger + reverseTwoInteger).ToString().ToCharArray().Reverse().ToArray();

			var head = new ListNode();
			int i = resultString.Length;

			head.val = Convert.ToInt16(resultString[i - 1] - '0');

			while (true)
            {
				i--;

				if (i == 0)
				{
					break;
				}

				var nextNode = new ListNode();
				nextNode.val = Convert.ToInt16(resultString[i-1] - '0');

				var current = head;

				while (current.Next != null)
                {
					current = current.Next;
                }

				current.Next = nextNode;

            }

            return head;
		}
	}
}

