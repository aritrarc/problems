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

        Console.WriteLine(maxTime.ToString() + " " +  minTime.ToString());

    }


}
