using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSockMerchant
{
    public class JumpingOnTheClouds
    {
        //Emma is playing a new mobile game that starts with consecutively numbered clouds. 
        //Some of the clouds are thunderheads and others are cumulus. She can jump on any cumulus cloud having a number
        //that is equal to the number of the current cloud plus  or . She must avoid the thunderheads.
        //Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. 
        //It is always possible to win the game.
        public static void MinimumJumps(int[] c)
        {
            int count = 0;
            int x = 0;
            while( x < c.Length - 2){
                if(c[x + 2] == 0){
                    x= x+2;
                }
                else {
                    x = x+1;
                }
                count++;
            }
            if(x == c.Length - 2){
                count++;
            }
            Console.WriteLine(count);
        }

    }
}