namespace LeetCode.Easy
{
	public static class LongestPalimdrone
	{
		public static int Find(string s)
		{
			if (s.Length == 1)
				return 1;

            var set = new HashSet<char>();
            var maxLength = 0;

            foreach (var c in s)
            {
                if (set.Contains(c))
                {
                    set.Remove(c);
                    maxLength += 2;
                }
                else
                {
                    set.Add(c);
                }
            }

            return set.Count > 0 ? maxLength + 1 : maxLength;
        }
	}
}

