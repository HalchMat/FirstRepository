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
    public static int sockMerchant(int n, List<int> ar)
    {
        int tempnum = 0;
        int pairs = 0;
        for (int i = 0; i < n; i++)
        {
            if (ar[i] != 0)
            {
                tempnum = ar[i];
                ar[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    if (tempnum == ar[j])
                    {
                        pairs++;
                        ar[j] = 0;
                        break;
                        
                    }
                }
            }
        }
        return(pairs);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string? nLine = Console.ReadLine();
        if (nLine == null)
        {
            Console.WriteLine(0);
            return;
        }

        if (!int.TryParse(nLine.Trim(), out int n))
        {
            Console.WriteLine(0);
            return;
        }

        string? arLine = Console.ReadLine();
        List<int> ar;
        if (string.IsNullOrWhiteSpace(arLine))
        {
            ar = new List<int>();
        }
        else
        {
            ar = arLine.TrimEnd()
                .Split(' ')
                .Select(s => s.Trim())
                .Where(s => s.Length > 0)
                .Select(s => Convert.ToInt32(s))
                .ToList();
        }

        n = Math.Min(n, ar.Count);

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
