using System;

namespace LinkedList_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList_Queue<int> my_Queue = new LinkedList_Queues.LinkedList_Queue<int>();

            my_Queue.Enqueue(56);
            my_Queue.Enqueue(30);
            my_Queue.Enqueue(70);
            my_Queue.show();

        }
    }
}
