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
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> Array = new List<int> ();
        int graderound = 0;
        int grade = 0;
        int resgrade = 0;
        int diff = 0;
        for (int i = 0; i < grades.Count; i++) {
            grade = grades[i];
            graderound = (grade + 5) / 5 * 5;
            diff = graderound - grade;
            if (diff < 3) {
                resgrade = graderound;
            }
            if (diff >= 3) {
                resgrade = grade;
            }
            if (grade < 38) {
                resgrade = grade;
            }
            Array.Add(resgrade);
        }
        return Array;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH") ?? throw new InvalidOperationException("OUTPUT_PATH not set");
        TextWriter textWriter = new StreamWriter(outputPath, true);

        string? input = Console.ReadLine();
        if (input == null) throw new InvalidOperationException("No input for grades count");
        int gradesCount = Convert.ToInt32(input.Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            string? gradeInput = Console.ReadLine();
            if (gradeInput == null) throw new InvalidOperationException("No input for grade");
            int gradesItem = Convert.ToInt32(gradeInput.Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
