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

    public static List<int> breakingRecords(List<int> scores)
    {
        int minscore = scores[0];
        int mincount = 0;
        int maxscore = scores[0];
        int maxcount = 0;
        List<int> Results = new List<int> ();
        for (int i = 0; i < scores.Count; i++) {
            if (scores[i] < minscore) {
                minscore = scores[i];
                mincount++;
            }
            if (scores[i] > maxscore) {
                maxscore = scores[i];
                maxcount++;
            }
        }
        Results.Add(maxcount);
        Results.Add(mincount);
        return(Results);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH") ?? "output.txt";
        TextWriter textWriter = new StreamWriter(outputPath, true);

        string? firstLine = Console.ReadLine();
        if (firstLine is null)
        {
            return;
        }

        int n = Convert.ToInt32(firstLine.Trim());

        string? scoresLine = Console.ReadLine();
        if (scoresLine is null)
        {
            return;
        }

        List<int> scores = scoresLine.TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
