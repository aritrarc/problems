using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class GameOfTwoStacks
    {
         //In each move, Nick can remove one integer from the top of either stack A or stack B.
         //Nick keeps a running sum of the integers he removes from the two stacks.
         //Nick is disqualified from the game if, at any point, his running sum becomes greater than some integer x given at the beginning of the game.
        //Nick's final score is the total number of integers he has removed from the two stacks.
        //Given A, B and x for q games, find the maximum possible score Nick can achieve 
        //(i.e., the maximum number of integers he can remove without being disqualified) during each game and print it on a new line.
        public static void MaxScore(int x, int[] a, int[] b)
        {
            int count = 0;
            int i = 0, j = 0;
            int sum = 0;

            //Considering only Stack1
            while (i < a.Length && sum <= x)
            {

                sum += a[i];
                if (sum <= x)
                {
                    count++;
                }
                i++;
            }

            while (j < b.Length && i >= 0)
            {
                sum += b[j];
                j++;
                while (sum > x && i > 0)
                {
                    i--;
                    sum -= a[i];
                }
                if(sum<=x && i+j>count)
                count=i+j;
            }

            Console.WriteLine(count);
        }

    }
}