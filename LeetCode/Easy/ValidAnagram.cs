using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class ValidAnagram
    {
        public static void ExampleOne()
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }

        // First Try
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sChars = s.ToCharArray();
            var tChars = t.ToCharArray();
            Array.Sort(sChars);
            Array.Sort(tChars);

            for (int i = 0; i < sChars.Length; i++)
                if (sChars[i] != tChars[i]) return false;

            return true;
        }

        // With Dictionary
        public static bool IsAnagramWithDictionary(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var symbolFrequency = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                symbolFrequency.TryAdd(s[i], 0);
                symbolFrequency.TryAdd(t[i], 0);

                symbolFrequency[s[i]]++;
                symbolFrequency[t[i]]--;
            }

            return symbolFrequency.Values.All(frequence => frequence == 0);
        }
    }
}
