using System;

/// <summary>
/// Design your implementation of the linked list. You can choose to use the singly linked list or the doubly linked list.
/// A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and 
/// next is a pointer/reference to the next node. Assume all nodes in the linked list are 0-indexed. 
/// Implement these functions in your linked list class:
///     get(index) : Get the value of the index-th node in the linked list. If the index is invalid, return -1.
///     addAtHead(val) : Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
///     addAtTail(val) : Append a node of value val to the last element of the linked list.
///     addAtIndex(index, val) : Add a node of value val before the index-th node in the linked list. If index equals to the length 
///     of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted.
///     deleteAtIndex(index) : Delete the index-th node in the linked list, if the index is valid.
///     
/// Examples: 
///     MyLinkedList linkedList = new MyLinkedList();
///     linkedList.addAtHead(1);
///     linkedList.addAtTail(3);
///     linkedList.addAtIndex(1, 2);  // linked list becomes 1->2->3
///     linkedList.get(1);            // returns 2
///     linkedList.deleteAtIndex(1);  // now the linked list is 1->3
///     linkedList.get(1);            // returns 3
/// </summary>


// Important note: Challenge says to call it val, but I will use be using the term 'data' instead; no functionality is changed. (Personal preference)

namespace _707_DesignLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // tests
            LinkedList myList = new LinkedList();
            myList.AddAtHead(1);
            myList.AddAtTail(3);
            myList.AddAtIndex(1, 2);
            myList.PrintLinkedList();

            Console.WriteLine("----");

            object num2 = myList.Get(1);
            Console.WriteLine(num2);
            Console.WriteLine("----");

            myList.DeleteAtIndex(1);
            myList.PrintLinkedList();

            // keep console open
            Console.Read();
        }
    }
}
