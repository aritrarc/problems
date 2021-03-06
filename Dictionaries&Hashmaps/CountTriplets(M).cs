using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDictionariesnHashmaps
{
    public class CountTriplets
    {

        //It should return the number of triplets forming a geometric progression for a given r as an integer.
        public static void NumberOfTriplets(List<long> arr, long r)
        {

            var mp2 = new System.Collections.Generic.Dictionary<long, long>();
            var mp3 = new System.Collections.Generic.Dictionary<long, long>();
            long res = 0;
            foreach (long val in arr)
            {
                if (mp3.ContainsKey(val))
                    res += mp3[val];
                if (mp2.ContainsKey(val))
                    if (mp3.ContainsKey(val * r))
                        mp3[val * r] += mp2[val];
                    else
                        mp3[val * r] = mp2[val];
                if (mp2.ContainsKey(val * r))
                    mp2[val * r]++;
                else
                    mp2[val * r] = 1;
            }


            Console.WriteLine(res);
        }

    }
}