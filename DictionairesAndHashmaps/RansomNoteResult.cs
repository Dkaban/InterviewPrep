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

class RansomNoteResult
{

    /*
     * Challenge: Match all of the words (case sensitive) in the note list to the magazine list.  Return Yes if all found, No if any missing.
     *
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        var wordCount = 0;
        magazine.Sort();
        note.Sort();
        
        for(var i=0;i<note.Count;i++)
        {
            if(magazine.Contains(note[i]))
            {
                magazine.Remove(note[i]);
                wordCount++;

                if(wordCount >= note.Count)
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }

        if(wordCount == note.Count)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        Result.checkMagazine(magazine, note);
    }
}
