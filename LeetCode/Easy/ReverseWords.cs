namespace LeetCode.Easy;

public static class ReverseWords
{
    public static string Execute(string s)
    {
        var wordsInString = s.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var newWord = "";
        for (int i = wordsInString.Length - 1; i >= 0; i--)
            newWord += wordsInString[i] + " ";

        return newWord.Trim();
    }
}