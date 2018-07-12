using System;
using System.Collections.Generic;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution
{        
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public static List<string> reorderLines(int logFileSize, string[] logLines)
    {
        List<string> result = new List<string>();
        string[] sorted = new string[logLines.Length];
        for(int counter = 0; counter < logLines.Length; counter++){
            string[] lineSplited = logLines[counter].Split(" ");
            sorted[counter] = logLines[counter].Replace(" ", "").Replace(lineSplited[0], "") + " " + lineSplited[0];
        }

        Array.Sort(sorted);

        foreach(string letter in sorted)
        {
            foreach(string letterOriginal in logLines)
            {
                if(letterOriginal.StartsWith(letter.Split(" ")[1]))
                {
                    result.Add(letterOriginal);
                }
            }
        }

        return result;
    }
    // METHOD SIGNATURE ENDS
    static void Main(string[] args) {
        string[] words = new string[5];
        words[0] = "a1 9 2 3 1";
        words[1] = "g1 act car";
        words[2] = "zo4 4 7";
        words[3] = "ab1 off key dog";
        words[4] = "a8 act zoo";

        List<string> result = reorderLines(5, words);
    }
}