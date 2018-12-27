using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsGreedy
{
    public class LuckBalance
    {
        // If Lena loses no more than  important contests, 
        // what is the maximum amount of luck she can have after 
        // competing in all the preliminary contests? This value may be negative.
        public static void GetMaximumLuck(int k, int[][] contests)
        {
            int balance = 0;
            int arrLength = contests.Length;
            var importantContests = new List<int>();

            for(int i=0; i<arrLength; i++)
            {
                if(contests[i][1] == 0)
                {
                    balance += contests[i][0];
                }
                else{
                    int index = importantContests.BinarySearch(contests[i][0]);
                    if (index < 0) index = ~index;
                    importantContests.Insert(index, contests[i][0]);
                }
            }

            int value = importantContests.Take(importantContests.Count - k).Sum();

            balance = balance + importantContests.Skip(importantContests.Count - k).Take(k).Sum() - value;

            Console.WriteLine(balance.ToString());
        }
    }
}