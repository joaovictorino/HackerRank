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

class MultiplyWithAdditionRecursion {
    private static int nTimesK(int n, int k) {
        if(n > 1)
        {
            return k + nTimesK(n - 1, k);
        }

        return k;
    }
    public static void Main(String[] args) {
        string[] values = Console.ReadLine().Split(' ');
        int result = nTimesK(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]));
        Console.WriteLine("Result: " + result);
    }
}