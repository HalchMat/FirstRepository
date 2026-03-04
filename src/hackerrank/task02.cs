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
    public static void staircase(int n)
    {
        for (int i = 1; i < n+1; i++)
        {
            for (int x = i; x < n; x++)
            {
                Console.Write(" ");
            }
            for (int x = 0; x < i; x++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        if (input is null)
        {
            return;
        }
        int n = Convert.ToInt32(input.Trim());
        Result.staircase(n);
    }
}