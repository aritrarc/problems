using System;
using System.Collections;
using System.Linq;

namespace Pairs
{
    public class Pairs{

        // A string is said to be a special palindromic string if either of two conditions is met:
        // All of the characters are the same, e.g. aaa.
        // All characters except the middle one are the same, e.g. aadaa.
        // A special palindromic substring is any substring of a string which meets one of those criteria. Given a string, determine how many special palindromic substrings can be formed from it.
        public static void FindPairs(int[] arr, int num)
        {
             int result = 0;
             Array.Sort(arr);
             int i = 0;
             int j = 1;
             while( j < arr.Length)
             {
                 int diff = arr[j] - arr[i];
                 if(diff == num)
                 {
                     result++;
                     j++;
                 }
                 else if ( diff < num)
                 {
                     i++;
                 }
                 else{
                     j++;
                 }
             }
             Console.WriteLine(result.ToString());
        }
    }
} 