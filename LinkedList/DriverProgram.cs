using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SingleLinkedListDT;
using DoubleLinkedListDT;
using CircularLinkedListDT;

namespace nsDriverProgram
{
    public class DriverProgram {

            SingleLinkedList singleLL ;
            DoubleLinkedList doubleLL; 

            CircularLinkedList circularLL;

            public DriverProgram(){
                singleLL = new SingleLinkedList();
                doubleLL = new DoubleLinkedList();
                circularLL = new CircularLinkedList();
            }
            public void PerformActionsSingleLinkedList(){  
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

            public void PerformActionsDoubleLinkedList()
            {
                doubleLL.InsertAtFront(new int[] {1, 3, 2, 4, 5});   
                Console.WriteLine("After adding to front"); 
                doubleLL.DisplayDoubleLinkedList();
                doubleLL.InsertAtEnd(77);
                Console.WriteLine("After adding to end"); 
                doubleLL.DisplayDoubleLinkedList();
                doubleLL.InsertAfterNode(2, 99);
                Console.WriteLine("Inserting after node"); 
                doubleLL.DisplayDoubleLinkedList();
                doubleLL.InsertBeforeNode(4, 13);
                Console.WriteLine("Inserting before node"); 
                doubleLL.DisplayDoubleLinkedList();
                Console.WriteLine("Delete from Front"); 
                doubleLL.DeleteFromFront();
                doubleLL.DisplayDoubleLinkedList();
                Console.WriteLine("Delete from End"); 
                doubleLL.DeleteFromEnd();
                doubleLL.DisplayDoubleLinkedList();
                Console.WriteLine("Delete specific node"); 
                doubleLL.DeleteSpecificNode(66);
                doubleLL.DisplayDoubleLinkedList();
                Console.WriteLine("Reversed"); 
                doubleLL.Reverse();
                doubleLL.DisplayDoubleLinkedList();
            }

            public void PerformActionsCircularLinkedList()
            {
                circularLL.display();
                circularLL.InsertFront(new int[]{6, 5, 4, 3, 2, 1});
                Console.WriteLine("After Inserting at front:");
                circularLL.display();
                circularLL.InsertAtEnd(new int[]{7, 8, 9});
                Console.WriteLine("After Inserting at end:");
                circularLL.display();
                circularLL.InsetAfterNode(9, 21);
                Console.WriteLine("After Inserting after node:");
                circularLL.display();
                Console.WriteLine("After Deleting first node:");
                circularLL.DeleteFromStart();
                circularLL.display();
                Console.WriteLine("After Deleting last node:");
                circularLL.DeleteFromEnd();
                circularLL.display();
                Console.WriteLine("Delete specific node:");
                circularLL.DeleteSpecificNode(9);
                circularLL.display();
            }

            public void FindMergePoint()
            {
                SingleLinkedList ls = new SingleLinkedList();
                ls.MergePoint();
            }
    }
}