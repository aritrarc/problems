using System;
using System.Collections;
using System.Linq;

namespace SpecialPalindrome
{
    public class SpecialPalindrome{

        // A string is said to be a special palindromic string if either of two conditions is met:
        // All of the characters are the same, e.g. aaa.
        // All characters except the middle one are the same, e.g. aadaa.
        // A special palindromic substring is any substring of a string which meets one of those criteria. Given a string, determine how many special palindromic substrings can be formed from it.
        public static void FindSpecialPalindromeCount(string str)
        {
             int count = 0;
             int start = 0;
             int x = str.Length;
             int result = palindromeRecurse(str);
             Console.WriteLine(result.ToString());
        }

        private static int palindromeRecurse(string str){

            int n = str.Length;
            int result = 0;
            int[] sameChar = new int[n];
            int i = 0;
            while (i < n)
            {
                int samecharCount = 1;
                int j = i + 1;
                while( j < n && str[i] == str[j] )
                {
                    j++; samecharCount++;
                }
                result += (samecharCount * (samecharCount + 1)/2);
                sameChar[i] = samecharCount;
                i = j;
            } 

            for( int  j=1; j<n; j++)
            {
                if(str[j] == str[j - 1]){
                    sameChar[j] = sameChar[j - 1];
                }

                if(j > 0 && j < (n - 1) && 
                (str[j - 1] == str[j + 1] && str[j] != str[j - 1])) {
                    result += Math.Min(sameChar[j - 1], 
                          sameChar[j + 1]);
                }
            }
            return result;
        }
       
    }
} 