using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nsDictionariesnHashmaps
{
    public class FrequencyQueries
    {

        //You are given q queries. Each query is of the form two integers described below: 
        //1. x : Insert x in your data structure. 
        //2. y:  Delete one occurence of y from your data structure, if present. 
        //3. z:  Check if any integer is present whose frequency is exactly z. If yes, print 1 else 0.
        public static void NumberOfTriplets(List<List<int>> queries)
        {
            //To store count of elements
            Dictionary<int, int> dc = new Dictionary<int, int>();
            List<int> res = new List<int>();
            //To store count of count of elements 
            Dictionary<int , int> counts = new Dictionary<int, int>();
            
            foreach(List<int> list in queries)
            {
                if(list[0] == 1)
                {
                    if(dc.ContainsKey(list[1])){
                       int inc =  ++dc[list[1]];
                       if(counts.ContainsKey(inc)){
                            counts[inc]++;
                        }else{
                            counts.Add(inc,1);
                        }
                        if(counts.ContainsKey(inc-1)){
                            counts[inc-1]--;
                            if(counts[inc-1] < 0){
                                counts[inc-1] = 0;
                            }
                        }
                    }else{
                        dc.Add(list[1],1);
                        if(counts.ContainsKey(1)){
                            counts[1]++;
                        }else{
                            counts.Add(1,1);
                        }
                    }
                }
                else if (list[0] == 2)
                {
                    if(dc.ContainsKey(list[1])){
                        int dec = --dc[list[1]];
                        if(dc[list[1]] < 0){
                            dc[list[1]] = 0;
                        }
                        if(counts.ContainsKey(dec)){
                            counts[dec]++;
                        }else{
                            if(dec > 0){
                                counts.Add(dec,1);
                            }
                        }
                        if(counts.ContainsKey(dec+1)){
                            counts[dec+1]--;
                            if(counts[dec+1] < 0){
                                counts[dec+1] = 0;
                            }
                        }
                    }
                    
                }
                else if(list[0] == 3)
                {
                    if(counts.ContainsKey(list[1])){
                        if(counts[list[1]] > 0){
                            res.Add(1);
                        }else {
                            res.Add(0);
                        }                       
                    }else{
                         res.Add(0);
                    }
                }
            }
        }

        public static void CreateInput()
        {
            List<int> innerList = new List<int>();
            List<List<int>> queries = new List<List<int>>();
            innerList.Add(1);
            innerList.Add(5);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(1);
            innerList.Add(6);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(3);
            innerList.Add(2);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(1);
            innerList.Add(10);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(1);
            innerList.Add(10);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(1);
            innerList.Add(6);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(2);
            innerList.Add(5);
            queries.Add(innerList);
            innerList = new List<int>();
            innerList.Add(3);
            innerList.Add(2);
            queries.Add(innerList);
            NumberOfTriplets(queries);
        }

    }
}