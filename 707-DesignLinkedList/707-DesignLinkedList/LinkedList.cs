using System;

namespace _707_DesignLinkedList
{
    // linked list properties 
    public class LinkedList
    {
        public class Node
        {
            public object data;
            public Node next;

            public Node(object data, Node next)
            {
                this.data = data;
                this.next = next;
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

        // Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list,
        // the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted.
        public object AddAtIndex(int index, object obj)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (index > count)
            {
                throw new ArgumentOutOfRangeException("Index: " + index + " cannot exist, because it exceeds the length of the list");
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

        // method to add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
        public object AddAtHead(object obj)
        {
            return AddAtIndex(0, obj);
        }

        // method to append a node of value val to the last element of the linked list.
        public object AddAtTail(object obj)
        {
            return AddAtIndex(count, obj);
        }

        // Method to get the value of the index-th node in the linked list. If the index is invalid, return -1.
        public object Get(int index)
        {
            if (index < 0)
            {
                return -1;
            }

            if (index > count)
            {
                return -1;
            }

            Node current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        // method to delete the index-th node in the linked list, if the index is valid
        public object DeleteAtIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (index > count)
            {
                throw new ArgumentOutOfRangeException("Index: " + index + " cannot exist, because it exceeds the length of the list");
            }

            Node current = head;
            object removed = null;

            if (index == 0)
            {
                removed = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                removed = current.Next.Data;
                current.Next = current.Next.Next;
            }
            return removed;
        }

        // Additonal utility method to print a linked list
        public void PrintLinkedList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
