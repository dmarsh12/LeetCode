namespace LeetCode.Easy;

public static class LongestCommonPrefix
{
    public static string Execute(string[] words)
    {
        Array.Sort(words); // sort
        var firstWord = words[0]; // we only need to compare to the first when sorted
        for (int i = 0; i < firstWord.Length; i++) // Go through each char in first word
        {
            for (int j = 1; j < words.Length; j++)
            {
                if (i >= words[j].Length || firstWord[i] != words[j][i])
                    return firstWord.Substring(0, i);
            }
        }

        return firstWord;
    }
}