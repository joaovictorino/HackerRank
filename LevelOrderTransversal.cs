using System;
using System.Collections.Generic;
using System.IO;

//https://www.hackerrank.com/challenges/tree-level-order-traversal/problem
namespace SolutionLevelOrder{
public class LevelOrderTransversal {

	public static void levelOrder(Node root) {
        Queue<Node> queueTree = new Queue<Node>();
        queueTree.Enqueue(root);

        while(queueTree.Count != 0)
        {
            Node nodeTemp = queueTree.Dequeue();
            Console.Write("{0} ", nodeTemp.data);

            if(nodeTemp.left != null)
                queueTree.Enqueue(nodeTemp.left);

            if(nodeTemp.right != null)
                queueTree.Enqueue(nodeTemp.right);
        }
    }

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

    public static void Main(String[] args) {
        //Scanner scan = new Scanner(System.in);
        int t = Convert.ToInt32(Console.ReadLine());
        Node root = null;
        while(t-- > 0) {
            int data = Convert.ToInt32(Console.ReadLine());
            root = Insert(root, data);
        }
        //scan.close();
        levelOrder(root);
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