using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    // Node class for a linked list item
    public class Node
    {
        public string Data { get; set; }
    }

    // The linked list class itself
    public class JesseLinkedList
    {
        public Node Head { get; set; }

        public JesseLinkedList()
        {
            Head = new Node();
        }

        public string Get(int index)
        {
            return Head.Data;
        }

        public void Add(string item)
        {
            Head = new Node { Data = item };
        }
    }
}
