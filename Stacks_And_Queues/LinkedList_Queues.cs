using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    public class LinkedList_Queues
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        internal void Dequeue(int data)
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
            if (this.head == null)
            {
                this.head = null;
            }
            Console.WriteLine("Item Delete is {0}", temp.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
