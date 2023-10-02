using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LinkedListProblem
{
    class Node<T> where T : IComparable<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
