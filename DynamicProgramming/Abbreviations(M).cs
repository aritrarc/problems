using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class Abbreviations
    {
        //Given an array of integers, find the subset of non-adjacent elements with the maximum sum. Calculate the sum of that subset.
        public static void checkIfAbbreviation(string a, string b)
        {
            string result = abbreviation( a,  b)?"YES":"NO";
            Console.WriteLine(result);
        }

        static Boolean abbreviation(string a, string b)
        {
           int[] charArray = new int[256];

           foreach(char c in a){
               charArray[c]++;
           }

           foreach(char c in b)
           {
               if(charArray[c] > 0){
                   charArray[c]--;
               }
               else if (charArray[c + 32] > 0){
                   charArray[c + 32]--;
               }
               else{
                   return false;
               } 
           }

            for(int i=65; i<=90; i++){
                if(charArray[i] > 0){
                    return false;
                }
            }

           return true;
        }
    }
}