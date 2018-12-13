using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{
    public class EvaluatePostFixExpression
    {
        //Evaluate a PostFix expression.
        public static void getPostfixExpression(string s)
        {
            int result = 0;
            Stack<string> stk = new Stack<string>();

            for(int i=0; i<s.Length; i++){
                if(s[i] == '+'){
                    int op1 = Convert.ToInt32(stk.Pop());
                    int op2 = Convert.ToInt32(stk.Pop());
                    stk.Push((op2 + op1).ToString());
                }
                else if(s[i] == '-'){
                      int op1 = Convert.ToInt32(stk.Pop());
                    int op2 = Convert.ToInt32(stk.Pop());
                   stk.Push((op2 - op1).ToString()); 
                }
                else if(s[i] == '*'){
                       int op1 = Convert.ToInt32(stk.Pop());
                    int op2 = Convert.ToInt32(stk.Pop());
                    stk.Push((op2 * op1).ToString());
                }
                else if(s[i] == '/'){
                    int op1 = Convert.ToInt32(stk.Pop());
                    int op2 = Convert.ToInt32(stk.Pop());
                    stk.Push((op2 / op1).ToString());
                }
                else {
                    stk.Push(s[i].ToString());
                }
            }
            result = Convert.ToInt32(stk.Pop());
            Console.WriteLine(result);
        }

    }
}