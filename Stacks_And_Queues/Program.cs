﻿using System;

namespace Stacks_And_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pushing values to Stack");
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(70);
            //linkedListStack.push(30);
            //linkedListStack.push(56);
            //linkedListStack.Display();
            //Console.WriteLine("Using Peek and Pop Till Stack is Empty");
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();

            Console.WriteLine("Enqueue value in a Queue");
            LinkedList_Queues linkedListQueues = new LinkedList_Queues();
            linkedListQueues.Enqueue(56);
            linkedListQueues.Enqueue(30);
            linkedListQueues.Enqueue(70);
            linkedListQueues.Display();

            Console.WriteLine("Dequeue Elements in Queue");
            linkedListQueues.Dequeue(56);
            linkedListQueues.Dequeue(36);
            linkedListQueues.Dequeue(70);
            linkedListQueues.Display();



        }
    }
}
