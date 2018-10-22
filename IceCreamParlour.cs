using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Solution {

    // Complete the whatFlavors function below.
    public static void whatFlavors(int[] cost, int money) {

            Dictionary<int, int> parameters = new Dictionary<int, int>();

            for(int j=0; j<cost.Length; j++)
            {
                int value = money - cost[j];
                if(parameters.ContainsKey(value))
                {
                    if(Convert.ToInt32(parameters[value]) != j)
                    {
                        if(Convert.ToInt32(parameters[value])  + 1 >  j+1)
                        {
                            Console.WriteLine((j+1) + " " + parameters[value] + 1);
                            return;
                        }
                        else
                        {
                            Console.WriteLine(parameters[value] + 1 + " " + (j+1));
                            return;
                        }
                    }
                }
                else{
                    if(!parameters.ContainsKey(cost[j]))
                    {
                             parameters.Add(cost[j], j);
                    }
                   
                }
            }
    }

}
