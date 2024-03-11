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

    /*
     * Complete the 'luckBalance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. 2D_INTEGER_ARRAY contests
     */

    public static int luckBalance(int k, List<List<int>> contests)
    {
        int maxLuck = 0; // To accumulate the maximum luck balance
    
        // Separate important and unimportant contests
        List<int> importantContests = new List<int>();
        foreach(var contest in contests)
        {
            if(contest[1] == 1) // If the contest is important
            {
                importantContests.Add(contest[0]); // Add its luck balance
            }
            else
            {
                maxLuck += contest[0]; // Add luck balance of unimportant contests directly
            }
        }
        
        // Sort the important contests by their luck balances in ascending order
        importantContests.Sort();

        // Lose as many of the least luck-giving important contests as possible
        while(importantContests.Count > k)
        {
            maxLuck -= importantContests[0]; // Subtract luck balance of the contest Lena has to win
            importantContests.RemoveAt(0); // Remove the contest from the list
        }

        // Add the luck balances of important contests Lena can lose
        foreach(var luck in importantContests)
        {
            maxLuck += luck;
        }

        return maxLuck;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> contests = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(contestsTemp => Convert.ToInt32(contestsTemp)).ToList());
        }

        int result = Result.luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
