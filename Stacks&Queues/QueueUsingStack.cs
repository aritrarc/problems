using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class QueueUsingStacks
    {

        private static Stack<int> stk = new Stack<int>(); 
        private static Stack<int> stk1 = new Stack<int>();   
        private static Stack<int> stk2 = new Stack<int>();   

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

        public static void usingTwoStacks(int[] arr)
        {
             //Enqueue
           for(int i = 0; i< arr.Length; i++){
               stk1.Push(arr[i]);
           }

           //Print Queue using Stack
           if(stk2.Count > 0){
              PrintQueueTwoStacksForStack2();
           }
           PrintQueueTwoStacksForStack1();
           Console.WriteLine("");

             //Dequeue
           int first = PopTwoStacks();
           Console.WriteLine(first);
           int second = PopTwoStacks();
           Console.WriteLine(second);

            //Enqueue
            stk1.Push(99);
            stk1.Push(100);

           if(stk2.Count > 0){
              PrintQueueTwoStacksForStack2();
           }
           PrintQueueTwoStacksForStack1();
            Console.WriteLine("");

             int third = PopTwoStacks();
           Console.WriteLine(third);

           if(stk2.Count > 0){
              PrintQueueTwoStacksForStack2();
           }
           PrintQueueTwoStacksForStack1();
            Console.WriteLine("");
        }

        private static int PopTwoStacks()
        {
            int val2 = 0;
            if(stk2.Count > 0){
                val2 = stk2.Pop();
            }else
            {
                while(stk1.Count > 0){
                    stk2.Push(stk1.Pop());
                }
                val2 = stk2.Pop();
            }
            return val2;
        }

         private static void PrintQueueTwoStacksForStack2()
        {
            int val = stk2.Pop();
            if(stk2.Count > 0){
                 Console.Write(val + ",");
                PrintQueueTwoStacksForStack2();
                stk2.Push(val);
            }else{
            Console.Write(val + ",");
            stk2.Push(val);}
          
        }

        private static void PrintQueueTwoStacksForStack1()
        {
            
            int val = stk1.Pop();
            if(stk1.Count > 0){
                PrintQueueTwoStacksForStack1();
                Console.Write(val + ",");
                stk1.Push(val);
            }else{
            Console.Write(val + ",");
            stk1.Push(val);}
          
        }

    }
}