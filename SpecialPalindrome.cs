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
             int result = palindromeRecurse(str, count, start, x) + x;
             Console.WriteLine(result.ToString());
        }

        private static int palindromeRecurse(string str, int count, int start, int lenth)
        {
            int n = str.Length;
            for(int i=start; i < str.Length - 1; i++ )
            {
                if( str[i] == str[i+1])
                {
                    count++;
                    int j = i+1;
                    count = palindromeRecurse(str.Substring(j), count, 0, str.Substring(j).Length + 1);
                }
                else if ( i != n-2)
                {
                    if(str[i] == str[i+2])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
       
    }
} 