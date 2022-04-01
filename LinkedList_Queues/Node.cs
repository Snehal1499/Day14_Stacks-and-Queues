using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Queue
{
    public class Node<Gtype>
    {
        public Gtype value;
        public Node<Gtype> next;
        public Gtype data;

        public Node(Gtype data)
        {
            this.value = data;
            this.next = null;
        }
    }
}
