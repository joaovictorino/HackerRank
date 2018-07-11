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

//https://www.hackerrank.com/challenges/arrays-ds/submissions
class ReverseArray {

    // Complete the reverseArray function below.
    static int[] reverseArray(int[] array) {
        int swaps = array.Length / 2;
        for(int counter = 0; counter < swaps; counter++){
            int value1 = array[counter];
            int value2 = array[array.Length - 1 - counter];

            array[counter] = value2;
            array[array.Length - 1 - counter] = value1;
        }

        return array;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);

        Console.WriteLine(string.Join(" ", res));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
