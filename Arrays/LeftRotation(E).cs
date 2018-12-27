using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public class LeftRotation
    {
            //Given an array of n integers and a number d, , perform d left rotations on the array.
            // Then print the updated array as a single line of space-separated integers.
            public static void RotateLeft(int[] arr, int d)
            {
                int n = arr.Length;
                int[] copyarr = new int[n];

               for(int i = 0; i< arr.Length; i++)
               {
                   int index = (i + d >= n) ? i + d - n : i +d;
                   copyarr[i] = arr[index];
               }
            
                for(int j = 0; j < copyarr.Length; j++)
                {
                    Console.Write(copyarr[j] + " ");
                }
            }
    }

}
