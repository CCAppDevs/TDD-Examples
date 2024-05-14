using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    public class CTN_Node
    {
        public string data { get; set; }
        public CTN_Node? next { get; set; }
        public CTN_Node(string nodedata) { data = nodedata; }
        //public static CTN_Node operator +(CTN_Node oldnode, CTN_Node newnode) => oldnode.next = newnode;
        //public static CTN_Node? operator ++(CTN_Node oldnode) => oldnode.next;
    }
    public class CTN_LinkedList
    {
        public CTN_Node? head { get; set; }

        public CTN_LinkedList()
        {
            head = null;
        }

        public string Get(int index)
        {
            CTN_Node listPointer = head;
            int counter = 0;

            while (counter < index)
            {
                listPointer = listPointer.next;
                counter++;
            }

            return listPointer.data;
        }

        public void PushFront(string input)
        {
            CTN_Node newnode = new CTN_Node(input);

            newnode.next = head;
            head = newnode;
        }

        public void PushBack(string input)
        {
            CTN_Node newNode = new CTN_Node(input);

            if (head == null)
            {
                head = newNode;
                return;
            }

            CTN_Node listEnd = GetListEnd();
            listEnd.next = newNode;
        }
    
        public CTN_Node GetListEnd()
        {
            CTN_Node headPointer = head;

            while (headPointer.next != null)
            {
                headPointer = headPointer.next;
            }

            return headPointer;
        }
    }
}
