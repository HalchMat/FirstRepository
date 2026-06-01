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
    public static int pageCount(int n, int p)
    {
        int firstpagedist = 0;
        int lastpagedist = 0;
        bool lastpageeven = false;
        if (n % 2 == 0)
        {
            lastpageeven = true;
        }
        firstpagedist = p/2;
        if (lastpageeven)
        {
            lastpagedist = (n-p+1)/2;
        }
        else
        {
            lastpagedist = (n-p)/2;
        }
        return(Math.Min(firstpagedist, lastpagedist));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string? nLine = Console.ReadLine();
        if (nLine == null) return;
        int n = Convert.ToInt32(nLine.Trim());

        string? pLine = Console.ReadLine();
        if (pLine == null) return;
        int p = Convert.ToInt32(pLine.Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);
    }
}
