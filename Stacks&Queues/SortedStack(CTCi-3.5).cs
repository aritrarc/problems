using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class SortedStack
    {
        public static void GetSortedStack(int[] arr)
        {
            Stack<int> stk1 = new Stack<int>();
            Stack<int> stk2 = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stk2.Count == 0)
                {
                    stk2.Push(arr[i]);
                }
                else if (arr[i] >= stk2.Peek())
                {
                    stk2.Push(arr[i]);
                }
                else
                {
                    while (stk2.Count > 0 && arr[i] < stk2.Peek())
                    {
                        stk1.Push(stk2.Pop());
                    }
                    stk2.Push(arr[i]);
                    while (stk1.Count > 0)
                    {
                        stk2.Push(stk1.Pop());
                    }
                }

            }

            while (stk2.Count > 0)
            {
                stk1.Push(stk2.Pop());
            }

            PrintStack(stk1);
        }

        private static void PrintStack(Stack<int> stk1)
        {
            if (stk1.Count == 0)
            {
                return;
            }

            int val1 = stk1.Pop();
            Console.Write(val1 + "->");
            PrintStack(stk1);
            stk1.Push(val1);
        }

    }
}