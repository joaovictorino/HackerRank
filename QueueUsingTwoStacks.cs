using System;
using System.Collections.Generic;
using System.IO;
class QueueUsingTwoStacks {
    static void Main(String[] args) {
        MyQueue<int> queue = new MyQueue<int>();

        //Scanner scan = new Scanner(System.in);
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] valuesLine = Console.ReadLine().Split(' ');
            int operation = Convert.ToInt32(valuesLine[0]);
            if (operation == 1) { // enqueue
              queue.Enqueue(Convert.ToInt32(valuesLine[1]));
            } else if (operation == 2) { // dequeue
              queue.Dequeue();
            } else if (operation == 3) { // print/peek
              Console.WriteLine(queue.Peek());
            }
        }
        //scan.close();
    }
}

public class MyQueue<T>
{
    List<T> internalQueue = new List<T>();
    public void Enqueue(T t){
        internalQueue.Add(t);
    }

    public T Dequeue(){
        T value = Peek();
        internalQueue.Remove(value);
        return value;
    }

    public T Peek(){
        return internalQueue.Count > 0 ? internalQueue[0] : default(T);
    }
}