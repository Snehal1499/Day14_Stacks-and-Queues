using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Queues
{
    public class LinkedList_Queue<Gtype>
    {
        Node<Gtype> front;
        Node<Gtype> rare;


        public void Enqueue(Gtype data)
        {
            //creating node with given data
            Node<Gtype> node = new Node<Gtype>(data);

            
            if (rare is null)
            {
                front = node;
                rare = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }
        }

        public void show()
        {
            //Created a temp variable
            Node<Gtype> temp = front;
            //traverse from front to last element and print element
            if (temp is null) Console.WriteLine("Queue is Empty");
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.value + " ");
                    temp = temp.next;
                }
                //to print the last value
                Console.WriteLine(temp.value);
            }
        }

    }
}

