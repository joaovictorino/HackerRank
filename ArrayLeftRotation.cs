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

class ArrayLeftRotation {

    //my solution
    // static int[] rotLeft(int[] arrayIntegers, int numberRotation) {
    //     for(int rotation = 0; rotation < numberRotation; rotation++){
    //         int elementRotate = 0;
    //         for(int elements = 0; elements < arrayIntegers.Length; elements++){
    //             if(elements == 0){
    //                 elementRotate = arrayIntegers[elements];
    //             }else{
    //                 arrayIntegers[elements - 1] = arrayIntegers[elements];
    //                 if(elements == arrayIntegers.Length - 1){
    //                     arrayIntegers[elements] = elementRotate;
    //                 }
    //             }
    //         }
    //     }
    //     return arrayIntegers;
    // }

    //best solution
    static int[] rotLeft(int[] arrayIntegers, int numberRotation) {
        var newArray = new int[arrayIntegers.Length];
        for(int counter = 0; counter < arrayIntegers.Length; counter++) {
            newArray[counter] = arrayIntegers[(counter + numberRotation) % arrayIntegers.Length];    
        }
        return newArray;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
