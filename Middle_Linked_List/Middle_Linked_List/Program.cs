using System;

namespace Middle_Linked_List
{
    /// <summary>
    /// Given a non-empty, singly linked list with head node head, return a middle node of linked list.
    /// If there are two middle nodes, return the second middle node.
    /// 
    /// Example:
    /// Input: [1,2,3,4,5]
    /// Output: Node 3 from this list 
    /// The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
    /// Note that we returned a ListNode object ans, such that:
    /// ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
    /// 
    /// Example: 
    /// Input: [1,2,3,4,5,6]
    /// Output: Node 4 from this list
    /// Since the list has two middle nodes with values 3 and 4, we return the second one.
    /// 
    /// Note: All linked list code in class file LinkedList.cs
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // input
            LinkedList list = new LinkedList();
            list.Add(33);
            list.Add(11);
            list.Add(2);
            list.Add(3434);

            // call method, pass in arg
            Console.WriteLine(list.FindMid());

            // keep console open
            Console.Read();
        }
    }
}
