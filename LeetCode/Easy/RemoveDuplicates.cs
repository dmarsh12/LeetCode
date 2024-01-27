using System;
namespace LeetCode.Easy
{
	public static class RemoveDuplicates
	{
		public static int Remove(int[] nums)
		{
			var results = new HashSet<int>();
			var current = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (!results.Contains(nums[i]))
				{
					results.Add(nums[i]);
					nums[current] = nums[i];
					current++;
				}
			}

			return results.Count;
		}
	}
}

