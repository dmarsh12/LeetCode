namespace LeetCode.Hashmaps.Easy;

public static class Anagram
{
    // https://leetcode.com/problems/valid-anagram/description/?envType=study-plan-v2&envId=top-interview-150
    public static bool Execute(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var tLookup = new Dictionary<char, int>();
        
        foreach (var c in t)
        {
            if (!tLookup.TryAdd(c, 1))
                tLookup[c]++;
        }

        foreach (var c in s)
        {
            if (tLookup.TryAdd(c, 0))
                return false;

            tLookup[c]--;
        }

        foreach (var kvp in tLookup.Values)
        {
            if (kvp != 0)
                return false;
        }

        return true;
    }

    public static bool ExecuteWithSort(string s, string t)
    {
        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();
        Array.Sort(sCharArray);
        Array.Sort(tCharArray);
        return sCharArray == tCharArray;
    }
}