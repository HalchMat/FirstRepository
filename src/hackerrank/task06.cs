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

    public static int getTotalX(List<int> a, List<int> b)
    {
        if (a == null || b == null || a.Count == 0 || b.Count == 0)
        {
            return 0;
        }

        static int Gcd(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }

        static int Lcm(int x, int y)
        {
            return x / Gcd(x, y) * y;
        }

        int lcm = a.Aggregate(Lcm);
        int gcd = b.Aggregate(Gcd);

        int count = 0;
        for (int value = lcm; value <= gcd; value += lcm)
        {
            if (gcd % value == 0)
            {
                count++;
            }
        }

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
