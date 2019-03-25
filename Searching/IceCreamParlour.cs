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

public class Solution {

    // Complete the whatFlavors function below.
    public static void whatFlavors(int[] cost, int money) {

            Dictionary<int, int> parameters = new Dictionary<int, int>();

            for(int j=0; j<cost.Length; j++)
            {
                int value = money - cost[j];
                if(parameters.ContainsKey(value))
                {
                    if(Convert.ToInt32(parameters[value]) != j)
                    {
                        if(Convert.ToInt32(parameters[value])  + 1 >  j+1)
                        {
                            Console.WriteLine((j+1) + " " + parameters[value] + 1);
                            return;
                        }
                        else
                        {
                            Console.WriteLine(parameters[value] + 1 + " " + (j+1));
                            return;
                        }
                    }
                }
                else{
                    if(!parameters.ContainsKey(cost[j]))
                    {
                             parameters.Add(cost[j], j);
                    }
                   
                }
            }
    }

    public static void BinarySearch(int[] arr, int value)
    {
        int[] clonedArray = (int[] )arr.Clone();
        Array.Sort(clonedArray);
        int index1 = 0;
        int index2 = 0;
        for(int i = 0; i < clonedArray.Length; i++)
        {
            int complement = value - clonedArray[i];

            int position = Array.BinarySearch(clonedArray, i + 1, clonedArray.Length - i - 1, complement);

            if(position > 0)
            {
                //We found our elements . Now get their index from original array
                index1 = Array.IndexOf(arr, clonedArray[i]);
               for (int x = 0; x < arr.Length; x++)
                {
                    if (arr[x] == complement && x != index1)
                    {
                        index2 = x;
                        break;
                    }
                }
                break;
            }
        }
        
        Console.WriteLine((Math.Min(index1, index2) + 1).ToString() + " " + (Math.Max(index1, index2) + 1).ToString());
    }

    public int[] TwoSum(int[] nums, int target) {
        int[] copyArray = (int[])nums.Clone();
        Array.Sort(nums);
        int i = 0;
        int j = nums.Length - 1;
        
        int[] result = new int[2];
        
        while(i < j){
            
            if(nums[i] + nums[j] == target){
                result[0] = IndexOfHelper(copyArray, nums[i], -1);
                result[1] = IndexOfHelper(copyArray, nums[j], result[0]);
                break;
            }
            else if (nums[i] + nums[j] > target){
                j--;
            }
            else{
                i++;
            }
        }
        return result;
    }
    
    private static int IndexOfHelper(int[] copyArray, int value, int ignore ){
        for(int i=0; i<copyArray.Length; i++){
            if(copyArray[i] == value && i != ignore){
                return i;
            }
        }
        return -1;
    }

}
