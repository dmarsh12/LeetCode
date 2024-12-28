namespace LeetCode.Hashmaps.Easy;

public static class WordPattern
{
    public static bool Execute(string pattern, string s)
    {
        if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(s))
            return false;
        
        var chars = s.Split(' ');

        if (chars.Length != pattern.Length)
            return false;

        var patternLookup = new Dictionary<char, string>();
        var stringLookup = new Dictionary<string, char>();
        
        for (var i = 0; i < pattern.Length; i++)
        {
            var patternChar = pattern[i];
            var word = chars.ElementAt(i);
            
            if (!patternLookup.TryAdd(patternChar, word))
            {
                if (word != patternLookup[patternChar])
                    return false;
            }

            if (!stringLookup.TryAdd(word, patternChar))
            {
                if (patternChar != stringLookup[word])
                    return false;
            }
        }
        

        return true;
    }
}