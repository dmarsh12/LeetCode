using System;
namespace LeetCode.Easy
{
	public static class RemoveElement
	{
		public static int Remove(int[] nums, int val)
        {
            var current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }

            return current;
        }
	}
}

