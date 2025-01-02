namespace LeetCode.Easy.Strings;

public static class LengthOfLastWord
{
    public static int Execute(string sentence) => sentence.Split(" ").Where(w => !string.IsNullOrEmpty(w)).Last().Length;
}