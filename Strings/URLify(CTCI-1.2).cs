using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace nsStrings
{
    public class URLify
    {

        // This code is used to reverse a string without using any other DS.
        public static void URLifyString()
        {
            string str = "J OHN MALCOLM JUNI R        ";
            int trueLength = 20;
            int numberOfSpaces = 0;

            for(int i=0; i <trueLength; i++){
                if(str[i] == ' '){
                    numberOfSpaces++;
                }
            }

            int index = trueLength + 2*numberOfSpaces-1;
            char[] charArray = str.ToCharArray();

            while(trueLength >= 1)   {

                if(charArray[trueLength - 1] != ' '){
                    charArray[index] = charArray[trueLength - 1];
                    index--;
                }else{
                    charArray[index] = '0';
                    charArray[index - 1] = '2';
                    charArray[index - 2] = '%';
                    index = index - 3;
                }
                trueLength--;
            } 

            Console.WriteLine(new string(charArray));    
        }
    }

}
 