using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace nsMiscellaneous
{
    public class NumberOfPowers
    {

        // This code is used to reverse a string without using any other DS.
        public static void NumberOfPowersTillN(int num, int n)
        {
            int x = 0;
            while(true)
            {
                int power = (int)Math.Pow(num, x);
                if( power <= n){
                    Console.Write(power + " ");
                }else{
                    return;
                }
                x++;
            }            
        }

        public static int NumberOfPowersRecursive(int num, int n)
        {
            if(n == 1){
                Console.Write(n + " ");
                return n;
            }
            int curr_val = NumberOfPowersRecursive(num, n / num);
            int new_val = curr_val * num;
            Console.Write(new_val + " ");
            return new_val;
        }
    }

}
 