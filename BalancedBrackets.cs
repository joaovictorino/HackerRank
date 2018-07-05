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

//https://www.hackerrank.com/challenges/ctci-balanced-brackets/problem
class BalancedBrackets {

    // Complete the isBalanced function below.
    // static string isBalanced(string s) {
    //     char[] values = s.ToCharArray();
    //     int size = (values.Length/2) - 1;

    //     for(int i = size; i >= 0; i--)
    //     {
    //         if(!isEqual(values[i], values[values.Length - 1 - i]))
    //         {
    //             return "NO";
    //         }
    //     }

    //     return "YES";
    // }

    static bool isEqual(char a, char b) {
        if (a == '(' && b == ')'){
            return true;
        }else if (a == '[' && b == ']'){
            return true;
        }else if (a == '{' && b == '}'){
            return true;
        }

        return false;
    }

    static string isBalanced(string s) {
        char[] values = s.ToCharArray();
        char[] add = {'(', '{', '['};
        Stack<char> stack = new Stack<char>();
        foreach(char value in values) {
            if(add.Contains(value)) {
                stack.Push(value);
            }else if(stack.Count == 0 
                        || !isEqual(stack.Pop(), value)){
                return "NO";
            }
        }

        if(stack.Count > 0)
            return "NO";

        return "YES";
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
