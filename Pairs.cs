using System;
using System.Collections;
using System.Linq;

namespace Pairs
{
    public class Pairs{

        //You will be given an array of integers and a target value. Determine the number of pairs of array elements 
        //that have a difference equal to a target value.
        public static void FindPairs(int[] arr, int k)
        {
             int result = 0;
             Array.Sort(arr);
             int i = 0;
             int j = 1;
             while( j < arr.Length)
             {
                 int diff = arr[j] - arr[i];
                 if(diff == k)
                 {
                     result++;
                     j++;
                 }
                 else if ( diff < k)
                 {
                     j++;
                 }
                 else{
                     i++;
                 }
             }
             Console.WriteLine(result.ToString());
        }
    }
} 