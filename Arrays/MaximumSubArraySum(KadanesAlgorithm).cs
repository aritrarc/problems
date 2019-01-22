using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class KadanesAlgorithm
    {
            //Given an array of n integers find the subarray with the maximum sum
            public static void GetMaximumSubArraySum(int[] arr)
            {
                int global_max = 0;
                int max_till_element = 0;
                int left_index = 0;
                int right_index = 0;
                int s = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    max_till_element = Math.Max(arr[i], max_till_element + arr[i]);
                    if(max_till_element > global_max)
                    {
                        global_max = max_till_element;
                        right_index =i;
                        left_index = s;
                    }

                    if(max_till_element < 0)
                    {
                        s = i + 1;
                        max_till_element = 0;
                    }
                }


                Console.WriteLine(global_max);
                Console.WriteLine("Max subarray is:");

                for(int i = left_index; i <= right_index; i++){
                    Console.Write(arr[i] + " ");
                }

            }
    }

}
