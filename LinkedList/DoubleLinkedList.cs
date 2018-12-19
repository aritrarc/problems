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

        #region Insertion
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

        public void InsertNodeInSortedList(int data)
        {
            Node p;
            p = start;
            
            if( p == null)
            {
                Node temp = new Node(data);
                start = temp;
                return;
            }
            else if( data < p.data)
            {
                Node temp = new Node(data);
                temp.next = start;
                start = temp;
                return;
            }

            while(p != null)
            {
                if(data <= p.data){
                    Node temp = new Node(data);
                    p.prev.next = temp;
                    temp.prev = p.prev;
                    temp.next = p;
                    p.prev = temp;
                    return;
                }
                if(p.next == null){
                    break;
                }
                p = p.next;
            }

            if(p.next == null)
            {
                Node temp = new Node(data);
                p.next = temp;
                temp.prev = p;
            }
        }
        #endregion
       
        #region Delete
       public void DeleteFromFront()
       {
           Node p;
           p = start;
            if(start == null){
                Console.WriteLine("LinkedList is empty");
            }else {
                p.next.prev = null;
                start = p.next;
            }
       }

       public void DeleteFromEnd()
       {
           Node p;
           p = start;

           if(p == null){
               Console.WriteLine("LinkedList is empty");
           }else {
               while(p.next != null){
                   p = p.next;
               }
               p.prev.next = null;
           }
       }

       public void DeleteSpecificNode(int x)
       {
            Node p;
           p = start;

           if(p == null){
               Console.WriteLine("LinkedList is empty");
           }else {
               while(p != null){
                   if(p.data == x){
                       break;
                   }
                   p = p.next;
               }
               
               if(p == null){
                   Console.WriteLine("Element not found");
               }else {
                   p.prev.next = p.next;
                   if(p.next != null){
                       p.next.prev = p.prev;
                   }
                   
               }
           }
       }
    #endregion

        #region Reverse
        public void Reverse()
        {
            Node p;
            p = start; 
            Node q;
            q = start;
            
            if(p != null && p.next != null){
         
                while(p.next != null){
                    q = q.next;
                    p.next = p.prev;
                    p.prev = q;
                    p = p.prev;
                }
                p.next = p.prev;
                p.prev = null;
                start = p;
            }
            
        }

       #endregion
       
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