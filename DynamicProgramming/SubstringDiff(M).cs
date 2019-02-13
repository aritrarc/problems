using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class SubstringDiff
    {
       
        public static void substringDiff(int k, string s1, string s2)
        {
            int result = Recurse(k, s1, s2);
            Console.WriteLine(result);
        }

        
        public static int Recurse(int k, string s1, string s2)
        {
               int global_max = 0;

                for(int i=0; i<s1.Length; i++)
                {
                    int diff = 0;
                    int x = 0;
                    int j = 0;
                    while( j <= s2.Length && x <= s1.Length)
                    {
                        if( diff > k)
                        {
                            global_max = Math.Max(global_max, i - x);
                            break;
                        }

                        if( j == s2.Length || x == s1.Length){
                            break;
                        }
                        if(s1[i] != s1[j])
                        {
                            diff++;
                        }
                        x++;
                        j++;
                    }

                }

               return global_max;
        }

    }
}