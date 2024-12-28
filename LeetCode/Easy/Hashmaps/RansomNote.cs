namespace LeetCode.Hashmaps.Easy
{
	public static class RansomNote
	{
		/*
		 * Given two strings ransomNote and magazine,return true if ransomNote
		 * can be constructed by using the letters
		 * from magazine and false otherwise.
		 * Each letter in magazine can only be used once in ransomNote.
		 */
		public static bool CanConstruct(string ransomNote, string magazine)
		{
			var magazineLetters = new Dictionary<char, int>();
			var lowerMagazine = magazine.ToLower();
			var lowerRansom = ransomNote.ToLower();
			
			foreach (var current in lowerMagazine)
			{
				magazineLetters.TryAdd(current, 0);
				magazineLetters[current]++;
			}

			foreach (var letter in lowerRansom)
			{
				if (!magazineLetters.ContainsKey(letter) || magazineLetters[letter] == 0)
					return false;

				magazineLetters[letter]--;
			}

			return true;
		}
	}

	public class Dictinoary<T, T1>
	{
	}
}

