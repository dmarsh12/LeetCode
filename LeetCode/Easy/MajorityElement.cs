using System;
namespace LeetCode.Easy
{
	public static class MajorityElement
	{
		public static int Execute(int[] nums)
		{
			Array.Sort(nums);
			return nums.ElementAt(nums.Length / 2);
		}
	}
}

