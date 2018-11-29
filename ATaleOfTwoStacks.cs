using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATaleOfTwoStacks
{
    public class ATaleOfTwoStacks
    {
        //In this challenge, you must first implement a queue using two stacks. Then process  queries, where each query is one of the following  types:
        //1 x: Enqueue element  into the end of the queue.
        //2: Dequeue the element at the front of the queue.
        //3: Print the element at the front of the queue.
        //For each query of type 3, return the value of the element at the front of the fifo queue on a new line.
        public static void DriverMethod()
        {
           MyQueue<int> queue = new MyQueue<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ops = Console.ReadLine();
                int operation = Convert.ToInt32(ops.Substring(0,1));

                if (operation == 1)
                { 
                    // enqueue
                   queue.enqueue(Convert.ToInt32(ops.Substring(2)));
                }
                else if (operation == 2)
                { // dequeue
                    queue.dequeue();
                }
                else if (operation == 3)
                { // print/peek
                   Console.WriteLine(queue.peek());
                }
            }
        }

        public class MyQueue<T>
        {
            Stack<T> LIFO = new Stack<T>();
            Stack<T> FIFO = new Stack<T>();

            List<T> copyList = new List<T>();

            public void enqueue(T value)
            { // Push onto newest stack
                LIFO.Push(value);
            }

            public T peek()
            {
                if (FIFO.Count > 0)
                {
                    return FIFO.Peek();
                }
                else{
                    while(LIFO.Count > 0){
                        FIFO.Push(LIFO.Pop());
                    }
                    return FIFO.Peek();
                }
            }

            public T dequeue()
            {
                if (FIFO.Count > 0)
                {
                    return FIFO.Pop();
                }
                else {
                    while(LIFO.Count > 0){
                        FIFO.Push(LIFO.Pop());
                    }
                }
                 return FIFO.Pop();
            }
        }
    }
}