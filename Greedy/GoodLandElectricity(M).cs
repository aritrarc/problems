using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsGreedy
{
    //You are given a list of city data. Cities that may contain a power plant have been labeled 1.
    // Others not suitable for building a plant are labeled 0. Given a distribution range of k, find the lowest number of plants that must be built such that all cities are served.
    // The distribution range limits supply to cities where distance is less than k.
    public class GoodLandElectricity
    {
        public static void pylons(int k, int[] arr)
        {
            int count = 0;
            int i = 0;

            while (i <= arr.Length - 1)
            {
                int index = i + k - 1;
                Boolean found = false;
                while (index >= i)
                {
                    if (index <= arr.Length - 1)
                    {
                        if (arr[index] == 1)
                        {

                            count++;
                            found = true;
                            i = index + k;
                            break;
                        }
                    }
                    index--;
                }
                //Not found to the right. So check left
                if (!found)
                {
                    index = i - 1;
                    while (index >= i - k + 1 && index >= 0)
                    {
                        if (arr[index] == 1)
                        {

                            count++;
                            found = true;
                            i = index + k;
                            break;
                        }
                        index--;
                    }
                }

                if (!found)
                {
                    count = -1;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}


