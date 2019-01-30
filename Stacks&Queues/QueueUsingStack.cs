using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class QueueUsingStacks
    {

        private static Stack<int> stk = new Stack<int>();   

        public static void usingSingleStack(int[] arr)
        {

           //Enqueue
           for(int i = 0; i< arr.Length; i++){
               stk.Push(arr[i]);
           }

           //Print Queue using Stack
           PrintQueue();
           Console.WriteLine("");

            //Dequeue
           int first = Pop();
           Console.WriteLine(first);
           int second = Pop();
           Console.WriteLine(second);

           PrintQueue();
           Console.WriteLine("");
        }

        private static int Pop()
        {

            int value = stk.Pop();
            int val2 = 0;
            if(stk.Count > 0)
            {
               val2 =  Pop();
               stk.Push(value);
            }else{
                val2 = value;
            }

            return val2;
        }

        private static void PrintQueue()
        {
            int val = stk.Pop();
           
            if(stk.Count > 0){
                PrintQueue();
                 Console.Write("," + val);
                stk.Push(val);
            }else{
            Console.Write(val);
            stk.Push(val);}
            return;
        }

    }
}