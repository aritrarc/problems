using System;
using System.Collections;
using System.Linq;

namespace Sorting
{
    public class Sorting{

        // This code is used to reverse a string without using any other DS.
        public static void InsertionSort(int[] arr)
        {
             for(int i = 1; i < arr.Length; i++)
             {
                 for(int j = 0; j < i ; j++)
                 {
                     if( arr[j] > arr[i])
                     {
                         int temp = arr[j];
                         arr[j] = arr[i];
                         int k = i;
                        for( k = i; k  > j ; k--)
                        {
                            arr[k] = arr[k - 1];
                        }
                        arr[k + 1] = temp;
                     }

                 }
             }

             printSortedArray(arr);
        }

        private static void printSortedArray(int[] arr)
        {
            for(int i = 0 ; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
       
    }
} 