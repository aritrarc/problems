using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsDynamic
{
    public class Abbreviations
    {
        //Given an array of integers, find the subset of non-adjacent elements with the maximum sum. Calculate the sum of that subset
        private static Dictionary<string, Boolean> memonization = new Dictionary<string, bool>();
        public static void checkIfAbbreviation(string a, string b)
        {

            // string result = abbreviation(a, b) ? "YES" : "NO";
            memonization.Clear();
            string result = Recurse(a, b, a.Length - 1, b.Length - 1) ? "YES" : "NO";
            Console.WriteLine(result);
        }

        static Boolean abbreviationAsAnargram(string a, string b)
        {
            int[] charArray = new int[256];

            foreach (char c in a)
            {
                charArray[c]++;
            }

            foreach (char c in b)
            {
                if (charArray[c] > 0)
                {
                    charArray[c]--;
                }
                else if (charArray[c + 32] > 0)
                {
                    charArray[c + 32]--;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 65; i <= 90; i++)
            {
                if (charArray[i] > 0)
                {
                    return false;
                }
            }

            return true;
        }


        static Boolean Recurse(string a, string b, int aIndex, int bIndex)
        {
            
            //If a is empty , check whether b is also empty. Else return false;
            if(aIndex < 0){
                if(bIndex < 0){
                    return true;
                }else {
                    return false;
                }
            }

            //If b is empty , check whether a has any uppercase letters or not
            if (bIndex < 0)
            {
                while (aIndex >= 0)
                {
                    int asciVal2 = (int)a[aIndex];
                    if (asciVal2 >= 65 && asciVal2 <= 90)
                    {
                        return false;
                    }
                    aIndex--;
                }
                return true;
            }


            string key = aIndex + "," + bIndex;
            Boolean value = false;
            if(memonization.ContainsKey(key)){
                return memonization[key];
            }

            int asciValue = (int)a[aIndex];
            if (asciValue >= 65 && asciValue <= 90)
            {
                if (b[bIndex] == a[aIndex])
                {
                    value = Recurse(a, b, aIndex - 1, bIndex - 1);
                    memonization.Add(key,value);
                    return value;
                }
                else
                {
                    memonization.Add(key,false);
                    return false;
                }
            }
            else
            {
                if (asciValue - 32 == (int)b[bIndex])
                {
                    //return false;
                    value = Recurse(a, b, aIndex - 1, bIndex);
                    if(value){
                        memonization.Add(key,value);
                        return value;
                    }else{
                         value = Recurse(a, b, aIndex - 1, bIndex - 1);
                         memonization.Add(key,value);
                         return value;
                    }
                    //return Recurse(a, b, aIndex - 1, bIndex) || Recurse(a, b, aIndex - 1, bIndex - 1);
                }
                else
                {
                    value = Recurse(a, b, aIndex - 1, bIndex);
                    memonization.Add(key,value);
                    return value;
                }
            }
        }


    }
}