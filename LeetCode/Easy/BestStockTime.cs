using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //        Input: prices = [7,1,5,3,6,4]
    //        Output: 5
    //        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    //        Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    public static class BestStockTime
    {

        // 5
        public static void ExampleOne()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
        }

        // 0
        public static void ExampleTwo() 
        {
            var prices = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static void ExampleThree() 
        {
            var prices = new int[] { 1, 4, 2 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static void ExampleFour()
        {
            var prices = new int[] { 1, 2, 4 };
            Console.WriteLine(MaxProfit(prices));
        }

        // O(n^2)
        public static int MaxProfitBad(int[] prices)
        {
            var maxProfit = 0;
 
            if (prices.Length <= 2)
            {
                if (prices.Length <= 1)
                    return 0;

                return prices[1] > prices[0] ? 1 : 0;
            }

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {                    
                    var currentMaxProfit = prices[j] - prices[i];
                    if (currentMaxProfit > maxProfit)
                    {
                        maxProfit = currentMaxProfit;
                    }
                }
            }

            return maxProfit;
        }

        // O(n)
        public static int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int max = 0;
            for (int i = 0; i <= prices.Length - 1; i++) 
            {
                if (prices[i] < min)
                    min = prices[i];
                else if (prices[i] - min > max)
                    max = prices[i] - min;
            }

            return max;
        }
    }
}
