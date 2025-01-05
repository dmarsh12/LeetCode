namespace LeetCode.Medium;

public class RandomizedSet
{

    private readonly HashSet<int> _hashSet;
    private readonly Random _random;
    
    public RandomizedSet()
    {
        _hashSet = new();
        _random = new();
    }
    
    public bool Insert(int val) =>  _hashSet.Add(val);

    public bool Remove(int val) => _hashSet.Remove(val);

    public int GetRandom()
    {
        var index = _random.Next(_hashSet.Count-1);
        return _hashSet.ElementAt(index);
    }
}