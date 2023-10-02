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
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;
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
            size++;
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

        public void Delete(int deleteData)
        {
            if (head == null)
            {
                return; // Empty list, nothing to delete
            }

            if (head.data == deleteData)
            {
                head = head.next;
                size--;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == deleteData)
                {
                    current.next = current.next.next;
                    size--;
                    return;
                }
                current = current.next;
            }
        }

        public int Size()
        {
            return size;
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
