// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LeetCode.Easy;

var twoSum = new TwoSum();
twoSum.NumberArray = new int[] { 0, 4, 3, 0 };
Console.WriteLine($"[{string.Join(", ", twoSum.GetIndicesThatAddToTarget(0))}]");