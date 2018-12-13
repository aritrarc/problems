using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    //Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs 
    //to the left of a closing bracket (i.e., ), ], or }) of the exact same type.
    //we say a sequence of brackets is balanced if the following conditions are met:
    // 1. It contains no unmatched brackets.
    // 2. The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
    public class BalancedBrackets
    {
        public static void IsBalanced(string s)
        {
            Boolean isBalanced = true;

            Stack<char> stk = new Stack<char>();
            char[] chArr = s.ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (chArr[i] == '(' || chArr[i] == '{' || chArr[i] == '[')
                {
                    stk.Push(chArr[i]);
                }
                else
                {
                    if (stk.Count > 0)
                    {
                        if (!isComplement(stk.Pop(), chArr[i]))
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }


            Console.WriteLine(isBalanced && stk.Count == 0 ? "YES" : "NO");
        }

        private static Boolean isComplement(char c1, char c2)
        {
            if (c1 == '(' && c2 == ')')
            {
                return true;
            }
            else if (c1 == '{' && c2 == '}')
            {
                return true;
            }
            else if (c1 == '[' && c2 == ']')
            {
                return true;
            }
            return false;
        }
    }
}