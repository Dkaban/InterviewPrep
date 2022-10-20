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

class RepeatedStringResult
{

    /*
     * Challenge: Given a string, how many a's can fit into n length
     * 
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        if(s == "a")
        {
            return n;
        }
        
        long aCount = (long)s.Split('a').Length - 1;
        long stringSize = (long)s.Length;
        long sIntoN = n / stringSize;
        
        long charactersLeft = n - (sIntoN * stringSize);
        
        if(charactersLeft > 0)
        {
            string cutString = s.Substring(0,(int)charactersLeft);
            long leftOverACount = (long)cutString.Split('a').Length - 1;
            return (aCount * sIntoN) + leftOverACount;
        }
        else
        {
            return aCount * sIntoN;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
