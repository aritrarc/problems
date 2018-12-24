using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace nsArrays
{
    public class SparseArrays
    {
            //There is a collection of input strings and a collection of query strings. 
            //For each query string, determine how many times it occurs in the list of input strings.
            public static void GetSparseArray(string[] strings, string[] queries)
            {
                int[] counts = new int[queries.Length]; 
                Dictionary<string, int> maps = new Dictionary<string, int>();

                for(int i=0; i<strings.Length; i++)
                {
                    if(maps.ContainsKey(strings[i])){
                        maps[strings[i]]++;
                    }else{
                        maps.Add(strings[i], 1);
                    }
                }

                for(int i=0; i<queries.Length; i++)
                {
                    if(maps.ContainsKey(queries[i])){
                        counts[i] = maps[queries[i]];
                    }else{
                       counts[i] = 0;
                    }
                }

            }
    }

}
