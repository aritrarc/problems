using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class PalindromeLinkedList
    {
        public static void CheckIfPalindrome()
        {
             SingleLinkedList singleLinkedList = new SingleLinkedList();
             singleLinkedList.addToFront(new int[]{1, 2, 3, 3, 4, 2, 1});
             
             SingleLinkedList reversedSingleLinkedList= new SingleLinkedList();
             //Display original list
             singleLinkedList.display();

             Node p = singleLinkedList.start;
            List<int> elements = new List<int>();

            while(p != null){
                elements.Add(p.data);
                p = p.link;
            }
            
            reversedSingleLinkedList.addToFront(elements.ToArray());
            //Display original list
             reversedSingleLinkedList.display();

             //Check if both Linked Lists are equal
             Node i = singleLinkedList.start;
             Node q = reversedSingleLinkedList.start;

             while(i != null && q != null){
                 if(i.data != q.data){
                     Console.WriteLine("NOT PALINDROME");
                     return;
                 }
                 i = i.link;
                 q = q.link;
             }
              Console.WriteLine("PALINDROME");

        }

       
    } 
}