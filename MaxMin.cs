using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaxMin
{
    public class MaxMin
    {

    //You will be given a list of integers, arr, and a single integer k. You must create an array of length k from elements of arr
    //such that its unfairness is minimized. Call that array . Unfairness of an array is calculated as difference
    // between max and min of that array

        public static void MinimumUnfairness(int k, int[] arr)
        {
            int unfairness = 2147483647;

            Array.Sort(arr);           

            for(int i = 0; i <= (arr.Length - k); i++)
            {
                if ( (arr[i + k - 1] - arr[i]) < unfairness)
                {
                    unfairness = arr[i + k -1] - arr[i];
                } 
            }

            Console.WriteLine(unfairness.ToString());
        }
    }
}