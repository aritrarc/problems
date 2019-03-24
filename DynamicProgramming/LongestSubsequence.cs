using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class LongestSubsequences
    {
        private static Dictionary<string, int> memonize = new Dictionary<string, int>();

        public static void LongestPalindromicSubsquence(string s)
        {
            int result = RecursePalindromicSubsequence(s, 0, s.Length - 1);
            Console.WriteLine(result);
        }

        public static int RecursePalindromicSubsequence(string s, int leftIndex, int rightIndex)
        {
            string key = leftIndex + "," + rightIndex;
            if (memonize.ContainsKey(key))
            {
                return memonize[key];
            }

            if (leftIndex == rightIndex)
            {
                return 1;
            }

            if (s[leftIndex] == s[rightIndex] && rightIndex == leftIndex + 1)
            {
                return 2;
            }

            if (s[leftIndex] == s[rightIndex])
            {
                int val = RecursePalindromicSubsequence(s, leftIndex + 1, rightIndex - 1) + 2;
                memonize[key] = val;
                return val;
            }

            int value = Math.Max(RecursePalindromicSubsequence(s, leftIndex + 1, rightIndex), RecursePalindromicSubsequence(s, leftIndex, rightIndex - 1));
            memonize[key] = value;
            return value;
        }

        public static void LongestCommonSubsquence(string s1, string s2)
        {
            int result = RecurseCommonSubsequence(s1, s2, s1.Length, s2.Length);
            Console.WriteLine(result);
        }

        public static int RecurseCommonSubsequence(string s1, string s2, int s1Index, int s2Index)
        {
            if (s1Index == 0 || s2Index == 0)
            {
                return 0;
            }

            if (s1[s1Index - 1] == s2[s2Index - 1])
            {
                return 1 + RecurseCommonSubsequence(s1, s2, s1Index - 1, s2Index - 1);
            }

            return Math.Max(RecurseCommonSubsequence(s1, s2, s1Index, s2Index - 1), RecurseCommonSubsequence(s1, s2, s1Index - 1, s2Index));
        }

        public static string LongestPalindromicSubString(string s)
        {
            if (s == null || s.Length < 2)
            {
                return s;
            }

            int len = s.Length;
            int left = 0; int right = 0;

            Boolean[,] isPalindrome = new Boolean[len,len];

            for (int j = 1; j < len; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Boolean isPal = isPalindrome[i+1,j-1] || j - i <= 2;
                    if(s[i] == s[j] && isPal){
                        isPalindrome[i,j] = true;

                        if (j - i > right - left){
                            right = j;
                            left = i;
                        }
                    }
                }
            }
            return s.Substring(left, right -left +1);
        }

    }
}