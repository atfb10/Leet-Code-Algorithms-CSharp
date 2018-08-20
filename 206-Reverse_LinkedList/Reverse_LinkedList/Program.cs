using System;

/// <summary>
/// Reverse a singly linked list.
/// 
/// Input: 1->2->3->4->5->NULL
/// Output: 5->4->3->2->1->NULL
/// 
/// Note: Most code lies in LinkedList.cs file
/// </summary>

namespace Reverse_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            LinkedList list = new LinkedList();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("Original List:");
            list.PrintLinkedList();
            Console.WriteLine();

            // call method, print updated list
            list.Reverse();
            Console.WriteLine("Reversed List:");
            list.PrintLinkedList();

            // keep console open
            Console.Read();
        }
    }
}
