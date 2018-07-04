// using System;
// using System.Collections.Generic;
// using System.IO;

// namespace SolutionBinaryTree{
// class HeightBinaryTree {

//     public static Node Insert(Node root, int data) {
//         if(root == null) {
//             return new Node(data);
//         } else {
//             Node cur;
//             if(data <= root.data) {
//                 cur = Insert(root.left, data);
//                 root.left = cur;
//             } else {
//                 cur = Insert(root.right, data);
//                 root.right = cur;
//             }
//             return root;
//         }
//     }

//     public static int Height(Node root) {
//       	// Write your code here.
//           return 0;
//     }

//     public static void main(String[] args) {
//         Scanner scan = new Scanner(System.in);
//         int t = scan.nextInt();
//         Node root = null;
//         while(t --> 0) {
//             int data = scan.nextInt();
//             root = Insert(root, data);
//         }
//         scan.close();
//         int height = Height(root);
//         Console.WriteLine(height);
//     }	
// }

// public class Node {
//     public Node left;
//     public Node right;
//     public int data;
    
//     public Node(int data) {
//         this.data = data;
//         left = null;
//         right = null;
//     }
// }

// }