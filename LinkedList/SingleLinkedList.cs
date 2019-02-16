using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SingleLinkedListDT
{
    public class Node
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
        public Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        #region InsertionOperations
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

        public void addAfterValue(int x, int value)
        {
            Node p;
            p =  start;
            while(p != null)
            {
                if( p.data == value){
                    break;
                }
                p = p.link;
            }

            if(p == null){
                Console.WriteLine("Element {0} not found in LinkedList",value);
            }
            else{
                Node temp =new Node(x);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void addBeforerValue(int x, int value)
        {
            Node p;
            p =  start;
            while(p.link != null)
            {
                if( p.link.data == value){
                    break;
                }
                p = p.link;
            }

            if(p.link == null){
                Console.WriteLine("Element {0} not found in LinkedList",value);
            }
            else{
                Node temp =new Node(x);
                temp.link = p.link;
                p.link = temp;
            }
        }
        #endregion

        #region DeletionOperations
        public void deleteFromFront()
        {
            Node p;
            p = start;

            if(p == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else{
                start = p.link;
            }
        }

        public void deleteFromEnd()
        {
            Node p;
            p = start;

            if(p == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else{
                while(p.link.link != null){
                    p = p.link;
                }
                p.link = null;
            }
        }

        public void deleteParticularValue(int x)
        {
            Node p;
            p = start;

            if(p == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else{
                while(p.link != null){
                    if(p.link.data == x){
                        break;
                    }
                    p = p.link;
                }

                if(p.link == null){
                     Console.WriteLine("Element {0} not found in LinkedList",x);
                }else {
                    p.link = p.link.link;
                }
                
            }
        }

        public void deleteAtIndex(int index)
        {
            Node p;
            p = start;
            int i = 1;
            if(p == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else if(index == 1)
            {
                start = p.link;
            }
            else{
                for(i = 1; p.link!=null && i<index - 1; i++){
                    p = p.link;
                }  

                if(p.link == null){
                    Console.WriteLine("Index {0} doesn't exist in LinkedList",index);
                } else {
                    p.link = p.link.link;
                }             
            }
        }

        #endregion
       
        #region Reversing
        public void reverseLinkedList(){
            Node p ;
            p = start;
            Node prev;
            prev = null;
            Node next;
            next = null;

            if(p == null){
                Console.WriteLine("LinkedList is empty");
            }else {
                while(p != null){
                    next = p.link;
                    p.link = prev;
                    prev = p;
                    p = next;
                }
                start = prev;
            }
        }
        #endregion

        #region Sorting
        public void bubbleSort()
        {
            Node p;
            if(start == null){
                Console.WriteLine("LinkedList doesn't contain any element");
                return;
            }
            Node q;

            for(p = start; p!= null; p = p.link )
            {
                for(q=p.link; q!= null; q = q.link)
                {
                    if(p.data > q.data){
                        int temp = q.data;
                        q.data = p.data;
                        p.data = temp;
                    }
                }

            }
        }

        public void bubbleSortLinkExchange()
        {
            Node p;
            if(start == null){
                Console.WriteLine("LinkedList doesn't contain any element");
                return;
            }
            Node q;

            for(p = start; p.link!= null; p = p.link )
            {
                for(q=p.link; q.link!= null; q = q.link)
                {
                    if(p.data > q.data){
                        int temp = q.data;
                        q.data = p.data;
                        p.data = temp;
                    }
                }

            }
        }
        #endregion

        #region MergePoint
        public void MergePoint(){
            SingleLinkedList list1 = new SingleLinkedList();
            list1.addToFront(new int[] {6, 5, 3, 2, 1});
            SingleLinkedList list2 = new SingleLinkedList();
            list1.addToFront(new int[] {6, 5, 3, 9, 7, 1});

            Node p1;
            p1 = list1.start;

            Node p2;
            p2 = list2.start;

            while( p1 != p2)
            {
                if(p1.link == null)
                {
                    p1 = list2.start;
                }else {
                    p1 = p1.link;
                }

                if(p2.link == null)
                {
                    p2 = list1.start;
                }else {
                    p2 = p2.link;
                }
            }

            Console.WriteLine(p2.data);
        }
        #endregion


        public bool hasCycle()
        {
            Node t;
            t = start;
            Node h;
            h = start;

            while( h != null && h.link != null)
            {
                t = t.link;
                h = h.link.link;
                if(t == h){
                    return true;
                }

            }
            return false;
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