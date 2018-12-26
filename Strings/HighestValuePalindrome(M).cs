using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStrings
{
    public class HighestValuePalindrome{

        //You will be given a string representation of a number and a maximum number of changes you can make. 
        //Alter the string, one digit at a time, to create the string representation of the largest number possible given the limit to the number of changes.
        public static void GetHighestpalindromeValue(string s,int n, int k)
        {
            char[] c = s.ToCharArray();
            int i=0;
            int j=n-1;

            while(i<j)  /// First while loop is to turn the string into palindorme.
            {
                if(s[i] != s[j]){
                    c[i] = c[j] = (char)Math.Max(s[i], s[j]);
                    k--;
                }
                i++;
                j--;
            }

            if(k < 0){
                 Console.WriteLine("-1");
            }
            else{

                i = 0;
                j=n-1;

                while(i <= j){ //Second while is to maximize the palindorme

                    if(i==j){
                        if( k > 0){
                            c[i] = '9'; //ChangeMiddle ELement to 9 if k is still greter than 0;
                        }
                    }

                    if(c[i] != '9')
                    {
                        if(k >= 2 && c[i] == s[i] && c[j] == s[j]){ //If both elements are same as original list then we will need 2 swaps to make each element a 9.
                            c[i] = c[j] = '9';
                            k = k -2;
                        }
                        else if ( k >= 1 && ((c[i] != s[i])||(c[j] != s[j]))){ //If one element of original list is same then we will need only 1 swaps to make each element a 9. AS we have already taken into account the other swap in the previous loop.
                            c[i] = c[j] = '9';
                            k = k - 1;
                        }
                    }
                    i++;
                    j--;
                }
                string s1 = new string(c);
                Console.WriteLine(s1);
            }
           
        }
       
    }
} 