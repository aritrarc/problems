using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SingleLinkedListDT
{
    internal class Node
    {
        public int data;
        public Node link;

        public Node(int i)
        {
            data = i;
            link = null;
        }
    }

    public class SingleLinkedList
    {
        Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void addToFront(int[] x)
        {
            int i =0;
            while (i < x.Length)
            {
                Node temp = new Node(x[i]);
                if (start == null)
                {
                    start = temp;
                }
                else
                {
                    temp.link = start;
                    start = temp;
                }
                i++;
            }
        }

        public void addToEnd(int[] x)
        {
            int i =0;
            Node p;
            p = start;
            while (i < x.Length)
            {
                Node temp = new Node(x[i]);
                if (start == null)
                {
                    start = temp;
                }
                else
                {
                    while(p.link != null){
                        p = p.link;
                    }
                    p.link = temp;
                    temp.link = null;
                }
                i++;
            }
        }

        public void addAtIndex(int x, int index)
        {
            int i =0;
            Node p;
            p = start;
            for( i=1; p!=null && i != index - 1 ; i++ )
            {
                 p = p.link;
            }

            if( p == null)
            {
                Console.WriteLine("Index not present in LinkedList");
            }
            else
            {
                Node temp = new Node(x);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void display()
        {

            Node p;

            //If the LinkedList is empty.
            if (start == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }

            p = start;
            while (p != null)
            {
                Console.Write(" " + p.data);
                p = p.link;
            }
            Console.WriteLine();
        }

    }


}