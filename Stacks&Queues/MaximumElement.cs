using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class MaximumElement
    {
        //You have an empty sequence, and you will be given N queries. Each query is one of these three types:
        //1 x  -Push the element x into the stack.
        //2    -Delete the element present at the top of the stack.
        //3    -Print the maximum element in the stack.
        public static void GetMaxElement()
        {
            Stack<int> stk = new Stack<int>();
            List<int> maxList = new List<int>();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ops = Console.ReadLine();
                int operation = Convert.ToInt32(ops.Substring(0,1));

                if (operation == 1)
                { 
                    int item = Convert.ToInt32(ops.Substring(2));
                    stk.Push(item);
                    int index = maxList.BinarySearch(item);
                    if(index < 0){
                        maxList.Insert(~index, item);
                    }
                    else{
                        maxList.Insert(index, item); 
                    }

                }
                else if (operation == 2)
                {
                    if(stk.Count > 0){
                        int item = stk.Pop();
                        int index = maxList.BinarySearch(item);
                        maxList.Remove(item);
                    }
                      
                }
                else if (operation == 3)
                { 
                   Console.WriteLine(maxList[maxList.Count - 1]);
                }
            }
        }

    }
}