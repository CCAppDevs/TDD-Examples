using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    // Node class for linked list item
    public class BrittanyNode
    {
        public string Data { get; set; }
        public BrittanyNode? Next { get; set; }

        public BrittanyNode(string data)
        {
            Data = data;
        }
    }

    // The linked list class itself
    public class BrittanyLinkedList
    {
        public BrittanyNode? Head { get; set; }

        public BrittanyLinkedList()
        {
            Head = null;
        }

        public string Get(int index)
        {

            BrittanyNode node = Head;
            int counter = 0;

            // search through the node list to find the item at the given index (if it exists)
            while (counter != index)
            {
                node = node.Next;
                counter++;

                if (counter == index)
                {
                    return node.Data;
                }

            }

            return node.Data;
        }

        public void AddToBack(string item)
        {
            // create a new node to hold our new item
            BrittanyNode newNode = new BrittanyNode(item);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            BrittanyNode temp = FindEndOfList();

            // add the new item to the end
            temp.Next = newNode;

        }

        public BrittanyNode FindEndOfList()
        {
            //find the end
            BrittanyNode position = Head;
            while (position.Next != null)
            {
                //take current position and move to position next
                position = position.Next;
            }
            return position;
        }

        public void AddToFront(string item)
        {
            BrittanyNode newNode = new BrittanyNode(item);

            newNode.Next = Head;
            Head = newNode;
        }


    }
}
