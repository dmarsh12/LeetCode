namespace LeetCode.Easy;

public static class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        if(s == "")
            return true;

        var currentIndex = 0;
        foreach (var t1 in t)
        {
            if (t1 == s[currentIndex])
                currentIndex++;

            if (currentIndex == s.Length)
                return true;
        }

        return false;
    }
}