using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //Given an integer, we need to find the super digit of the integer.
    //If x has only  digit, then its super digit is x. Otherwise, the super digit of x is equal to the super digit of the sum of the digits of x.
    //You are given two numbers n and k. The number p is created by concatenating the string n k times. Find the superdigit of this number p.
    public class SuperDigit
    {       
        static long superdigit1(long n){

            if( n / 10 < 1){
                return n;
            }

            long x =  sum(n);
            return superdigit1(x);
        }

        static long sum(long x)
        {
             if (x==0){
                 return 0;
             }
           return ( x%10 + sum(x / 10));
        }

        public  static void superDigit(string n, int k) {
             string s = string.Empty;
             long sum1 = 0;

             int length = n.Length;
             int start = 0;
             while(length / 10 >= 1){
                sum1 += sum(Convert.ToInt64(n.Substring(start, 10)));
                start = start + 10;
                length = length - 10;
             }
             if(length > 0){
                 sum1 += sum(Convert.ToInt64(n.Substring(start, length)));
             }  
             sum1 = k*sum1;

            int result = Convert.ToInt32(superdigit1(Convert.ToInt64(sum1)));
            Console.WriteLine(result);
        }
    }
}