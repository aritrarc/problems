using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsSorting
{
    public class MinSwaps
    {

        // Consider an array of  distinct integers. George can swap any two elements of the array any number of times. 
        //An array is beautiful if the sum of |[arr[i] - arr[i-1]]| among 0 < i < n is minimal.
        //Given the array,determine and return the minimum number of swaps that should be performed in order to make the array beautiful.
        public static void GetMinimumSwaps(int[] arr)
        {
            int[] coparr = new int[arr.Length];
            arr.CopyTo(coparr, 0);
            int[] coparr2 = new int[arr.Length];
            arr.CopyTo(coparr2, 0);
            int swaps = 0;
            int swaps2 = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                map.Add(arr[i], i);
            }
            Dictionary<int, int> map2 = new Dictionary<int, int>(map);
            Array.Sort(coparr);

            for (int i = 0; i < coparr.Length; i++)
            {

                if (arr[i] == coparr[i])
                {
                    continue;
                }
                else
                {
                    int index = map[coparr[i]];
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    map[temp] = index;
                    swaps++;
                }
            }

            Array.Reverse(coparr);

            for (int j = 0; j < coparr.Length; j++)
            {

                if (coparr2[j] == coparr[j])
                {
                    continue;
                }
                else
                {
                    int index = map2[coparr[j]];
                    int temp = coparr2[j];
                    coparr2[j] = coparr2[index];
                    coparr2[index] = temp;
                    map2[temp] = index;
                    swaps2++;
                }
            }

           Console.WriteLine(swaps);
           Console.WriteLine(swaps2);

        }

    }
}