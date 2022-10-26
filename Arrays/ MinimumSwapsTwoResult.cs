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

class MinimumSwapsTwoResult 
{
    /*
     *
     * Challenge: Sort an array and return the minimum amount of swaps required.
     *
     */ 
    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) 
    {
        var swaps = 0;
        var n = arr.Length;
        var temp = new int[n];
        Array.Copy(arr, temp, n);
        Array.Sort(temp);
        
        for(int i=0;i<n;i++)
        {
            if(arr[i] != temp[i])
            {
                swaps++;
                Swap(i, Array.IndexOf(arr, temp[i]), arr);
            }    
        }
        return swaps;
    }
    
    private static void Swap(int index1, int index2, int[] arr)
    {
        var temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
