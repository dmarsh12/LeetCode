namespace LeetCode.Hashmaps.Easy;

public static class IsHappy
{
    // https://leetcode.com/problems/happy-number/?envType=study-plan-v2&envId=top-interview-150
    public static bool Execute(int n)
    {
        var seenNumbers = new Dictionary<int, bool>();
        
        while (n != 1 && !seenNumbers.ContainsKey(n))
        {
            seenNumbers[n] = true;
            n = GetSumOfSquares(n);
        }
        
        return n == 1;
    }
    
    private static int GetSumOfSquares(int num)
    {
        var sum = 0;
        while (num > 0)
        {
            var digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}