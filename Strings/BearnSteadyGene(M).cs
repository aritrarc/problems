using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStrings
{
    public class BearNSteadyGene{


        //A gene is represented as a string of length n (where  is divisible by 4 ), composed of the letters A, C, T, and G. 
        //It is considered to be steady if each of the four letters occurs exactly n/4 times. Return an integer that represents 
        //the length of the smallest substring to replace to make the gene steady.
        public static void Steadygene(string gene)
        {
            int n = gene.Length;
           int[] cnt = new int[256];
           int mx = n / 4;
           Boolean isSteady = true;

           foreach(char c in gene)
           {
               cnt[c]++;
           }

           string str = "ACTG";
           foreach(char c in str){
               if(cnt[c] > mx){
                   isSteady = false;
               }
           }

           if(isSteady){
               Console.WriteLine(0);
               return;
           }
           else
           {
               int l = 0;
               int r = 0;
               int min_length = n;

               for(; l < n; l++)
               {
                   while(cnt['A'] > mx || cnt['C'] > mx || cnt['T'] > mx || cnt['G'] > mx)
                   {
                       if(r == n)
                       {
                        Console.WriteLine(min_length);
                        return;
                       }
                       cnt[gene[r]]--;
                       r++;
                   }

                   min_length = Math.Min(min_length, r - l);
                   cnt[gene[l]]++;
               }

               Console.WriteLine(min_length);
               return;
           }

        }
       
    }
} 