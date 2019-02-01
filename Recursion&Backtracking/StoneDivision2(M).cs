
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //You have a pile of n stones that you want to split into multiple piles, as well as a set, S, of m distinct integers
    //look for some x in S such that x!= y and y is divisible by x (i.e., x is a factor of y); if such an x exists, 
    //you can split the pile into y/x equal smaller piles.
     //Calculate the maximum possible number of moves you can perform and print it on a new line.
    
    public class StoneDivision2
    {
        static Dictionary<string, long> memonization = new Dictionary<string, long>();
        public static void stoneDivision(long n, long[] s)
        {
            memonization.Clear();
            long result = Recurse(n, 1, s);
            Console.WriteLine(result);
        }


        public static long Recurse(long curr_value, long num_of_Stacks, long[] s)
        {

            string key = curr_value + "," + num_of_Stacks;
            if(memonization.ContainsKey(key)){
                return memonization[key];
            }

            long max = 0;
            long local_max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                
                if (s[i] < curr_value && curr_value % s[i] == 0)
                {
                    long num_stacks = curr_value / s[i];
                    //local_max = 1 + num_of_Stacks * Math.Max(local_max, Recurse(s[i], curr_value / s[i], s, smallest));
                    local_max = 1 + num_stacks * Recurse(s[i], curr_value / s[i], s);
                    max = Math.Max(local_max, max);
                }

            }
            memonization[key] = max;
            return max;
        }
    }
}