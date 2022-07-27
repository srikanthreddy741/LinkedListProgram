using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        internal static Node temp;
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
