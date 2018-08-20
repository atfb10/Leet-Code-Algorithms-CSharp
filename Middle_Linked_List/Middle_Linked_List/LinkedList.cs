using System;
using System.Collections.Generic;
using System.Text;

namespace Middle_Linked_List
{
    // linked list class
    public class LinkedList
    {
        // node class
        public class Node
        {
            public Node next;
            public object data;

            public Node(object data, Node next)
            {
                this.next = next;
                this.data = data;
            }

            public object Data
            {
                get => data;
                set => data = value;
            }

            public Node Next
            {
                get => next;
                set => next = value;
            }
        }

        public Node head;
        public int count;

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

        // Allow user to add node and specify index
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

        // Allow addition of node by appending node to end of list
        public object Add(object obj)
        {
            return Add(count, obj);
        }

        // print a linked list
        public void Print()
        {
            Node current = head;

            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        /// <summary>
        /// Check if there are zero nodes
        /// Create two nodes, one that goes through list at double speed and one that goes at normal
        /// Move through list until faster node reaches null, then return normal node
        /// </summary>
        /// <returns></returns>
        public object FindMid()
        {
            if (head == null) return head;

            Node middle = head;
            Node doubleSpeed = head;

            while (doubleSpeed != null && doubleSpeed.Next != null)
            {
                middle = middle.Next;
                doubleSpeed = doubleSpeed.Next.Next;
            }
            return middle.Data;
        }
    }
}
