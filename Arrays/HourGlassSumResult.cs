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

class HourGlassSumResult
{

    /*
     * Challenge: Print the sum of the highest hourglass formation in the array
     * 
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int hourGlassValue = Int32.MinValue;
        for(int height = 0;height < arr.Count-2;height++)
        {
            for(int width = 0; width < arr.Count-2; width++)
            {
                var tempValue = calculateHourGlass(arr, height, width);
                
                if(tempValue > hourGlassValue)
                {
                    hourGlassValue = tempValue;
                }
            }
        }
        return hourGlassValue;
    }
    
    private static int calculateHourGlass(List<List<int>> arr, int heightIndex, int widthIndex)
    {
        var pos1 = arr[heightIndex][widthIndex];
        var pos2 = arr[heightIndex][widthIndex+1];
        var pos3 = arr[heightIndex][widthIndex+2];
        var pos4 = arr[heightIndex+1][widthIndex+1];
        var pos5 = arr[heightIndex+2][widthIndex];
        var pos6 = arr[heightIndex+2][widthIndex+1];
        var pos7 = arr[heightIndex+2][widthIndex+2];
        
        return (pos1+pos2+pos3+pos4+pos5+pos6+pos7);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
