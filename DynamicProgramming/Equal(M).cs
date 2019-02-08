using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDynamic
{
    public class Equal
    {
       //Christy must equalize the number of chocolates in a series of operations. For each operation, she can give 1, 2, 5 chocolates 
       //to all but one colleague. Everyone who gets chocolate in a round receives the same number of pieces.
       //Given a starting distribution, calculate the minimum number of operations needed so that every colleague has the same number of chocolates.
        public static void equal(int[] arr)
        {
            int result = Int32.MaxValue;
            int target = arr.Min();

            for(int i=0; i<5; i++)
            {
                int operations = 0;
                for(int j = 0; j< arr.Length; j++)
                {
                    int t = arr[j] - (target - i);
                    operations += t / 5  + t % 5 / 2 + t % 5 % 2;
                }
                result = Math.Min(result , operations);
            }


            Console.WriteLine(result);
        }

        //HINTS
        //1. Adding to all but one is same as taking away from that person.
        //2. Tareget shoul be minimum value or between minimum to minimum-4.
        //3. Reduce by 5 first, then by 2 and last by 1 for each element and add the total number of operations for every element
        // 4. FInd total for all targets i.e target to targe - 4 and take minimum of that.       
      
    }
}