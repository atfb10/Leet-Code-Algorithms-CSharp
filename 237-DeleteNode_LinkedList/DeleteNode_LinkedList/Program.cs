using System;

/// <summary>
/// Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
/// 
/// Problem Notes:
///     The linked list will have at least two elements
///     All of the nodes' values will be unique
///     The given node will not be the tail and it will always be a valid node of the linked list
///     Do not return anything from your function
/// 
/// Example: 
///     Given linked list -- head = [4,5,1,9], which looks like following: 4 -> 5 -> 1 -> 9
///     Input: head = [4,5,1,9], node = 5
///     Output: [4,1,9]
///     Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.
///     
/// My Note - Linked List kept in seperate class file "LinkedList.cs"
/// </summary>

namespace DeleteNode_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            LinkedList list = new LinkedList();
            list.Add("Test0");
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            // show current linked list
            list.PrintLinkedList();

            // call method to delete
            list.DeleteNode("Test0");
            Console.WriteLine("-----");

            // show new list
            list.PrintLinkedList();

            // keep console open
            Console.Read();
        }
    }
}
