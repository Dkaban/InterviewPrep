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

class CountingValleysResult
{

    /*
     * Challenge: Count how many times they dip below sea level.
     *
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        //We need to keep track of the players height
        int height = 0;
        int valleys = 0;
        bool inValley = false;
        
        for(int i=0;i<steps;i++)
        {
            //If the height goes below 0 we are in a valley
            //If it returns to 0 we count that valley
            switch (path[i])
            {
                //If the height goes below 0 we are in a valley
                //If it returns to 0 we count that valley
                case 'D':
                    height--;
                    break;
                case 'U':
                    height++;
                    break;
                    
                default:
                    break;
            }
            
            if(height < 0)
            {
                inValley = true;
            }
            else if(height >= 0)
            {
                if(inValley)
                {
                    valleys++;  
                }
                
                inValley = false;
            }
        }
        return valleys;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
