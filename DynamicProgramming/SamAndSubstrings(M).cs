using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDynamic
{
    public class SamAndSubstrings
    {
        //Given an integer as a string, sum all of its substrings cast as integers. As the number may become large, return the value modulo 10^9 + 7.
        public static void GetSubstringSum(string s)
        {
            long Mod_val = Convert.ToInt64(Math.Pow(10,9)) + 7;
            long sum = Convert.ToInt64(s.Substring(0,1));
            long curr_value = sum;

            for(int i=1; i<s.Length; i++)
            {
                curr_value = (10 * curr_value + (i + 1)*Convert.ToInt32(s.Substring(i,1)))% Mod_val;
                sum += curr_value;
            }
            sum = sum % Mod_val;
            int answer = (int)sum;
            Console.WriteLine(answer.ToString());
        }

    }
}