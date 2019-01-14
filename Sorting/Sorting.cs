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

    #region SelectionSort
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
    #endregion

    #region BubbleSort
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
   #endregion

    #region InsertionSort
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
    #endregion
    
    #region MergeSort

    public static void MergeSortDriver(int[] arr, int low, int high)
    {
        MergeSort(arr, low, high);
        PrintSortedArray(arr);
    }
    public static void MergeSort(int[] arr, int low, int high)
    {
        
        if(low < high)
        {
            int mid = low + (high - low ) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, mid+1, high);
            Merge(arr, low, mid, high);
        }
    }

    private static void Merge(int[] arr, int low, int mid, int high)
    {
        //Make two copy arrays for laft and right subarrays
        int lsize = mid - low + 1;
        int hsize = high - mid;

        int[] lowarr = new int[lsize];
        int[] higharr = new int[hsize];

        //Copy elements to right and left subarray 
        for(int m = 0; m <lsize; m++)
        {
            lowarr[m] = arr[low + m];
        }

        for(int x = 0; x <hsize; x++)
        {
            higharr[x] = arr[mid + 1 + x];
        }


        int i = 0;
        int j = 0;
        int k = low;

        while ( i < lsize && j < hsize )
        {
            if(lowarr[i] <= higharr[j])
            {
                arr[k] = lowarr[i];
                i++;
            }
            else
            {
                arr[k] = higharr[j];
                j++;
            }
            k++;
        }

        while (i < lsize)
        {
            arr[k] = lowarr[i];
            i++;
            k++;
        }

        while (j < hsize)
        {
            arr[k] = higharr[j];
            j++;
            k++;
        }

    }

    #endregion

    #region Print sorted array
    private static void PrintSortedArray(int[] arr){

        for(int x = 0; x < arr.Length; x++)
        {
            Console.WriteLine(arr[x]);
        }
    }
    #endregion
}
