using System;
using System.Collections.Generic;
using System.IO;

//https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree/problem
namespace SolutionBinaryTree{
public class HeightBinaryTree {

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

    public static int Height(Node root) {
        int heightLeft = 0;
        int heightRight = 0;

        if(root.left != null)
            heightLeft = 1 + Height(root.left);

        if(root.right != null)
            heightRight = 1 + Height(root.right);

        return heightLeft > heightRight ? heightLeft : heightRight;
    }

    public static void Main(String[] args) {
        //Scanner scan = new Scanner(System.in);
        int t = Convert.ToInt32(Console.ReadLine());
        Node root = null;
        while(t-- > 0) {
            int data = Convert.ToInt32(Console.ReadLine());
            root = Insert(root, data);
        }
        //scan.close();
        int height = Height(root);
        Console.WriteLine(height);
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