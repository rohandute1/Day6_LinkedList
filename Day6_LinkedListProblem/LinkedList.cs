using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LinkedListProblem
{
    class SortedLinkedList <T> where T : IComparable<T>
    {
        private Node<T> head;

        public SortedLinkedList()
        {
            this.head = null;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null || data.CompareTo(head.data) < 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;

                while (current.next != null && data.CompareTo(current.next.data) >= 0)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
            }
        }

        public void Display()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }
}
