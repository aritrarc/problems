using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStrings
{
    public class SeparateTheNumber{

        // A numeric string, s, is beautiful if it can be split into a sequence of two or more positive integers,a[1],a[2] etc.. satisfying the following conditions:
        // a[i] - a[i - 1] = 1 and a[i] does not contain leading zeroes. Print YES or NO whether a number is beautiful and if yes print x , the smallest first number of the sequence
        public static void separateNumbers(string s)
        {
            Boolean isBeautiful = false;

            int x = 1;
            int mid = s.Length / 2;
            int index = 1;           
            long first_Match = -1;
            long curr_val = Int64.Parse(s[0].ToString());
            int length = curr_val == 9 ? 2 : 1;

            while(x <= mid && index + length <= s.Length)
            {
                long next_val = curr_val + 1;
                if(next_val == Convert.ToInt64(s.Substring(index, length)) && Int64.Parse(s[0].ToString()) != 0)
                {
                    if(first_Match == -1){
                        first_Match = curr_val;}
                        curr_val = next_val;
                        index = index + length;
                        if( index == s.Length){
                            isBeautiful = true;
                            break;
                        }
                        length = (next_val + 1).ToString().Length > length ? length + 1: length;
                }else{
                    first_Match = -1;
                    x++;
                    index = 0;
                    length = x;
                    curr_val = Convert.ToInt64(s.Substring(index, length));
                    length = (curr_val + 1).ToString().Length > length ? length + 1: length;
                    index = x;
                }
            }


            Console.WriteLine(isBeautiful ? "YES" + " " + first_Match : "NO");
        }
       
    }
} 