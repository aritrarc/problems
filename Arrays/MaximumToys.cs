using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximumToys
{
    public class MaximumToys{

        public static void GetMaximumToys(int[] arr,int l)
        {
             Sorting.MergeSort(arr, 0, arr.Length - 1);
            
             int sum = 0;
             int result = 0;
             for(int i=0; i<arr.Length; i++)
             {
                sum += arr[i];
                if(sum > l)
                {
                    result = i;
                    break;
                }
             }
        }
       
    }
} 