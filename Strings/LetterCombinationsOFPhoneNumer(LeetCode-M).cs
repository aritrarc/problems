using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsStrings
{
    public class LetterCombinationsOfPhoneNUmbers
    {
       public static IList<string> combination = new List<string>();
       public static Dictionary<string, string> mapping = new Dictionary<string, string>();

       public void Driver(string digits){

           IList<string> result = new List<string>();
           //Preprocess
           mapping.Clear();
           combination.Clear();
           mapping.Add("2","a,b,c");
           mapping.Add("3","d,e,f");
           mapping.Add("4","g,h,i");
           mapping.Add("5","j,k,l");
           mapping.Add("6","m,n,o");
           mapping.Add("7","p,q,r,s");
           mapping.Add("8","t,u,v");
           mapping.Add("9","w,x,y,z");
           result = LetterCombinations(digits);
           foreach(string element in result){
               Console.Write(element + ",");
           }
       }
       public IList<string> LetterCombinations(string digits) {
           Recurse(string.Empty,0,digits);
           return combination;
        }

        public void Recurse(string curr,int index, string digits){
                if(index == digits.Length){
                    if(!string.IsNullOrEmpty(curr)){
                    combination.Add(curr);}
                    return;
                }
                foreach(string s in mapping[digits[index].ToString()].Split(",")){
                    Recurse(curr+s,index+1,digits);
                }
        }
    }

}
 