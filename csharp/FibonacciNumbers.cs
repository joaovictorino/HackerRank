using System;
using System.Collections.Generic;
using System.IO;

//https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem
class FibonacciNumbers {
    
    public static int Fibonacci(int n) {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}