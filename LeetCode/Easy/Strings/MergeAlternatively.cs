using System.Text;

namespace LeetCode.Easy.Strings;

public static class MergeAlternatively
{
    public static string Execute(string word1, string word2)
    {
        var result = new StringBuilder();
        var current = 0;
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1.Length > i) 
                result.Append(word1[i]);
            
            if (word2.Length > i)
                result.Append(word2[i]);
            
            current = i + 1;
        }
        
        for (int i = current; i < word2.Length; i++)
            result.Append(word2[i]);

        return result.ToString();
    }
}