using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class MaxElementInSubArray
    {
            //Given an array of n integers and a number d, , perform d left rotations on the array.
            // Then print the updated array as a single line of space-separated integers.
            public static void GetMaxElementInSubArray(int[] arr, int k)
            {
                List<int> results = new List<int>();

                //Use this DS to do push and pop operations
                List<int> dQ = new List<int>();

                for(int i=0; i<k; i++)
                {

                    if(dQ.Count == 0 || arr[dQ[dQ.Count - 1]] > arr[i]){
                        dQ.Add(i);
                    }
                    else{

                        while(dQ.Count != 0  && arr[dQ[dQ.Count - 1]] <= arr[i])
                        {
                            //POP element at last Index
                            dQ.RemoveAt(dQ.Count - 1);
                        }
                        dQ.Add(i);
                    }
                }

                for(int j = k; j < arr.Length; j++)
                {
                    int x = 0;

                     //Add the leftmost element to results array
                    results.Add(arr[dQ[0]]);

                    //Remove elements outside the window
                    while(  dQ.Count != 0 && dQ[x] <= j - k)
                    {
                        dQ.RemoveAt(x);
                    }

                    if(dQ.Count == 0 || arr[dQ[dQ.Count - 1]] > arr[j]){
                        dQ.Add(j);
                    }
                    else{

                        while(dQ.Count != 0  && arr[dQ[dQ.Count - 1]] <= arr[j])
                        {
                            //POP element at last Index
                            dQ.RemoveAt(dQ.Count - 1);
                        }
                        dQ.Add(j);
                    }
                }

                results.Add(arr[dQ[0]]);

                //Print results List
                foreach (int m in results)
                {
                    Console.Write(m + ",");   
                }
            }
    }

}
