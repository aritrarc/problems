using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class MinimumWindowSumInArray
    {
            //Given an array of n integers and a number k, Find the minimum contiguous subarray whose sum is equal to k.
            public static void GetminimumWindowSum(int[] arr, int k)
            {
                int back = 0, front = 0;
                int sum = 0;
                int min_window_size = Int16.MaxValue;

                for(back = 0; back < arr.Length; back++)
                {
                    while(front < arr.Length && sum + arr[front] <= k)
                    {
                        sum = sum + arr[front];
                        front++;
                    }

                    if(sum == k)
                    {
                        int window_size = front - back;
                        if(window_size <= min_window_size){
                            min_window_size = window_size;
                        }
                    }

                    sum -= arr[back];
                }

                Console.WriteLine(min_window_size);
            }
    }

}
