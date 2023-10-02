using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LinkedListProblem
{
    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void InsertBetween(int data, int previousData)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    if (current.data == previousData)
                    {
                        newNode.next = current.next;
                        current.next = newNode;
                        break;
                    }
                    current = current.next;
                }
            }
        }

        public Node Search(int searchData)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == searchData)
                {
                    return current;
                }
                current = current.next;
            }
            return null; // Node with the specified value not found
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }
}
