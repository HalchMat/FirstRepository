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
    public static int migratoryBirds(List<int> arr)
    {
        List<int> IDcount = new List<int>(new int[5]);
        int maxID = 0;
        int maxIDcount = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < IDcount.Count; j++)
            {
                if (arr[i] == j+1)
                {
                    IDcount[j]++;
                }
            }
        }
        for (int i = 1; i <= IDcount.Count; i++)
        {
            if (IDcount[i-1] > maxIDcount)
            {
                maxID = i;
                maxIDcount = IDcount[i-1];
            }
        }
        return(maxID);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string? outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (outputPath is null) return;
        TextWriter textWriter = new StreamWriter(outputPath, true);

        string? arrCountInput = Console.ReadLine();
        if (arrCountInput is null) return;
        int arrCount = Convert.ToInt32(arrCountInput.Trim());

        string? arrInput = Console.ReadLine();
        if (arrInput is null) return;
        List<int> arr = arrInput.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
