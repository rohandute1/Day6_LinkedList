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

            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);

            Console.WriteLine("Linked List Sequence: ");
            linkedList.Display();

            Console.ReadLine();
        }
    }
}
