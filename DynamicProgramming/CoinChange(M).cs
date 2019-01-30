using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class CoinChange
    {
       private static Dictionary<string, long> memonize = new Dictionary<string, long>();
       static Dictionary<long, long> sumCoins = new Dictionary<long, long>();

        public static long Recurse(long sum, long[] c, int index)
        {
            if( sum == 0){   //Base case
                return 1;
            }

            if(sum < 0){   //Base case
                return 0;
            }

            if(sum >=1 && index<= 0){  //Base case
                return 0;
            }

            string key = sum + "," + index;
            if(memonize.ContainsKey(key)){
                return memonize[key]; 
            }



            long result =  Recurse(sum - c[index - 1], c, index) + Recurse(sum, c, index -1);
            memonize.Add(key, result);
            return result;

        }

        public static void DriverMethod(long n, long[] c)
        {
            long result = Recurse(n, c, c.Length);
            Console.WriteLine(result);
        }

        public static long RecurseToSum(long sum, long[] elements)
        {
            if(sum == 0){
                return 0;
            }
            
            if(sumCoins.ContainsKey(sum)){
                return sumCoins[sum];
            }

            long min = Int32.MaxValue;
            long local_min = 0;

            for(int i=0; i<elements.Length; i++)
            {
                //If sum is still greater, we continue to recurse
                if(sum >= elements[i])
                {
                    //Find the local min of each recusrion path. i.e. for each element find the minimum number of elements to make the sum
                    local_min = 1 + Math.Min(min, RecurseToSum(sum - elements[i], elements));

                    //Update global minimum to local minimum, if it is greater than minimum of current recursion path.
                    if(local_min < min){
                        min = local_min;
                    }
                }
            }
            sumCoins.Add(sum, min);
            return min;
        }

        public static void DriverToSum(long sum, long[] elements)
        {
             long result = RecurseToSum( sum, elements);
            Console.WriteLine(result);
        }

    }
}