using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class SwapNodeInPairs
    {
        static SingleLinkedList sl = new SingleLinkedList();
        public static void Driver()
        {
            sl.addToFront(new int[]{2, 1});
            sl.display();
            Console.WriteLine("After swapping:");
            Node p = SwapPairs(sl.start);
            Console.WriteLine("Head: " + p.data);
 
            Console.Write(p.data);
            p = p.link;
            while (p != null)
            {
                Console.Write("->" + p.data);
                p = p.link;
            }
            Console.WriteLine();
        }

        public static Node SwapPairs(Node head)
        {
             if(head == null){
                return null;
            }
            
            if(head.link == null){
                return head;
            }

            Node p;
            p = head;
            Boolean ishead = false;
            Node headNode = null;
            Node temp = null;

            while(p != null && p.link != null)
            {

                temp = p.link.link;
                p.link.link = p;
                if(!ishead){
                    headNode = p.link;
                    ishead = true;
                }
                if(temp == null || temp.link == null ){
                     p.link = temp;
                }else{
                     p.link = temp.link;
                    
                }
                p = temp;
            }
            return headNode;
        }
    }
}