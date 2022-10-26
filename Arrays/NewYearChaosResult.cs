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
     * Challenge: Count the number of bribes total needed to reorganize a list of ints.  <= 2 bribes are allowed.
     *
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */
     
    
    public static void minimumBribes(List<int> q)
    {
        var bribes = 0;
        
        //If the value is more than 3 positions away, we've done too many bribes
        for(var i=0;i<q.Count;i++)
        {
            if(q[i] > i + 3) 
            {
                Console.WriteLine("Too chaotic"); 
                return; 
            }
        }

        //We start the count reduced by 3 indexes because of the check above
        for (var i = q.Count - 4; i >= 0; i--) 
        {
            //We use this loop to check if a swap is needed
            for (var j = i; j <= i + 2; j++) 
            {
                if (q[j] > q[j+1]) 
                {
                    var temp = q[j];
                    q[j] = q[j+1];
                    q[j+1] = temp; 
                    bribes++;
                }
            }
        }

        Console.WriteLine(bribes);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();
            
            Result.minimumBribes(q);
        }
    }
}
