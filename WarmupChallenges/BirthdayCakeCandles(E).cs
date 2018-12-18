using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsWarmupChallenges
{
    public class BirthdayCakeCandles
    {

        //Get count of maximum elements in an array. 
        public static void NumberOfCandles(int[] ar)
        {
            int count = 1;
            int max_element = ar[0];

            for(int i = 1; i<ar.Length; i++)
            {
                if(ar[i] == max_element)
                {
                    count++;
                }
                else if (max_element < ar[i])
                {
                    max_element = ar[i];
                    count = 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}