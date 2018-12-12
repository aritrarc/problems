using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSockMerchant
{
    public class RepeatedString
    {
        //Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
        //Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.
        //For example, if the string 'abcac' and n=10, the substring we consider is abcacabcac, the first 10 characters of 
        //her infinite string. There are  occurrences of a in the substring.
        public static void GetNumberOfA(string s, long n)
        {
            long count = 0;
            long aCount = 0;
            long aCount2 = 0;
            int length = s.Length;

            long remaining = n % length;
            long number = n / length;

            string s1 = s.Substring(0,Convert.ToInt32(remaining));
            string s2 = s.Substring(Convert.ToInt32(remaining));

            for(int i = 0; i < s1.Length; i++){
                if(s1[i] == 'a'){
                    aCount++;
                }
            }

            for(int i = 0; i < s2.Length; i++){
                if(s2[i] == 'a'){
                    aCount2++;
                }
            }
            long totalCount = 0;
            totalCount = aCount + aCount2;
            count = aCount + totalCount*number;
            Console.WriteLine(count);
        }

    }
}