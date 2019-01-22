using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class FindTripletsSum
    {
            //Given an array of n integers find triplets where sum of first two elements equal to the third element
            public static void GetTripletsInArray(int[] arr)
            {
                int n = arr.Length;
                Array.Sort(arr);
                int x = 0;
                int y = 0;
                Boolean exists = false;

                for(int i = n - 1 ; i > 0 ; i --)
                {
                    x = 0;
                    y = i - 1;

                    while(x < y){

                        if(arr[x] + arr[y] == arr[i]){

                            Console.WriteLine("(" + arr[x] + ',' + arr[y] +',' + arr[i] + ")");
                            exists = true;
                            break;
                        }
                        else if (arr[x] + arr[y] > arr[i])
                        {
                            y--;
                        }
                        else{
                            x++;
                        }

                    }
                }

                if(!exists)
                {
                    Console.WriteLine("No triplet exists");
                }

            }

            public static void GetTripletsInArrayEqualToSum(int[] arr, int sum)
            {
                int n = arr.Length;
                Array.Sort(arr);
                int x = 0;
                int y = 0;

                for(int i = n - 1 ; i > 0 ; i --)
                {
                    x = 0;
                    y = i - 1;

                    while(x < y){

                        if(arr[x] + arr[y] + arr[i] == sum){

                            Console.WriteLine("(" + arr[x] + ',' + arr[y] +',' + arr[i] + ")");
                            return;
                        }
                        else if (arr[x] + arr[y] > arr[i])
                        {
                            y--;
                        }
                        else{
                            x++;
                        }

                    }
                }


                Console.WriteLine("No triplet exists");


            }
    }

}
