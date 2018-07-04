using System;
using System.Collections.Generic;
using System.IO;

namespace SolutionLinkedList{
class LinkedListCycle {

    static bool hasCycle(Node head) {
        List<Node> stack = new List<Node>();
        while(head != null)
        {
            if(stack.Contains(head))
            {
                return true;
            }
            else
            {
                stack.Add(head);
                head = head.next;
            }
        }
        return false;
    }

    static void Main(String[] args) {
        Node n = new Node();
        n.data = 1;

        Console.WriteLine(hasCycle(n));

        Node n3 = new Node();
        n3.data = 3;

        Node n2 = new Node();
        n2.data = 2;
        n2.next = n3;
        n3.next = n2;
        
        Node n1 = new Node();
        n1.data = 1;
        n1.next = n2;
        
        Console.WriteLine(hasCycle(n1));
    }
}

public class Node {
        public int data;
        public Node next;
    }

}