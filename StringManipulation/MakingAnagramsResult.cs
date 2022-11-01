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
     * Challenge: Count the deletions required to make the strings anagrams of each other
     *
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

    public static int makeAnagram(string str1, string str2)
    {
        //We create an array to hold the alphabet
        int []arr = new int[26];
        //We add all of the letters to the array in their alphabet index
        for (int i = 0; i < str1.Length; i++) 
        {
            //-'a' shifts the values using ASCII
            arr[str1[i]- 'a']++;
        }
        
        //We remove the values that exist in str2 in the array
        for (int i = 0; i < str2.Length; i++) 
        {
            arr[str2[i] - 'a']--;
        }
  
        int ans = 0;
        //We add the values to the answer to be deleted, getting abs value because of negatives
        for (int i = 0; i < 26; i++) 
        {
            ans += Math.Abs(arr[i]);
        }
        
        return ans;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = Result.makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
