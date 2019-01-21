using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class RemoveDuplicatesInArray
    {
            //Given an array of n integers. Print the length of array after removing all duplicates. 
            //Don't use any other data structure. Space complexity should be O(1)
            public static void RemoveDuplicates(int[] nums)
            {
                int result = 1;
                Array.Sort(nums);

                int i = 0; int j = 1;
                while(i < nums.Length && j < nums.Length)
                {
                   if(nums[i] != nums[j])
                   {
                       result++;
                      
                   }
                     i++;
                     j++;                  
                }
                Console.WriteLine(result);
            }
    }

}
