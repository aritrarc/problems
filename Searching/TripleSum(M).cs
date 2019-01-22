using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TripleSum
{
    public class TripleSum
    {

        //Given 3 arrays a,b,c of different sizes, find the number of distinct triplets (p,q,r) where 
        //p is an element of a, q of b and r of c satisfying the criteria: p <= q and q >= r.
        public static void NumberOfTriplets(int[] a,int[] b, int[] c)
        {
            long total = 0;

            a = a.Distinct().OrderBy( l => l).ToArray();
            b = b.Distinct().OrderBy( l => l).ToArray();
            c = c.Distinct().OrderBy( l => l).ToArray();

            long x = 0 ; long y = 0;
            for(int i = 0; i < b.Length ; i++)
            {
                

                while( x < a.Length && a[x] <= b[i])
                {
                    x++; 
                }

                while( y < c.Length && c[y] <= b[i])
                {
                    y++;
                }

                total += x*y;
            }

            Console.WriteLine(total);
        }
    }
}