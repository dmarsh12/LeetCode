﻿using System;
namespace LeetCode.Easy
{
	public static class RotateArray
	{
		public static void Execute(int[] nums, int k)
		{
			if (k == 0)
				return;

			if (k > nums.Length)
				return;

			var temp = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
				temp[i] = nums[i];

			for (int i = 0; i < nums.Length; i++)
			{
				var newIndex = k + i;
				if (newIndex >= nums.Length)
					newIndex -= nums.Length;

				nums[newIndex] = temp[i];
			}
		}
	}
}

