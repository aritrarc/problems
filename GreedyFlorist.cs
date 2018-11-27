using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GreedyFlorist
{
    public class GreedyFlorist
    {
    // To do this, he decides he'll multiply the price of each flower by the number of that customer's previously purchased flowers
    // plus 1. The first flower will be original price, ( 0 + 1)*originalprice , the next will be ( 1 + 1)*originalprice and so on.
    // Given the size of the group of friends, the number of flowers they want to purchase and the original prices of the flowers,
    // determine the minimum cost to purchase all of the flowers.
        public static void MInimizeCost(int k, int[] c)
        {
            int cost = 0;
            int increment = 0;
            int i = 0;

            c = c.OrderByDescending(x => x).ToArray();

            while( i < c.Length)
            {
                if( i != 0  && i % k == 0)
                {
                    increment++;
                }
                cost += (increment + 1)*c[i];
                i++;
            }

            Console.WriteLine(cost.ToString());
        }
    }
}