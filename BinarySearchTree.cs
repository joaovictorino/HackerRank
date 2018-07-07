using System;
using System.Collections.Generic;
using System.IO;

//https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem
namespace SolutionBinarySearchTree{
    public class BinarySearchTree {

        public static Node Insert(Node root, int data) {
            if(root == null) {
                return new Node(data);
            } else {
                Node cur;
                if(data <= root.data) {
                    cur = Insert(root.left, data);
                    root.left = cur;
                } else {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        // static bool checkBST(Node root) {
        //     bool validLeft = true;
        //     bool validRight = true;

        //     if(root.left != null){ 
        //         if(validLeft && root.data > root.left.data) 
        //             validLeft = checkBST(root.left);
        //         else
        //             validLeft = false;
        //     }

        //     if(root.right != null){ 
        //         if(validRight && root.data < root.right.data) 
        //             validRight = checkBST(root.right);
        //         else
        //             validRight = false;
        //     }
            
        //     return validLeft && validRight;
        // }

        static bool checkBST(Node root) 
        {
            List<int> arr= new List<int>();
            Order(root, arr);
            
            for(int i=1; i<arr.Count; i++){
                if(arr[i]>arr[i-1])
                    continue;
                else
                    return false;
            }

            return true;
        }

        static void Order(Node root, List<int> arr)
        {
            if(root==null) return;
            Order(root.left,arr);
            arr.Add(root.data);
            Order(root.right,arr);
        }

        public static void Main(String[] args) {
            // int t = Convert.ToInt32(Console.ReadLine());
            // Node root = null;
            // while(t-- > 0) {
            //     int data = Convert.ToInt32(Console.ReadLine());
            //     root = Insert(root, data);
            // }

            Node root = new Node(3);
            Node root2 = new Node(2);
            Node root1 = new Node(1);
            Node root5 = new Node(5);
            Node root6 = new Node(6);
            Node root7 = new Node(7);
            root.left = root2;
            root.right = root5;
            root2.left = root1;
            root5.left = root6;
            root5.right = root7;

            bool isBST = checkBST(root);
            Console.WriteLine(isBST);
        }	
    }

    public class Node {
        public Node left;
        public Node right;
        public int data;
        
        public Node(int data) {
            this.data = data;
            left = null;
            right = null;
        }
    }

}