using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class EqualStacks
    {
        //You have three stacks of cylinders where each cylinder has the same diameter, 
        //but they may vary in height. You can change the height of a stack by removing and discarding its topmost cylinder 
        //any number of times.
        //Find the maximum possible height of the stacks such that all of the stacks are exactly the same height. 
        //This means you must remove zero or more cylinders from the top of zero or more of the three stacks until 
        //they're all the same height, then print the height. 
        //The removals must be performed in such a way as to maximize the height.
        public static void minimumEqualStack(int[] h1, int[] h2, int[] h3)
        {
            Stack<int> stk1 = new Stack<int>();
            Stack<int> stk2 = new Stack<int>();
            Stack<int> stk3 = new Stack<int>();

            int total1 = 0;
            int total2 = 0;
            int total3 = 0;

            for(int i=h1.Length-1; i>=0; i--){
                total1 += h1[i];
                stk1.Push(h1[i]);
            }
             for(int i=h2.Length-1; i>=0; i--){
                total2 += h2[i];
                stk2.Push(h2[i]);
            }
            for(int i=h3.Length-1; i>=0; i--){
                total3 += h3[i];
                stk3.Push(h3[i]);
            }

            while(true){
                int aequal = areEqual(total1, total2, total3);
                if(aequal == 0){
                    break;
                }
                else if(aequal == 1){
                    total1 -= stk1.Pop();
                }
                else if(aequal == 2){
                    total2 -= stk2.Pop();
                }
                else if(aequal == 3){
                    total3 -= stk3.Pop();
                }

            }

            Console.WriteLine(total1);
        }

        private static int areEqual(int total1, int total2, int total3)
        {
            if(total1 == total2 && total2 == total3){
                return 0;
            }
            else if( total1 > total2){
                if(total1 > total3){
                    return 1;
                }
                return 3;
            }
            else{
                if(total2 > total3){
                    return 2;
                }
                return 3;
            }
        }

    }
}