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

class SalesByMatchResult {

    // Challenge: Determine how many pairs of socks with matching colors there are
    // 
    // Complete the sockMerchant function below.
    //
    static int sockMerchant(int n, int[] ar) {

        int pairCount = 0;
        List<int> indexList = new List<int>();
        for(int i=0;i<ar.Length;i++)
        {
            for(int j=i+1;j<ar.Length;j++)
            {
                if(ar[i] == ar[j] && !indexList.Contains(j) && !indexList.Contains(i))
                {
                    //We have a pair!
                    pairCount++;
                    indexList.Add(j);
                    indexList.Add(i);
                }
            }
        }
        return pairCount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
