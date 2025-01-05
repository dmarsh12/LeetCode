namespace LeetCode.Medium.Arrays;

public static class MaxProfit
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/?envType=study-plan-v2&envId=top-interview-150
    public static int Execute(int[] prices)
    {
        var maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                var current = prices[j] - prices[i];
                if (current > 0)
                    maxProfit += current;
            }
        }

        return maxProfit;
    }
}