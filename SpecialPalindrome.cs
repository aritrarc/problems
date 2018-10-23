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
             // store count of special Palindromic substring 
            int result = 0;
            // it will store the count of continues same char 
            int[] sameChar = new int[n];
            int i = 0;

             // traverse string character from left to right 
            while (i < n)
            {
                // store same character count 
                int samecharCount = 1;
                int j = i + 1;

                 // count smiler character 
                while( j < n && str[i] == str[j] )
                {
                    j++; samecharCount++;
                }

                // Case : 1 
                // so total number of substring that we can 
                // generate are : K *( K + 1 ) / 2 
                // here K is sameCharCount 
                result += (samecharCount * (samecharCount + 1)/2);

                // store current same char count in sameChar[] 
                // array 
                sameChar[i] = samecharCount;
                i = j;
            } 

               // Case 2: Count all odd length Special Palindromic 
                // substring
            for( int  j=1; j<n; j++)
            {

                // if current character is equal to previous 
                // one then we assign Previous same character 
                // count to current one 
                if(str[j] == str[j - 1]){
                    sameChar[j] = sameChar[j - 1];
                }

                // case 2: odd length
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