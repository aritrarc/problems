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

        #region DeleteOperations
        public void DeleteFromStart()
        {
            if(last == null){
                Console.WriteLine("List is Empty");
                return;
            }

            if(last.link == last){ //There is a single node
                last = null;
                return;
            }

            last.link = last.link.link;

        }

        public void DeleteFromEnd()
        {
            if(last == null){
                Console.WriteLine("List is Empty");
                return;
            }

            if(last.link == last){ //There is a single node
                last = null;
                return;
            }

            Node p;
            p = last.link;

            while(p.link != last){
                p = p.link;
            }
            p.link = last.link;
            last = p;
        }

        public void DeleteSpecificNode(int x)
        {
             if(last == null){
                Console.WriteLine("List is Empty");
                return;
            }

            if(last.link == last && last.data == x){ //There is a single node
                last = null;
                return;
            }

            Node p;
            p = last.link;

            do{
                if(p.link.data == x){
                    break;
                }
                p = p.link;
            }while(p != last.link);

            if(p.link.data == x){
                if(p.link == last){  //If its the last node
                    p.link = last.link;
                    last = p;
                }else{
                    p.link = p.link.link;
                }
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