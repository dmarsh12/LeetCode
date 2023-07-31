using System;
using System.Reflection;
using LeetCode.Models;

namespace LeetCode.Easy
{
	public class FirstBadVersion : VersionControl
	{
		public int FindFirstBadVersion(int n)
		{
			if (IsBadVersion(1))
				return 1;

			var start = 1;
			var end = n;

			while (start <= end)
			{
                var mid = (start + end) / 2;
                if (!IsBadVersion(mid))
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

			return start;
		}

		public void ExampleOne()
		{
			BadVersion = 1702766719;
			FindFirstBadVersion(2126753390);
        }
	}
}

