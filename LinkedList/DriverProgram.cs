using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;

namespace nsDriverProgram
{
    public class DriverProgram {

            SingleLinkedList singleLL ;
            public DriverProgram(){
                singleLL = new SingleLinkedList();
            }
            public void PerformActions(){  
                singleLL.addToFront(new int[] {1, 3, 2, 4, 5});   
                Console.WriteLine("After adding to front"); 
                singleLL.display();
                Console.WriteLine("After adding to end"); 
                singleLL.addToEnd(new int[] {8, 10});   
                singleLL.display();
                Console.WriteLine("After adding at index"); 
                singleLL.addAtIndex(55, 3);   
                singleLL.display();
                Console.WriteLine("After adding after value"); 
                singleLL.addAfterValue(17, 55);   
                singleLL.display();
                Console.WriteLine("After adding before value"); 
                singleLL.addBeforerValue(19, 10);   
                singleLL.display();
                Console.WriteLine("Delete from front"); 
                singleLL.deleteFromFront();   
                singleLL.display();
                Console.WriteLine("Delete from End"); 
                singleLL.deleteFromEnd();   
                singleLL.display();
                Console.WriteLine("Delete Specific value"); 
                singleLL.deleteParticularValue(1); 
                singleLL.display();
                Console.WriteLine("Delete at index"); 
                singleLL.deleteAtIndex(7); 
                singleLL.display();
                Console.WriteLine("Reverse LinkedList"); 
                singleLL.reverseLinkedList();
                singleLL.display();
                Console.WriteLine("Bubble sort"); 
                singleLL.bubbleSort();
                singleLL.display();
            } 
    }
}