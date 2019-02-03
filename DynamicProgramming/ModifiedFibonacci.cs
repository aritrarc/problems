using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDynamic
{
    public class ModifiedFibonacci
    {
        //Given three integers, t1 , t2 , and n, compute and print the nth term of a modified Fibonacci sequence where  t(1+2) = t(i) + t(i + 1)square
        public static void getModifiedFibonacci(int n1, int n2, int n)
        {
            BigInteger curr_num = n2;
            BigInteger last_num = n1;

            int x = 2;
            while (x < n)
            {
                BigInteger temp = 0;
                temp = curr_num;
                curr_num = last_num + curr_num*curr_num;
                last_num = temp;
                x++;
            }

            Console.WriteLine(curr_num.ToString());
        }

    }
}