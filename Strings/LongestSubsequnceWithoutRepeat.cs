using System;
using System.Collections;
using System.Linq;

namespace nsStrings
{
    public class LongestSubsequeenceWithoutRepeat
    {

        //Find the Longest subsequence without repeating characters in a string
        public int LengthOfLongestSubstring(string s)
        {

            int[] chArr = new int[128];
            int i = 0; int j = 0; int global_max = 0; int local_max = 0;
            while (i < s.Length && j < s.Length)
            {
                if (chArr[s[j]] == 0)
                {
                    chArr[s[j]]++;
                    j++;
                    local_max++;
                    global_max = Math.Max(global_max, local_max);
                }
                else
                {
                    chArr[s[i]]--;
                    i++;
                    local_max--;
                }
            }
            return global_max;
        }
    }
}