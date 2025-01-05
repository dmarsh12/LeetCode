using System.Collections;

namespace LeetCode.Hard;

public static class TextJustification
{
    public static IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new List<string>();
        var current = 0;
        var currentResult = "";
        for (var i = 0; i < words.Length; i++)
        {
            currentResult = words[i];

            while (current < maxWidth && i + 1 < words.Length)
            {
                var next = " " + words[i + 1];

                var length = currentResult.Length + next.Length;
                if (length <= maxWidth)
                {
                    currentResult += next;
                    current += next.Length;
                    i++;
                }
                else if (length > maxWidth)
                {
                    var currentWords = currentResult.Split(" ");
                    var padding = ((maxWidth - currentResult.Length) / currentResult.Length);
                    var paddedResult = "";
                    foreach (var w in currentWords)
                        paddedResult += w.PadRight(padding, ' ');
                    result.Add(paddedResult);
                }
                else
                {
                    var paddedResult = currentResult.PadRight(maxWidth, ' ');
                    result.Add(paddedResult);
                    current = 0;
                    currentResult = "";
                    break;
                }
            }
        }
        
        if (!string.IsNullOrEmpty(currentResult))
            result.Add(currentResult.PadRight(maxWidth, ' '));
        
        return result;
    }
}