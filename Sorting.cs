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

    public static void Merge_Sort(int[] arr,int low, int high)
    {
        int mid = (low + high)/2;

        if(low < high)
        {
            Merge_Sort(arr, low, mid);
            Merge_Sort(arr, mid + 1, high );
            Merge(arr, low, mid, high);
        }
        PrintSortedArray(arr);
    }

    private static void Merge(int[] arr, int low, int mid, int high)
    {
        int[] lowArray = new int[mid - low + 1];
        int[] highArray = new int[high - low];
        int n1 = mid - low + 1;
        int n2 = high - low;
        //Create two temp arrays for low and high parts
        for(int i = 0; i < n1; i++)
        {
            lowArray[i] = arr[low + i];
        }

        for(int p = 0; p < n2; p++)
        {
            highArray[p] = arr[mid + 1 + p ];
        }

        int x = 0;
        int j = 0;
        int k = low;
        while( x < n1 && j < n2)
        {
            if(lowArray[x] < highArray[j])
            {
                arr[k] = lowArray[x];
                x++;
            }
            else 
            {
                arr[k] = highArray[j];
                j++;
            }
            k++;
        }
        
        while ( j < n2)
        {
            arr[k] = highArray[j];
            j++;k++;
        }

         while ( x < n1)
        {
            arr[k] = highArray[x];
            x++;k++;
        }

    }

    private static void PrintSortedArray(int[] arr){

        for(int x = 0; x < arr.Length; x++)
        {
            Console.WriteLine(arr[x]);
        }
    }
}
