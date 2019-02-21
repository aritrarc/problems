using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class LoopDetection
    {
        public static void CheckIfCycle()
        {
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{8,7,6,5,4,3,2,1});
             Node n = new Node(9);
             singleLinkedList.start.link.link.link.link.link.link.link.link = n;
             n.link = singleLinkedList.start.link.link;
             Boolean hasCycle = false;

             //Display original list
             //singleLinkedList.display();
            
            Node h = singleLinkedList.start;
            Node t = singleLinkedList.start;
            h = h.link.link;
            t = t.link;
            while(h != null && h.link != null)
            {
                if(h.data == t.data)
                {
                    hasCycle = true;
                    break;
                }
                h = h.link.link;
                t = t.link;
            }

            if(hasCycle){
                h = singleLinkedList.start;
                while(h.data != t.data){
                    h = h.link;
                    t = t.link;
                }
                Console.WriteLine("CYCLE at node {0}",h.data);
            }else{
                Console.WriteLine("NO CYCLE");
            }
        }      
    } 
}