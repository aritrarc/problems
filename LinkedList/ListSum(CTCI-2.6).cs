using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SingleLinkedListDT;

namespace nsLinkedList
{
    public class ListSum
    {
        public static void FindSumOfTwoLinkedLists()
        {
             SingleLinkedList singleLinkedList1 = new SingleLinkedList();
             singleLinkedList1.addToFront(new int[]{8, 7, 1, 6});

             SingleLinkedList singleLinkedList2 = new SingleLinkedList();
             singleLinkedList2.addToFront(new int[]{5, 9, 2});

             singleLinkedList1.display();
             singleLinkedList2.display();

             //Sum(singleLinkedList1.start, singleLinkedList2.start);
             SumReverse(singleLinkedList1.start, singleLinkedList2.start);
        }

        private static void Sum(Node s1start, Node s2start)
        {
            SingleLinkedList summedlist = new SingleLinkedList();
            int val = s1start.data + s2start.data;
            int carry = ( val >= 10 ) ? 1 : 0;
            val = val % 10;
            Node q = new Node(val);
            s1start = s1start.link;
            s2start = s2start.link;
            summedlist.start = q;
            while(s1start != null && s2start != null)
            {
              
                val = s1start.data + s2start.data + carry;
                if( val >= 10)
                {
                    carry = 1;                   
                }
                else {
                    carry = 0;
                }

                Node temp = new Node(val % 10);
                q.link = temp;
                q = temp;
                s1start = s1start.link;
                s2start = s2start.link;
            }

            if(carry > 0)
            {
                Node temp = new Node(carry);
                q.link = temp;
                q = temp;
            }

           
            summedlist.display();
        }


        private static void SumReverse(Node s1start, Node s2start)
        {
            StringBuilder builder1 = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();

            while(s1start != null)
            {
                builder1.Append(s1start.data);
                s1start = s1start.link;
            }

            while(s2start != null)
            {
                builder2.Append(s2start.data);
                s2start = s2start.link;
            }

            int num1 = Convert.ToInt32(builder1.ToString());
            int num2 = Convert.ToInt32(builder2.ToString());

            string result = (num1 + num2).ToString();

            SingleLinkedList resultList = new SingleLinkedList();
            int i = result.Length-1;
            List<int> valueList = new List<int>();
            while(i >= 0){
                valueList.Add(Convert.ToInt32(result.Substring(i,1)));
                i--;
            }
            resultList.addToFront(valueList.ToArray());
            resultList.display();
        }
       
    } 
}