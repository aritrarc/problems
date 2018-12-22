using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CircularLinkedListDT
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

    public class CircularLinkedList{

        Node last;

        public CircularLinkedList(){
            last = null;
        }

        #region InsertOperations

        public void InsertFront(int[] x)
        {
            if(last == null){
                 Node temp = new Node(x[0]);
                 temp.link = temp;
                 last = temp;
            }
            Node p;
            p = last.link;

            for(int i = 1; i < x.Length; i++)
            {
                Node temp = new Node(x[i]);
                if(p == null){ //Empty List
                    temp.link = temp;
                    last = temp;
                }else{
                    temp.link = last.link;
                    last.link = temp;
                }
            }
            
        }

        public void InsertAtEnd(int[] x)
        {
            if(last == null)
            {
                Node temp = new Node(x[0]);
                temp.link = temp;
                last = temp;
            }

            Node p;
            p = last.link;

            for(int i = 0; i < x.Length; i++)
            {
                Node temp = new Node(x[i]);
                if(p == null){ //Empty List
                    temp.link = temp;
                    last = temp;
                }else{
                    temp.link = last.link;
                    last.link = temp;
                    last = temp;
                }
            }

        }

        public void InsetAfterNode(int n, int x)
        {
            Node temp = new Node(x);

            if(last == null)
            {
                Console.WriteLine("Node not found");
                return;
            }

            Node p;
            p = last.link;

            do{
                if(p.data == n){
                    break;
                }
                p = p.link;
            }while(p != last.link);

            if(p.data == n)
            {
                temp.link = p.link;
                if(last.link == temp.link){
                    last = temp;
                }
                p.link = temp;

            }else{
                Console.WriteLine("Element not found");
            }
        }

        #endregion

        public void display()
        {
            if(last == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node p;
            p = last.link;
            do{
                Console.Write(" " + p.data);
                p = p.link;
            }while(p != last.link);
            Console.WriteLine();
        }
    }

}