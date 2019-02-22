using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        // Generic Stack implementation, with push ,pop, peek, isEmpty and Display methods
        private interface StackInterface
        {
            Boolean isEmpty();
            void Push(Object obj);
            Object Pop();
            Object Peek();
            Object Min();
            void Display();
        }

        class StackImplementation : StackInterface
        {
            int top = -1;
            int stackSize;
            Object minElement = Int32.MaxValue;

            Object[] item;
            public int Stacksize {
                get{return stackSize;}
                set{stackSize = value;}
            }

            public StackImplementation(){
                Stacksize = 10;
                item = new Object[Stacksize];
                top = -1;
            }

            public StackImplementation(int capacity){
                Stacksize = capacity;
                item = new Object[Stacksize];
                top = -1;
            }

            public Boolean isEmpty()
            {
                if(top == -1){
                    return true;
                }
                return false;
            }
            public void Push(Object obj)
            {
                if(top == Stacksize - 1) {
                    Console.WriteLine("Stack is full");
                }
                else{
                    if((int)obj < (int)minElement){
                        minElement = obj;
                    }
                    top++;
                    item[top] = obj;
                }
            }

             public Object Pop(){

                 if(isEmpty())
                 {
                     Console.WriteLine("Stack is empty");
                     return "Empty";
                 }else {
                     Object poppedItem = item[top];                    
                     item[top] = "";
                     top = top - 1;
                     if((int)poppedItem <= (int)minElement){
                        minElement = GetNewMinRecursively(Int32.MaxValue);
                    }
                     return poppedItem;
                 }
            }

            public Object Min(){

                if(isEmpty()){
                    Console.WriteLine("Empty stack has no minimum");
                    return "Empty";
                }else {
                    return minElement;
                }
            }

            Object GetNewMinRecursively(Object curr_min)
            {
                if(isEmpty()){
                    return curr_min;
                }
                Object curr_obj = item[top];
                item[top] = "";
                top = top - 1;
                curr_min = GetNewMinRecursively(Math.Min((int)curr_min,(int)curr_obj));
                Push(curr_obj);
                return curr_min;
            }

            public Object Peek(){
                if(isEmpty())
                 {
                     Console.WriteLine("Stack is empty");
                     return "Empty";
                 }else {
                     return item[top];
                 }
            }

            public void Display(){
                for(int i=0; i<Stacksize; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }


        }

        public static void ImplementStack()
        {
            //Create a stack of size 5
            Console.WriteLine("");
            Console.WriteLine("Stack Operations:");
            Console.WriteLine("===============");
            Console.WriteLine("");

            StackImplementation stck = new StackImplementation(6);

            Console.WriteLine(stck.isEmpty());

            Console.WriteLine(stck.Min());

            // for(int i=0; i<6; i++)
            // {
            //     stck.Push(i);
            // }
            stck.Push(2);
            stck.Push(3);
            stck.Push(1);
            stck.Push(4);
            stck.Push(0);
            stck.Push(5);

            Console.WriteLine("");
            Console.WriteLine("Displaying Items in the stack:");
            Console.WriteLine("------------------------------");
            stck.Display();
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Minimum Item:" +stck.Min());

            Console.WriteLine(stck.isEmpty());

            Console.WriteLine("Peeked item:" + stck.Peek());

            Console.WriteLine("Popped Item : " + stck.Pop());

            Console.WriteLine("Popped Item :" + stck.Pop());

            Console.WriteLine("Popped Item :" + stck.Pop());

            Console.WriteLine("Minimum item:" + stck.Min());

            Console.WriteLine("");
            Console.WriteLine("Displaying Items in the stack:");
            Console.WriteLine("------------------------------");
            stck.Display();
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Popped Item :" + stck.Pop());

            stck.Push(5);

            Console.WriteLine("Minimum item:" + stck.Min());

            Console.WriteLine("");
            Console.WriteLine("Displaying Items in the stack:");
            Console.WriteLine("------------------------------");
            stck.Display();
            Console.WriteLine("------------------------------");
            Console.WriteLine("");


        }
    }
}