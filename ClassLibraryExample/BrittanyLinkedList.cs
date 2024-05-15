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
        public T Data { get; set; }
        public BrittanyNode<T>? Next { get; set; }

        public BrittanyNode(T data)
        {
            Data = data;
        }
    }

    // The linked list class itself
    public class BrittanyLinkedList<T>
    {
        public BrittanyNode<T>? Head { get; set; }

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

        public BrittanyNode FindMiddleBrute()
        {
            BrittanyNode ptr = Head;
            int counter = 0;

            while (ptr != null)
            {
                ptr = ptr.Next;
                counter++;
            }

            ptr = Head;

            for (int i = 0; i< counter/2; i ++)
            {
                ptr = ptr.Next;
            }

            return ptr;
        }

        public BrittanyNode FindMiddleTortoiseHare()
        {
            BrittanyNode slow_ptr = Head;
            BrittanyNode fast_ptr = Head;

            while (fast_ptr != null & fast_ptr.Next != null)
            {
                slow_ptr = slow_ptr.Next;
                fast_ptr = slow_ptr.Next.Next;
            }

            return slow_ptr;
        }

        public void AddToFront(string item)
        {
            BrittanyNode newNode = new BrittanyNode(item);

            newNode.Next = Head;
            Head = newNode;
        }


    }
}
