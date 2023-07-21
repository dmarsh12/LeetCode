// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LeetCode;
using LeetCode.Easy;
using LeetCode.Medium;

var l1 = new ListNode() { val = 1, Next = new ListNode() { val = 2, Next = new ListNode() { val = 4 } } };
var l2 = new ListNode() { val = 1, Next = new ListNode() { val = 3, Next = new ListNode() { val = 4 } } };

var result = MergeSortedLists.MergeTwoLists(l1, l2);


//var twoSum = new TwoSum();
//twoSum.NumberArray = new int[] { 0, 4, 3, 0 };
//Console.WriteLine($"[{string.Join(", ", twoSum.GetIndicesThatAddToTarget(0))}]");

//var test = new TopLeftQuadrant();
//var sample = new List<List<int>>();
//sample.Add(new List<int> { 1, 2 });
//sample.Add(new List<int> { 3, 5 });

//Console.WriteLine(test.MaximumSum(sample));

//var addTwoNumbers = new AddTwoNumbers();
//var listNodeOne = new ListNode
//{
//	val = 2,
//	next = new ListNode
//	{
//		val = 4,
//		next = new ListNode { val = 3 }
//	}
//};

//var listNodeTwo = new ListNode
//{
//	val = 5,	
//	next = new ListNode
//	{
//		val = 6,
//		next = new ListNode { val = 4 }
//	}
//};

//addTwoNumbers.Execute(listNodeOne, listNodeTwo);        