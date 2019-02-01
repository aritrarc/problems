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

public class MinimumTImeRequired {

    // Complete the whatFlavors function below.
    public static void LCM(long[] machines, long goal) {

        Array.Sort(machines);

        long maxTime = machines.Last() * goal / machines.Length ;

        long minTime = machines.First() * goal / machines.Length ;

        long result = getMinTime(machines, minTime, maxTime, goal);

        Console.WriteLine(result.ToString());

    }

    private static long getMinTime(long[] machines, long minTime, long maxTime, long goal)
    {
        long mid = 0;
        while(minTime < maxTime)
        {
            mid = (minTime + maxTime)/2;

            long result = compare(machines, mid);

            if ( result < goal)
            {
                minTime = mid + 1;
            }
            else
            {
                maxTime = mid;
            }
        }
        return maxTime;
    }
    
    private static long compare(long[] machines, long mid)
    {
        long result = 0;
        for(int i=0; i<machines.Length; i++)
        {
            result += mid / machines[i];
        }
        return result;
    }


}
