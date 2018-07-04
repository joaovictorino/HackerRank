    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Contacts {

    /*
     * Complete the contacts function below.
     */
    static int[] contacts(string[][] queries) {
        string[] contactsList = new string[queries.Length];
        List<int> results = new List<int>();
        int counter = 0;
        foreach(string[] command in queries) {
            if(command[0] == "add") {
                contactsList[counter] = command[1];
                counter++;
                Array.Sort(contactsList);
            }else{
                results.Add(contactsList.Count(x => x != null && x.StartsWith(command[1])));
            }
        }

        return results.ToArray();
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int queriesRows = Convert.ToInt32(Console.ReadLine());

        string[][] queries = new string[queriesRows][];

        for (int queriesRowItr = 0; queriesRowItr < queriesRows; queriesRowItr++) {
            queries[queriesRowItr] = Console.ReadLine().Split(' ');
        }

        int[] result = contacts(queries);

        Console.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
