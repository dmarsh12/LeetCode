namespace LeetCode.Easy;

public static class FirstOccurrence
{
    public static int StrStr(string haystack, string needle) => haystack.IndexOf(needle, StringComparison.Ordinal);
}