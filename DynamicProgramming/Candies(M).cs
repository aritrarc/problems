using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class Candies
    {
       
        //Alice wants to give at least 1 candy to each child. If two children sit next to each other, then the one with the higher rating must get more candies. 
        //Alice wants to minimize the total number of candies she must buy. Find the minimum number of candies Alice has to buy.
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
                //count += temp[i];
            }
            //Console.WriteLine(count);
        }

        public static void getMinCandies(int[] arr)
        {
            int[] tempArray = new int[arr.Length];
            long count = 0;


            //First fill all elements with 1
            for(int i=0; i<tempArray.Length; i++)
            {
                tempArray[i] = 1;
            }

            
            //Check every element and if it is greater than previous element increament by 1.
            for(int i=1 ; i<arr.Length; i++)
            {
                if(arr[i] > arr[i-1])
                {
                    tempArray[i] = tempArray[i - 1] + 1;
                }
            }
            

            //Check the above logic in reverse order. If the current value in temparray is greater for elemenets that is greater in array do nothing. else increment by 1.
            for(int i=arr.Length-2 ; i>=0; i--)
            {
                if(arr[i] > arr[i+1])
                {
                    if(tempArray[i] <= tempArray[i+1]){
                        tempArray[i] = tempArray[i+1] + 1;
                    }
                }
            }

            for(int i = 0; i< tempArray.Length; i++)
            {
                count = count + tempArray[i];
            }

            Console.WriteLine(count);
        }

    }
}