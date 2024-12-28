// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LeetCode;
using LeetCode.Easy;
using LeetCode.Intervals.Easy;
using LeetCode.Intervals.Medium;
using LeetCode.Medium;
using LeetCode.Medium.LinkedLists;
using LeetCode.Models;
using TwoSum = LeetCode.Hashmaps.Easy.TwoSum;
using ValidParenthesis = LeetCode.Stacks.Easy.ValidParenthesis;

AddTwoNodes.Execute(new ListNode() { val = 2, next = new ListNode() { val = 4, next = new ListNode() { val = 3 } } },
    new ListNode() { val = 5, next = new ListNode() { val = 6, next = new ListNode() { val = 4 } } });
//Console.WriteLine(ReversePolishNotation.Execute(new[] { "4","13","5","/","+"}));