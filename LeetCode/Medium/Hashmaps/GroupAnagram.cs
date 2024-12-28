namespace LeetCode.Hashmaps.Medium;

public class GroupAnagram
{
    // https://leetcode.com/problems/group-anagrams/?envType=study-plan-v2&envId=top-interview-150
    // "eat","tea","tan","ate","nat","bat"]
    // [["bat"],["nat","tan"],["ate","eat","tea"]]
    public static IList<IList<string>> Execute(string[] strs)
    {
        var lookup = new Dictionary<string, List<string>>();
        foreach (var word in strs)
        {
            var wordArray = word.ToCharArray();
            
            Array.Sort(wordArray);
            
            var wordArrayStr = new string(wordArray);
            
            if (lookup.ContainsKey(wordArrayStr))
            {
                lookup[wordArrayStr].Add(word);
                continue;
            }
            
            lookup.Add(wordArrayStr, new() { word} );
        }

        IList<IList<string>> result = new List<IList<string>>();
        foreach (var kvp in lookup)
            result.Add(kvp.Value);

        return result;
    }
}