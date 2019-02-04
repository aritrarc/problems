using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class ReverseStack
    {
        
        private static void reverseStack(Stack<int> stk1)
        {
           if(stk1.Count == 0){
               return;
           }
           int val = stk1.Pop();
           reverseStack(stk1);
           PushToBottom(stk1, val);
        }

        private static void PushToBottom(Stack<int> stk1, int val)
        {
            if(stk1.Count == 0){
                stk1.Push(val);
                return;
            }

            int val2 = stk1.Pop();
            PushToBottom(stk1, val);
            stk1.Push(val2);
        }

        private static void PrintStack(Stack<int> stk1)
        {
            if(stk1.Count == 0){
                return;
            }

            int val1 = stk1.Pop();
            Console.Write(val1 + " ");
            PrintStack(stk1);
            stk1.Push(val1);
        }

        public static void DriverMethod(){
            Stack<int> stk1 = new Stack<int>();
            stk1.Push(10);
            stk1.Push(20);
            stk1.Push(30);
            stk1.Push(40);
            stk1.Push(50);

            Console.WriteLine("ORIGINAL STACK");
            PrintStack(stk1);
            Console.WriteLine("");
            Console.WriteLine("REVERSED STACK");
            reverseStack(stk1);
            PrintStack(stk1);

        }

    }
}