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
    public static int diagonalDifference(List<List<int>> arr)
    {
        int diag1 = 0;
        int diag2 = 0;
        int temp = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            diag1 += arr[i][i];
        }
        for (int i = arr.Count-1; i >=0; i--)
        {
            diag2 += arr[i][temp];
            temp++;
        }
        return(Math.Abs(diag1-diag2));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string? nLine = Console.ReadLine();
        if (nLine == null) return;
        int n = Convert.ToInt32(nLine.Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            string? line = Console.ReadLine();
            if (line == null) break;
            arr.Add(line.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
