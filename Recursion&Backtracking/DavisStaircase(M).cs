using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //Davis has a number of staircases in his house and he likes to climb each staircase 1, 2, or 3 steps at a time. 
    //Being a very precocious child, he wonders how many ways there are to reach the top of the staircase.
    public class DavisStaircase
    {
        public static Dictionary<int, int> memo = new Dictionary<int, int>();
        public static void GetstepPerms(int x)
        {
            memo[0] = 1;
            int result = stepPerms(x);
           Console.WriteLine(result);
        }

        private static int stepPerms(int x){

            if(memo.ContainsKey(x)){
                return memo[x];
;            }
            
            if( x < 0){
                return 0;
            }
            else if ( x == 0){
                return 1;
            }
            else{
                int result = stepPerms(x - 3) + stepPerms(x - 2) + stepPerms(x - 1);
                memo[x] = result;
                return result;
            }
        }

    }
}