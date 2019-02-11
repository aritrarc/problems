using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSearching
{
    public class HackerLandRadioTransmitters
    {

        //Given a map of Hackerland and the transmission range, determine the minimum number of transmitters so that every house 
        //is within range of at least one transmitter. Each transmitter must be installed on top of an existing house.
        public static void hackerlandRadioTransmitters(int[] x, int k)
        {
            Array.Sort(x);
            int count = 0;
            int index = 0;
            int position = 0;

            while(index <= x.Length - 1)
            {
                if (position >= x[index])
                {
                    index++;
                }
                else
                {
                    int range = x[index] + k;
                    while(index <= x.Length - 1 && range >= x[index])
                    {
                        index++;
                    }
                    count++;
                    index = index - 1;
                    position = x[index] + k;
                }
            }

            Console.WriteLine(count);
        }
    }
}