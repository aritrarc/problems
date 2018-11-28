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
            void Display();
        }

        class StackImplementation : StackInterface
        {
            int top = -1;
            int stackSize;

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
                     return poppedItem;
                 }
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
            StackImplementation stck = new StackImplementation(5);

            Console.WriteLine(stck.isEmpty());
            for(int i=0; i<6; i++)
            {
                stck.Push(i);
            }

            stck.Display();

            Console.WriteLine(stck.isEmpty());

            Console.WriteLine(stck.Peek());

            Console.WriteLine(stck.Pop());

             Console.WriteLine(stck.Pop());

             stck.Display();

        }
    }
}