using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DoubleLinkedListDT
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node prev;

        public Node(int i)
        {
            data = i;
            prev = null;
            next = null;
        }
    }

    public class DoubleLinkedList{

        Node start;

        public DoubleLinkedList(){
            start = null;
        }

        public void InsertAtFront(int[] x){
            Node p;
            p = start;
   
            for(int i=0; i < x.Length; i++){
                Node temp = new Node(x[i]);
                if(start == null){
                //LL is empty
                    start = temp;
                }
                else {
                    start.prev = temp;
                    temp.next = start;
                    temp.prev = null;
                    start = temp;
                }
            }
            
        }

        public void InsertAtEnd(int x)
        {
            Node p;
            p = start;
            Node temp = new Node(x);

            if(p == null){
                start = temp;
            }
            else{
                while(p.next != null){
                    p = p.next;
                }

                p.next = temp;
                temp.prev = p;
                temp.next = null;
            }
        }

        public void InsertAfterNode(int val, int x){
            Node p;
            p = start;

            while(p.next != null)
            {
                if(p.data == val){
                    break;
                }
                p = p.next;
            }

            if(p.data != val){
                Console.WriteLine("Element {0} is not present in the LinkedList",val);
            }
            else {
                Node temp = new Node(x);
                p.next.prev = temp;
                temp.next = p.next;
                temp.prev = p;
                p.next = temp;

            }
        }

        public void InsertBeforeNode(int val, int x)
        {
            Node p;
            p = start;

           while(p.next != null)
            {
                if(p.data == val){
                    break;
                }
                p = p.next;
            }

            if(p.data != val){
                Console.WriteLine("Element {0} is not present in the LinkedList",val);
            }
            else {
                Node temp = new Node(x);
                temp.next = p;
                p.prev.next = temp;
                temp.prev = p.prev;
                p.prev = temp;
            }
        }

        public void DisplayDoubleLinkedList(){
            Node p;
            p = start;
            
            if(start == null){
                Console.WriteLine("There are no elements in the LinkedList");
            }
            else {
                while(p != null){
                    Console.Write(p.data + " ");
                    p = p.next;
                }
                Console.WriteLine();
            }
        }
    }
}