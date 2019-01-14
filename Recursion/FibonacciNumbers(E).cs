using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursion
{
    //Find the nth Fibonnaci Number
    public class FibonacciNumbers
    {
        public static void GetFibonacciNumbers(int x)
        {
            int result = Fibo(x);
           Console.WriteLine(result);
        }

        private static int Fibo(int x){

            if( x <= 0){
                return 0;
            }
            else if ( x == 1){
                return 1;
            }
            else{
                return Fibo(x - 2) + Fibo(x - 1);
            }
        }

    }
}