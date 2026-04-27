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

class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (x1 > x2 && v2 > v1) {
            while (x1 > x2) {
                x1 = x1 + v1;
                x2 = x2 + v2;
                if (x1 == x2) {
                    return ("YES");
                }
            }
        }
        if (x2 > x1 && v1 > v2) {
            while (x2 > x1) {
                x1 = x1 + v1;
                x2 = x2 + v2;
                if (x1 == x2) {
                    return ("YES");
                }
        }
        }
        if (x1 == x2 && v1 == v2) {
            return ("YES");
        }
        return ("NO");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]!);

        int v1 = Convert.ToInt32(firstMultipleInput[1]!);

        int x2 = Convert.ToInt32(firstMultipleInput[2]!);

        int v2 = Convert.ToInt32(firstMultipleInput[3]!);

        string result = Result.kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
