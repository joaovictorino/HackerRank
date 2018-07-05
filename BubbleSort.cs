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

//https://www.hackerrank.com/challenges/ctci-bubble-sort/problem
class BubbleSort {

    // Complete the countSwaps function below.
    static void countSwaps(int[] a) {
        int count = 0;

        for (int i = 0; i < a.Length; i++) {
            for (int j = 0; j < a.Length - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1]) {
                    count++;
                    a = swap(j, j + 1, a);
                }
            }
        }

        Console.WriteLine("Array is sorted in {0} swaps.", count);
        Console.WriteLine("First Element: {0}", a[0]);
        Console.WriteLine("Last Element: {0}", a[a.Length - 1]);
    }

    static int[] swap(int index, int indexBigger, int[] arrayValues)
    {
        int value = arrayValues[index];
        int valueBigger = arrayValues[indexBigger];
        arrayValues[index] = valueBigger;
        arrayValues[indexBigger] = value;
        return arrayValues;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        countSwaps(a);
    }
}
