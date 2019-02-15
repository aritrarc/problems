using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDynamic
{
    public class StockMax
    {
        //Given an integer as a string, sum all of its substrings cast as integers. As the number may become large, return the value modulo 10^9 + 7.
        private static long sum = 0;
        public static void stockMax(int[] prices)
        {
            // int result = Recurse(prices, 0, 0, 0);
            //int result = (int)getMaxProfit(prices);
            Maximize(prices, 0);
            Console.WriteLine(sum);
        }


        public static long getMaxProfit(int[] prices)
        {
            long profit = 0;
            long maxSoFar = 0;
            for (int i = prices.Length - 1; i > -1; i--)
            {
                if (prices[i] >= maxSoFar)
                {
                    maxSoFar = prices[i];
                }
                profit += maxSoFar - prices[i];
            }
            return profit;
        }

        public static void Maximize(int[] prices, int startIndex)
        {
            if(prices.Length == 0){
                return;
            }

            int max = prices.Max();
            int indexOfMax = prices.ToList().IndexOf(max);
            sum += max * (indexOfMax - startIndex);

            for(int i=startIndex; i< indexOfMax; i++ )
            {
                sum -= prices[i];
            }
            startIndex = indexOfMax + 1;
            if(startIndex >= prices.Length - 1){
                return;
            }
            Maximize(prices.Skip(startIndex).ToArray(), 0);
        }

        private static int Recurse(int[] prices, int index, int count, int sum)
        {
            //Base case
            if (index == prices.Length)
            {
                return sum;
            }


            //Buy
            // count++;
            // sum = sum - prices[index];

            //Sell
            // if(count > 0){
            //     sum = sum + prices[index]*count;
            //     count = 0;
            // }

            //Do Nothing
            index = index + 1;
            return Math.Max(Math.Max(Recurse(prices, index, count + 1, sum - prices[index - 1]), Recurse(prices, index, count, sum)), Recurse(prices, index, count > 0 ? 0 : count, count > 0 ? sum + prices[index - 1] * count : sum));

        }
    }
}