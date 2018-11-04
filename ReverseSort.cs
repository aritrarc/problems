using System;
using System.Collections;
using System.Linq;

namespace ReverseSort
{
    public class ReverseSort{

        // This code is used to reverse a string without using any other DS.
        public static void CheckIfReverseSortable(int[] arr)
        {
            int firstindex = 0;
            int secondindex = 0;
            Boolean flag = false;
            Boolean notexists = false;
            Boolean sorted = true;
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i] < arr[i-1])
                {
                    sorted  = false;

                    if(flag)
                    {
                        notexists = true;
                        break;
                    }
                    firstindex = i - 1;
                    int j = 0;
                    for(j = i+1; j < arr.Length - 1; j++)
                    {
                        if( arr[j] < arr[j+1])
                        {
                            secondindex = j;
                            flag = true;
                            break;
                        }
                    }
                    i=j;
                }
            }

            if(notexists)
            {
                Console.WriteLine("doesn't exist");
            } 
            else
            {
                if(sorted)
                {
                    Console.WriteLine("exist");
                }
                else
                {
                    if(arr[secondindex] >= arr[firstindex - 1] && arr[firstindex] <= arr[secondindex + 1])
                    {
                        Console.WriteLine("exist");
                    }
                    else
                    {
                        Console.WriteLine("doesn't exist");
                    }
                }
                
            }
        }
       
    }
} 