using System;
using System.Collections;
using System.Linq;

namespace RemoveCharacters
{
    public class RemoveCharacters{

        // This code is used to remove the occurence of a character from string without using any other DS.
        public static void RemoveCharacterFromString(string str, char c)
        {
             char[] charArray = str.ToLower().ToCharArray();
             int counter = 0;
             int j=0;
             for(int i=0; i<str.Length; i++)
             {
                 if(str[i] != c)
                 {
                    charArray[j++] = str[i];
                 }
                 else
                 {
                     counter++;
                 }
             }

             while(counter > 0)
             {
                 charArray[j++] = '\0';
                 counter--;
             }

             Console.WriteLine(charArray);
        }
       
    }
} 