using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LargestRectangle
{
    public class LargestRectangle
    {

        public static void LongestRectangle(int[] arr)
        {
                int max_area = 0;
                Stack<int> stk = new Stack<int>();
                int top = -1;
                int area = 0;

                for(int i=0; i<arr.Length; i++)
                {
                    if (stk.Count == 0 || arr[stk.Peek()] <= arr[i])
                    {
                        stk.Push(i);
                        i++;
                    }
                    else{

                        top = stk.Peek();
                        stk.Pop();

                        area = arr[top] * (stk.Count == 0 ? i : i - stk.Peek() - 1);
                        if( area > max_area ){
                            max_area = area;
                        }
                    }
                }

        }
    }
}