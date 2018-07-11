using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//https://www.hackerrank.com/challenges/ctci-find-the-running-median/problem
class FindMedian {

    /*
     * Complete the runningMedian function below.
     */
    static double[] runningMedian(int[] a) {
        double[] result = new double[a.Length];

        for(int i = 0; i < a.Length; i++){
            if(i == 0){
                result[0] = a[0];
            } else if(((i + 1) % 2) == 0){
                int middle = (i + 1) / 2;
                result[i] = (double)(a[middle] + a[middle - 1]) / 2;
            }else{
                int middle = ((i + 1) / 2);
                result[i] = a[middle];
            }
        }

        return result;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int aCount = Convert.ToInt32(Console.ReadLine());

        int[] a = new int [aCount];

        for (int aItr = 0; aItr < aCount; aItr++) {
            int aItem = Convert.ToInt32(Console.ReadLine());
            a[aItr] = aItem;
        }

        double[] result = runningMedian(a);

        Console.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
