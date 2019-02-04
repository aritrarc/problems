using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class MaxSubArraySum
    {
        //Given an array of integers, find the subset of non-adjacent elements with the maximum sum. Calculate the sum of that subset.
        private static int global_max = 0;
        public static void maxSubsetSum(int[] arr)
        {
            //Recursive(arr, arr.Length - 1);
            //getmax(arr);
            maxSubArray(arr);
            Console.WriteLine(global_max);
        }

        static int getmax(int[] arr)
        {
            int n = arr.Length;
            int[] valueArr = new int[n];

            valueArr[0] = arr[0];
            if(arr[1] > arr[0])
            {
                valueArr[1] = arr[1];
                global_max  = arr[1];
            }else{
                valueArr[1] = valueArr[0];
                global_max = valueArr[0];
            }

            for(int i=2; i<arr.Length; i++)
            {
                int local_max = Math.Max(arr[i], arr[i] + valueArr[i-2]);
                if(local_max > global_max){
                    global_max = local_max;
                }
                valueArr[i] = global_max;
            }

            return global_max;
        }

        static int[] maxSubArray(int[] arr)
        {
            
            int n = arr.Length;
            int[] valueArr = new int[n];
            int subsequenceSum = 0;
            int[] answer = new int[2];

            valueArr[0] = arr[0];
            global_max = arr[0];

            subsequenceSum = arr[0];
            //Max Subsequence
            // if(arr[0] < 0){
            //     subsequenceSum += arr[0];
            // }
            //End

            for(int i=1; i<arr.Length; i++)
            {
                //Max Subsequence
                if(arr[i] > 0){
                    if(subsequenceSum < 0){
                        subsequenceSum = arr[i];
                    }else{
                        subsequenceSum += arr[i];
                    }
                }else if (arr[i] > subsequenceSum && subsequenceSum < 0){
                    subsequenceSum = arr[i];
                }
                //End

                int local_max = Math.Max(arr[i], arr[i] + valueArr[i-1]);
                if(local_max > global_max){
                    global_max = local_max;
                }
                valueArr[i] = local_max;
            }

            answer[0] = global_max;
            answer[1] = subsequenceSum;
            return answer;
        }
    }
}