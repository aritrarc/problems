using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class Candies
    {
        private static int count = 0;
        //Given an array of integers, find the subset of non-adjacent elements with the maximum sum. Calculate the sum of that subset.
        public static void getCandiyCounts(int[] arr)
        {

            int[] temp = new int[arr.Length];
            int low_index = arr.Length - 1;
            int mark_index = low_index;
            Boolean flag = false;

            while (low_index > 0)
            {
                if (arr[low_index] <= arr[low_index - 1])
                {

                    temp[low_index] = low_index == arr.Length - 1 ? 1 : temp[low_index + 1] + 1;
                    if (low_index != arr.Length - 1)
                    {
                        int x = low_index + 1;
                        while (x <= mark_index)
                        {
                            temp[x] = temp[x - 1] + 1;
                            if (x <= arr.Length - 2 && x == mark_index)
                            {
                                if (arr[x] > arr[x + 1] && temp[x] < temp[x + 1])
                                {
                                    temp[x] = temp[x + 1] + 1;
                                }
                            }
                            x++;
                        }
                    }

                    flag = false;
                    low_index--;
                    mark_index--;
                }
                else
                {
                    if (!flag)
                    {
                        mark_index = low_index;
                        flag = true;
                    }
                    low_index--;
                }
            }


            //Remaing spaces
            int y = 0; int j = 1;
            while (temp[y] == 0)
            {
                temp[y] = j;
                j++;
                y++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
                count += temp[i];
            }
            Console.WriteLine(count);
        }

    }
}