using System;
namespace LeetCode.Easy
{
	public static class ClimbingStairs
	{
		public static int Climb(int n)
		{
            if (n <= 2)
                return n;

            var climbing = new int[n];
            climbing[0] = 1;
            climbing[1] = 2;
            for (int i = 2; i < n; i++)
            {
                climbing[i] = climbing[i - 1] + climbing[i - 2];
            }

            return climbing[n - 1];
        }
	}
}

