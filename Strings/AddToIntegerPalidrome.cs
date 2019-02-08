using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AddToIntegerPalindrome
{
    public class AddToIntegerPalindrome{

        public static void GetNumberToIntegerPalindrome(int x)
        {
             int[] intArr = x.ToString().Select( a => Convert.ToInt32(a)).ToArray();
             int lastIndex = intArr.Length - 1;
             List<int> intsl = new List<int>();
             for(int i=0; i<lastIndex; i++)
             {
                 if(intArr[i] == intArr[lastIndex])
                 {
                     int counter = i+1;
                     while( counter < lastIndex)
                     {
                         if(intArr[counter] != intArr[i])
                         {
                             intsl.Add(intArr[i]);
                         }
                        counter++;
                     }
                 }
                 else
                 {
                     intsl.Add(intArr[i]);
                 }
             }

             
        }
       
    }
} 