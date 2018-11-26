using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MinimumAbsoluteDifference
{
    //Given an array of integers, find and print the minimum absolute difference between any two elements in the array. 
    public class MinimumAbsoluteDifference
    {
        public static void GetminimumDifference(int[] arr)
        {
            Array.Sort(arr);
            int min = Math.Abs(arr[1] - arr[0]);
            for(int i=1; i< arr.Length -1; i++)
            {
                if( Math.Abs(arr[i+1] - arr[i]) < min){
                    min = Math.Abs(arr[i+1] - arr[i]);
                }
            }

            Console.WriteLine(min.ToString());
        }
    }
}