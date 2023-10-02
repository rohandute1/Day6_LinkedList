using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Problems.");

            SortedLinkedList<int> sortedList = new SortedLinkedList<int>();
            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);

            Console.WriteLine("Ordered Linked List Sequence: ");
            sortedList.Display();

            Console.ReadLine();
        }
    }
}
