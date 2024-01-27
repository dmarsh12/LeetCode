using System;
namespace LeetCode.Easy
{
	public static class RomanToInt
	{
		public static int Execute(string s)
		{
            var lookup = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var result = 0;
            var arr = s.ToCharArray();

            if (s.Length == 1)
                return lookup[s[0]];

            var previous = lookup[arr[0]];
            for (int i = 0; i < arr.Length; i++)
            {
                var current = lookup[arr[i]];

                if (previous < current)
                    current -= previous * 2;

                previous = current;

                result += current;
            }

            return result;
        }
	}
}

