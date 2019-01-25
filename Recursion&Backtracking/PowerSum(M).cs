using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //Find the number of ways that a given integer, X, can be expressed as the sum of the Nth powers of unique, natural numbers.
    public class PowerSum
    {
        public static void GetPowerSum(int x, int n)
        {
            int count = Recurse(x,n);
           Console.WriteLine(count);
        }

        static int Recurse(int x, int n, int curr_num = 1, int curr_sum = 0){

             
            int p = (int)Math.Pow(curr_num, n);
            int count = 0;

            while( p + curr_sum < x)
            {
                count+= Recurse(x, n, curr_num + 1, p + curr_sum);
                curr_num++;
                p = (int)Math.Pow(curr_num, n);
            }

            if( p + curr_sum == x){
                count++;
            }

            return count;
        }   

    }
}