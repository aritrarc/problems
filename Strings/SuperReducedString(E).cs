using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStrings
{
    public class SuperReducedString{

        // Steve’s task is to delete as many characters as possible using this method( delete adjacent characters) and print the resulting string. 
        //If the final string is empty, print Empty String
        public static void GetSuperReducedString(string s)
        {
            string str = string.Empty;
            Stack<string> stk = new Stack<string>();
            
            for(int i = 0; i < s.Length; i++){

                if(stk.Count > 0){
                    if(s[i].ToString() == stk.Peek()){
                        stk.Pop();
                    }else{
                         stk.Push(s[i].ToString());
                    }
                }else{
                    stk.Push(s[i].ToString());
                }
            }


            if(stk.Count == 0){
                str = "Empty String";
                Console.WriteLine(str);
                return;
            }else{
                while(stk.Count > 0)
                {
                    str += stk.Pop();
                }
            }
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));         
        }
       
    }
} 