using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public static class FindTripletsSum
    {
        //Given an array of n integers find triplets where sum of first two elements equal to the third element
        public static void GetTripletsInArray(int[] arr)
        {
            int n = arr.Length;
            Array.Sort(arr);
            int x = 0;
            int y = 0;
            Boolean exists = false;

            for (int i = n - 1; i > 0; i--)
            {
                x = 0;
                y = i - 1;

                while (x < y)
                {

                    if (arr[x] + arr[y] == arr[i])
                    {

                        Console.WriteLine("(" + arr[x] + ',' + arr[y] + ',' + arr[i] + ")");
                        exists = true;
                        break;
                    }
                    else if (arr[x] + arr[y] > arr[i])
                    {
                        y--;
                    }
                    else
                    {
                        x++;
                    }

                }
            }

            if (!exists)
            {
                Console.WriteLine("No triplet exists");
            }

        }

        public static void GetTripletsInArrayEqualToSum(int[] arr, int sum)
        {
            int n = arr.Length;
            Array.Sort(arr);
            int x = 0;
            int y = 0;

            for (int i = n - 1; i > 0; i--)
            {
                x = 0;
                y = i - 1;

                while (x < y)
                {

                    if (arr[x] + arr[y] + arr[i] == sum)
                    {

                        Console.WriteLine("(" + arr[x] + ',' + arr[y] + ',' + arr[i] + ")");
                        return;
                    }
                    else if (arr[x] + arr[y] > arr[i])
                    {
                        y--;
                    }
                    else
                    {
                        x++;
                    }

                }
            }


            Console.WriteLine("No triplet exists");


        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> result = new List<IList<int>>();
            int n = nums.Length;
            Array.Sort(nums);
            int lastVisited = Int32.MaxValue;

            for (int i = 0; i < n - 2; i++)
            {
                if (nums[i] == lastVisited)
                {
                    continue;
                }
                int j = i + 1;
                int k = n - 1;
                int lastVisitedJ = Int32.MaxValue;
                while (j < k)
                {
                    if (nums[j] == lastVisitedJ)
                    {
                        j++;
                        continue;
                    }
                    if (nums[i] + nums[j] + nums[k] > 0)
                    {
                        k--;
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        IList<int> tempList = new List<int>();
                        tempList.Add(nums[i]);
                        tempList.Add(nums[j]);
                        tempList.Add(nums[k]);
                        result.Add(tempList);
                        lastVisitedJ = nums[j];
                        j++;
                        k--;
                    }
                }
                lastVisited = nums[i];
            }
            return result;
        }
    }

}
