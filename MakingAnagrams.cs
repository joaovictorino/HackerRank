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

//https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
class MakingAnagrams {

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        char[] caractersA = a.ToCharArray();
        char[] caractersB = b.ToCharArray();

        Dictionary<char, int> dicA = new Dictionary<char, int>();
        Dictionary<char, int> dicB = new Dictionary<char, int>();

        for(int i = 0; i < caractersA.Length; i++)
        {
            if(dicA.ContainsKey(caractersA[i]))
            {
                dicA[caractersA[i]]++;
            }else{
                dicA.Add(caractersA[i], 1);
            }
        }

        for(int i = 0; i < caractersB.Length; i++)
        {
            if(dicB.ContainsKey(caractersB[i]))
            {
                dicB[caractersB[i]]++;
            }else{
                dicB.Add(caractersB[i], 1);
            }
        }

        int contador = 0;
        
        foreach(KeyValuePair<char, int> entry in dicA)
        {
            if(dicB.ContainsKey(entry.Key)){
                if(dicB[entry.Key] == entry.Value
                    || dicB[entry.Key] > entry.Value){
                    contador += entry.Value;
                }else{
                    contador += dicB[entry.Key];
                }
            }
        }

        return (caractersA.Length + caractersB.Length) - contador * 2;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        Console.WriteLine(res);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
