using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSockMerchant
{
    public class CountingValleys
    {
        //Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
        public static void GetNumberOfValleys(int n, string s)
        {
            int count = 0;
            Stack<char> stk = new Stack<char>();
            char[] chArray = s.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (stk.Count > 0)
                {
                    if (chArray[i] != stk.Peek())
                    {
                        stk.Pop();
                    }
                    else
                    {
                        stk.Push(chArray[i]);
                    }
                }
                else
                {
                    stk.Push(chArray[i]);
                    if(chArray[i] == 'D'){
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

    }
}