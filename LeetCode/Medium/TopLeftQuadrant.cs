using System;
namespace LeetCode.Medium
{
	public class TopLeftQuadrant
	{
		public int MaximumSum(List<List<int>> a)
        {
			int n = a.Count;
			int sum = 0;

			for (int i = 0; i < n / 2; i++)
				for (int j = 0; j < n / 2; j++)
					sum += new[] { a[i][j], a[i][n - j - 1], a[n - i - 1][j], a[n - i - 1][n - j - 1] }.Max();
			return sum;

		}
	}
}

