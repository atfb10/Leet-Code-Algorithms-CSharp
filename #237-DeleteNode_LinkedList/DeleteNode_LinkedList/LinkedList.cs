using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteNode_LinkedList
{
    /// <summary>
    ///  Create Linked List class
    /// </summary>
    class LinkedList
    {
        /// <summary>
        /// Create Node Class
        /// </summary>
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
        /// Method to allow user to add objects and specify index
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
        /// Method to allow user to add object without specifying index; appends object to end of list
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object Add(object obj)
        {
            return Add(count, obj);
        }

        /// <summary>
        /// Allow user to see entire linked list printed out
        /// This will verify whether or not item was successfully deleted
        /// </summary>
        public void PrintLinkedList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        /// <summary>
        /// Set current node to head
        /// Loop until current = null, increasing current by one each iteration
        /// If current node's data = object. Set current data to next node's data
        /// Set the next node, to the next next node
        /// </summary>
        /// <param name="obj"></param>
        public void DeleteNode(object obj)
        {
            Node current = head;

            while (current.Next != null)
            {
                if (current.Data.Equals(obj))
                {
                    current.Data = current.Next.Data;
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        } 
    }
}
