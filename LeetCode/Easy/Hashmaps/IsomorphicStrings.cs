namespace LeetCode.Hashmaps.Easy;

public static class IsomorphicStrings
{
    // Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    // All occurrences of a character must be replaced with another character while 
    // the order of characters. No two characters may map to the same character,
    // but a character may map to itself.
    public static bool Execute(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        // Dictionaries to store mappings between characters
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            var charS = s[i];
            var charT = t[i];

            // Check if the mapping from s -> t is consistent
            if (!mapST.TryAdd(charS, charT))
            {
                if (mapST[charS] != charT)
                    return false;
            }

            // Check if the mapping from t -> s is consistent
            if (!mapTS.TryAdd(charT, charS))
            {
                if (mapTS[charT] != charS)
                    return false;
            }
        }

        return true;
    }
}