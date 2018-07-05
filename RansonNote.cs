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

//https://www.hackerrank.com/challenges/ctci-ransom-note/problem
class RansonNote {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) 
    {
        bool canUse = true;
        Array.Sort(magazine);
        Array.Sort(note);
        List<string> magazineCopy = magazine.ToList();
        
        foreach(string word in note) 
        {
            if(!magazineCopy.Remove(word))
            {
                canUse=false;
                break;
            }
        }

        if (canUse)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
