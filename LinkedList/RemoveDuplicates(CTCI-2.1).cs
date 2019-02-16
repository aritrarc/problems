using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class RemoveDuplicatesFromSingleLinkedList
    {
        public static void RemoveDuplicates()
        {
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{1, 2, 4, 1, 3, 5, 3, 5, 5, 5, 6, 7, 8, 5});

             //Display original list
             singleLinkedList.display();

             HashSet<int> data = new HashSet<int>();
             Node p;
             p = singleLinkedList.start;

             data.Add(p.data);

             while(p.link != null)
             {
                    if(!data.Contains(p.link.data)){
                     data.Add(p.data);
                     p = p.link;
                 }else{
                     p.link = p.link.link;
                 }                
             }

            //Display list after removing duplicates
             singleLinkedList.display();
        }

        public static void RemoveDuplicatesInplace()
        {
            
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{1, 2, 4, 1, 3, 5, 3, 5, 5, 5, 6, 7, 8, 5});

             //Display original list
             singleLinkedList.display();

             Node p;
             p = singleLinkedList.start;

             Node q;
             q = p;

             while(p.link !=  null)
             {
                 while(q.link != null)
                 {
                     if(p.data == q.link.data){
                         q.link = q.link.link;
                     }else{
                        q = q.link;
                     }
                 }
                 p = p.link;
                 q = p;
             }

             //Display list after removing duplicates
             singleLinkedList.display();
        }
    } 
}