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
            linkedList.InsertBetween(56, int.MinValue); // Insert 56 at the beginning (before any other node)
            linkedList.InsertBetween(70, 56); // Insert 70 after 56
            linkedList.InsertBetween(30, 56); // Insert 30 between 56 and 70

            Console.WriteLine("Linked List Sequence: ");
            linkedList.Display();

            int searchValue = 30;
            Node searchedNode = linkedList.Search(searchValue);

            if (searchedNode != null)
            {
                Console.WriteLine($"Found Node with value {searchValue}: {searchedNode.data}");
            }
            else
            {
                Console.WriteLine($"Node with value {searchValue} not found.");
            }

            Console.ReadLine();
        }
    }
}
