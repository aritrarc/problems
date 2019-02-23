using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class StackOfPlates
    {
        interface SetOfStacksInterface
        {
            void Push(int data);

            int Pop();
        }

        class SetOfStacks : SetOfStacksInterface
        {
            List<Stack<int>> stackset;

            int capacity;
            int stackCount = 0;
            public SetOfStacks(int threshold)
            {
                stackset = new List<Stack<int>>();
                Stack<int> stk = new Stack<int>();
                stackset.Add(stk);
                stackCount = 1;
                capacity = threshold;
            }

            public void Push(int element)
            {
                int curr_stack_index = stackCount - 1;
                Stack<int> curr_stack = stackset[curr_stack_index];
                curr_stack.Push(element);
                if(curr_stack.Count == capacity){
                    stackset.Add(new Stack<int>());
                    stackCount++;
                }
            }

            public int Pop()
            {
                int curr_stack_index = stackCount - 1;
                Stack<int> curr_stack = stackset[curr_stack_index];
                if(curr_stack.Count == 0){
                    Console.WriteLine("No more elements to pop");
                    return -1;
                }
                int poppedElement = curr_stack.Pop();
                if(curr_stack.Count == 0 && curr_stack_index  > 0){
                    stackset.RemoveAt(curr_stack_index);
                    stackCount--;
                }
                return poppedElement;
            }

            public int StackCount(){
                return stackCount;
            }
        }

        public static void PerformStackSetOperations()
        {
            SetOfStacks plates = new SetOfStacks(3);
            plates.Push(1);
            plates.Push(2);
            Console.WriteLine("Stack Count:" + plates.StackCount());
            plates.Push(3);
            Console.WriteLine("Stack Count:" + plates.StackCount());
            plates.Push(4);
            plates.Push(5);
            plates.Push(6);
            Console.WriteLine("Stack Count:" + plates.StackCount());
            plates.Push(7);
            Console.WriteLine("Stack Count:" + plates.StackCount());
            plates.Push(8);
            Console.WriteLine("Stack Count:" + plates.StackCount());
            Console.WriteLine("Popped element:" + plates.Pop());
            Console.WriteLine("Popped element:" + plates.Pop());
            Console.WriteLine("Stack Count:" + plates.StackCount());
            Console.WriteLine("Popped element:" + plates.Pop());
            Console.WriteLine("Stack Count:" + plates.StackCount());
        }
    }
}