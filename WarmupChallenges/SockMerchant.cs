using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSockMerchant
{
    public class SockMerchant
    {

        //John works at a clothing store. He has a large pile of socks that he must pair by color for sale. 
        //Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors
        // there are.
        public static void GetPairs(int n, int[] arr)
        {
            int count = 0;
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for(int i=0; i<n; i++){
                if(pairs.ContainsKey(arr[i])){
                    pairs[arr[i]] = pairs[arr[i]] + 1;
                }
                else{
                    pairs.Add(arr[i], 1);
                }
            }

            foreach(KeyValuePair<int,int> kvp in pairs)
            {
                count += kvp.Value/2 ;
            }
            Console.WriteLine(count);
        }
    }
}