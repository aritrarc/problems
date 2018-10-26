using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Sorting {

    // Various sorting algorithms
    public static void SelectionSort(int[] arr) {
        Console.WriteLine("Selection Sort");

        for(int i=0; i<arr.Length; i++)
        {
            for(int j=i+1; j <arr.Length; j++)
            {
                if(arr[j] < arr[i])
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        PrintSortedArray(arr);
    }

    public static void BubbleSort(int[] arr) {
        Console.WriteLine("Bubbble Sort");

        for(int i=arr.Length -1; i >= 0 ; i--)
        {
            for(int j=i-1; j >= 0; j--)
            {
                if(arr[j] >  arr[i])
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        PrintSortedArray(arr);
    }

    public static void InsertionSort(int[] arr)
        {
            Console.WriteLine("Insertion Sort");
            
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

             PrintSortedArray(arr);
        }

    private static void PrintSortedArray(int[] arr){

        for(int x = 0; x < arr.Length; x++)
        {
            Console.WriteLine(arr[x]);
        }
    }
}
