using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDynamic
{
    public class SherlockAndCost
    {
        //You will be given an array B and must determine an array A. There is a special rule: For all i, A[i] <= B[i] . That is, A[i] can be any number you choose
        // such that 1 <= A[i] <= B[i]. Your task is to select a series of A[i] given B[i] such that the sum of the absolute difference of consecutive pairs of A is maximized
        private static long sum = 0;
        public static void cost(int[] B)
        {
            // int result = Recurse(prices, 0, 0, 0);
            //int result = (int)getMaxProfit(prices);
            //int result = Math.Max(Recurse(B, B.Length - 1, 1), Recurse(B, B.Length - 1, B[B.Length - 1]));
            int result = NonRecursive(B);
            Console.WriteLine(result);
        }
        

        //Times out on most test cases.
        private static int Recurse(int[] arr, int index, int value)
        {
                //Base Case
                if(index == 1){
                    if(value == 1){
                        return Math.Abs(arr[0] - 1);
                    }else {
                        return Math.Abs(1 - value);
                    }
                }

                return Math.Max(Math.Abs(value - 1) + Recurse(arr, index - 1, 1), Math.Abs(arr[index - 1] - value) + Recurse(arr, index - 1, arr[index - 1])); 
        }

        private static int NonRecursive(int[] arr)
        {
            int max_1 = 0;
            int max_High = 0;


            for(int i=1; i <= arr.Length-1; i++)
            {
                int val = Math.Max( max_1, max_High + Math.Abs(1 - arr[i-1]));
                int val2 = Math.Max( max_1 + Math.Abs(arr[i] - 1) , max_High + Math.Abs(arr[i] - arr[i - 1]));
                max_1 = val;
                max_High = val2;
            }

            return Math.Max(max_1, max_High);
        }
    }
}