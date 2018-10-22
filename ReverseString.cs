using System;
using System.Collections;
using System.Linq;

namespace ReverseString
{
    public class ReverseString{

        // This code is used to reverse a string without using any other DS.
        public static void RemoveCharacterFromString(string str)
        {
             char[] charArray = str.ToLower().ToCharArray();
             int counter = 0;
             int n = str.Length;
             char tempChar = 'a';
             if(n%2 == 0)
             {
                 counter = (n / 2) - 1;
             }
             else{
                 counter = (n - 1) / 2;
             }
             for(int i=0; i<=counter; i++)
             {
                tempChar = str[i];
                charArray[i] = charArray[n - i - 1];
                charArray[n - i - 1] = tempChar;
             }

             Console.WriteLine(charArray);
        }
       
    }
} 