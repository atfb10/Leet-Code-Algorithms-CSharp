using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Holds link list class and methods
/// </summary>

namespace Reverse_LinkedList
{
    class LinkedList
    {
        public class Node
        {
            private Node next;
            private object data;

            public Node(object data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public Node Next
            {
                get => next;
                set => next = value;
            }

            public object Data
            {
                get => data;
                set => data = value;
            }
        }

        private Node head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public bool Empty
        {
            get => count == 0;
        }

        public int Count
        {
            get => count;
        }

        /// <summary>
        /// Method to allow user to add node to list and specify index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object Add(int index, object obj)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (index > count)
            {
                index = count;
            }

            Node current = head;

            if (Empty || index == 0)
            {
                head = new Node(obj, head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(obj, current.Next);
            }
            count++;
            return obj;
        }

        /// <summary>
        /// Allow addition to list by appending node to end
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(object o)
        {
            return Add(count, o);
        }

        /// <summary>
        /// Method to print linked list to validate reversal
        /// </summary>
        public void PrintLinkedList()
        {
            Node current = head;

            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        /// <summary>
        /// Check if head is null or there is only 1 index
        /// If not set three nodes; previous, current, and next
        /// Loop while current does not equal null
        /// *Logic to reverse*
        /// Return the new head
        /// </summary>
        public object Reverse()
        {
            if (head == null || count == 0)
            {
                return head;
            }

            Node prev = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }
    }
}
