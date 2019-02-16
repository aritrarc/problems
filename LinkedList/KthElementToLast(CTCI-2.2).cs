using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class KthToLastElement
    {
        public static void FindkthtolastElement(int k)
        {
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{1, 2, 4, 1, 3, 5, 3, 5, 5, 5, 6, 7, 8, 5});

             //Display original list
             singleLinkedList.display();

             int count = 0;
             Node p = singleLinkedList.start;

            while(p != null){
                p = p.link;
                count++;
            }
            int elementToFind = count - k;
            p = singleLinkedList.start;
            while(elementToFind > 0){
                p = p.link;
                elementToFind--;
            }

            Console.WriteLine(p.data);
        }

        public static void FindkthtolastElementRecursive(int k)
        {
            
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{1, 2, 4, 1, 3, 5, 3, 5, 5, 5, 6, 7, 8, 5});

             //Display original list
             singleLinkedList.display();

             Recurse(singleLinkedList.start, k);

             
        }
        public static int Recurse(Node p, int k)
        {
            if(p == null){
                return 0;
            }

            int val = 1 + Recurse(p.link, k);
            if(val == k)
            {
                Console.WriteLine(p.data);
            }
            return val;
        } 
    } 
}