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
        public Node? Next { get; set; }
    }

    // The linked list class itself
    public class JesseLinkedList
    {
        public Node? Head { get; set; }

        public JesseLinkedList()
        {
            Head = null;
        }

        public string Get(int index)
        {
            return Head.Data;
        }

        public void Add(string item)
        {
            Node? oldHead = Head;

            if (Head != null)
            {
                Node? pos = Head;

                while (pos != null)
                {

                }
            }


            if (Head != null)
            {
                if (Head.Next == null)
                {
                    Head.Next = new Node() { Data = item };
                } else
                {
                    // somehow traverse the nodes until it is null
                }
                
            }
            else
            {
                Head = new Node { Data = item };
            }
        }
    }
}
