using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//https://www.hackerrank.com/challenges/ctci-contacts/problem
namespace SolutionContactsTrie{
    class Contacts {

        /*
        * Solution easy to codify but without performance
        */
        // static int[] contacts(string[][] queries) {
        //     string[] contactsList = new string[queries.Length];
        //     List<int> results = new List<int>();
        //     int counter = 0;
        //     foreach(string[] command in queries) {
        //         if(command[0] == "add") {
        //             contactsList[counter] = command[1];
        //             counter++;
        //             Array.Sort(contactsList);
        //         }else{
        //             results.Add(contactsList.Count(x => x != null && x.StartsWith(command[1])));
        //         }
        //     }

        //     return results.ToArray();
        // }

        static int[] contacts(string[][] queries) {
            MyTrie trie = new MyTrie();
            List<int> results = new List<int>();

            foreach(string[] command in queries) {
                if(command[0] == "add") {
                    trie.Add(command[1]);
                } else {
                    results.Add(trie.Find(command[1]));
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

#region "Solution Group"
    // Solution from discussion group
    // class Node {
    //     private Dictionary<char, Node> children = new Dictionary<char, Node>();
    //     public int size;
    //     public char? value;

    //     public Node(char? value){
    //         this.value = value;
    //     }

    //     public void putChildIfAbsent(char ch) {
    //         if(!children.ContainsKey(ch))
    //             children.Add(ch, new Node(ch));
    //     }

    //     public Node getChild(char ch) {
    //         if(children.ContainsKey(ch))
    //             return children[ch];

    //         return null;
    //     }
    // }

    //class Trie {
    //     Node root = new Node(null);
    
    //     public void Add(String str) {
    //         Node curr = root;
    //         for (int i = 0; i < str.Length; i++) {
    //             char ch = str[i];
    //             curr.putChildIfAbsent(ch);
    //             curr = curr.getChild(ch);
    //             curr.size++;
    //         }
    //     }
    
    //     public int Find(String prefix) {
    //         Node curr = root;
            
    //         for (int i = 0; i < prefix.Length; i++) {
    //             char ch = prefix[i];
    //             curr = curr.getChild(ch);
    //             if (curr == null) {
    //                 return 0;
    //             }
    //         }
    //         return curr.size;
    //     }
    // }
#endregion

    class MyNode {
        private List<MyNode> children = new List<MyNode>();
        public char value;
        public int size = 1;

        public void putChildIfAbsent(char ch){
            if(children.Count > 0){
                bool foundIt = false;
                foreach(MyNode node in children){
                    if(ch == node.value){
                        node.size++;
                        foundIt = true;
                        break;
                    }
                }

                if(!foundIt)
                    children.Add(new MyNode(){ value = ch });
            }else{
                children.Add(new MyNode(){ value = ch });
            }
        }

        public MyNode getChild(char ch){
            foreach(MyNode node in children){
                if(ch == node.value)
                    return node;
            }

            return null;
        }
    }

    class MyTrie {
        MyNode root = new MyNode();
    
        public void Add(String str) {
            MyNode curr = root;
            for (int i = 0; i < str.Length; i++) {
                char ch = str[i];
                curr.putChildIfAbsent(ch);
                curr = curr.getChild(ch);
            }
        }
    
        public int Find(String prefix) {
            MyNode curr = root;
            
            for (int i = 0; i < prefix.Length; i++) {
                char ch = prefix[i];
                curr = curr.getChild(ch);
                if (curr == null) {
                    return 0;
                }
            }
            return curr.size;
        }
    }
}