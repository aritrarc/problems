using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSearching
{
    public class MinimumLoss
    {

        //Lauren has a chart of distinct projected prices for a house over the next several years. She must buy the house in one year and sell it in another, 
        //and she must do so at a loss. She wants to minimize her financial loss.
        public static void minimumLoss(long[] price)
        {
            long minLoss = Int32.MaxValue;

            List<long> tempArray = price.ToList();

            tempArray.Sort();
            int n = price.Length;

            for(int i=1; i<n; i++)
            {

            //     int pos =  tempArray.BinarySearch(price[i]);
            //    long local_min = -1;
            //    pos = pos < 0 ? ~pos : pos;

            //    if(pos > 0 && pos < n)
            //    {
            //        int index = pos - 1;
            //        if(index >= 0)
            //        {

            //             local_min = price[i] - tempArray[index];
            //             tempArray.RemoveAt(pos);
            //        }

            //        if(local_min > 0 && local_min < minLoss){
            //            minLoss = local_min;
            //        }
            //    }
                if( tempArray[i] - tempArray[ i -1] < minLoss && Array.IndexOf(price, tempArray[i]) < Array.IndexOf(price, tempArray[i - 1])){
                    minLoss = tempArray[i] - tempArray[ i -1];
                }

            }

             Console.WriteLine(minLoss);
        }
    }
}