using System;
using System.Linq;

namespace LeetCode.Easy
{
	public static class RansomNote
	{
		public static bool CanConstruct(string ransomNote, string magazine)
		{
            var ransomNoteLookup = ransomNote.Where(char.IsLetter).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var magazineLookup = magazine.Where(char.IsLetter).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var key in ransomNoteLookup.Keys)
            {
                if (!magazineLookup.TryGetValue(key, out var letter) || ransomNoteLookup[key] > magazineLookup[key])
                    return false;
            }

            return true;
        }
	}
}

