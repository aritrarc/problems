using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TripleSum
{
    public class TripleSum
    {

        public static void NumberOfTriplets(int[] a,int[] b, int[] c)
        {
            int total = 0;
            int aCount = 0;
            int cCount = 0;
            Array.Sort(a.Distinct().ToArray());
            Array.Sort(b.Distinct().ToArray());
            Array.Sort(c.Distinct().ToArray());

            for(int i=0; i<b.Length; i++)
            {
                int j=0;
                while( j< a.Length && a[j] <= b[i]){
                    if(j == 0 || a[j-1] != a[j]){
                    aCount++;
                    }
                    j++;
                }

                int l=0;
                while( l< c.Length && c[l] <= b[i]){
                     if(l == 0 || c[l-1] != c[l]){
                          cCount++;
                     }
                    l++;
                }

                total += aCount*cCount;
            }
        }
    }
}