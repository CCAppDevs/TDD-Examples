using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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


        public Node(string data)
        {
            Data = data;
        }
    }
    // The linked list class itself
    public class KaiLinkedList
    {
        public Node? Head { get; set; }

        public KaiLinkedList()
        {
            Head = null;
        }

        public string Get(int index)
        {
            Node node = Head;
            int counter = 0;

            //search through node list for given index. (if it exist)
            while (counter != index)
            {
                node = node.Next;
                counter++;

            }

            return node.Data;
        }

        public void AddToBack(string item)
        {
            // create a new node to hold our new item
            Node newNode = new Node(item);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node temp = FindEndOfList();

            temp.Next = newNode;
        }

        public Node FindEndOfList()
        {
            Node position = Head;

            while (position.Next != null)
            {
                position = position.Next;
            }

            return position;
        }
        public void AddToFront(string item)
        {
            Node newNode = new Node(item);

            newNode.Next = Head;
            Head = newNode;
        }

    }
}
