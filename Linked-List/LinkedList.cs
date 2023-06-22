using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head;
        private Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddFirst(int value)
        {
            // Adding Node at first

            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void AddLast(int value)
        {
            // Adding Node at last
            
            Node newNode = new Node(value);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void DeleteFirst()
        {
            // Deleting first Node

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty. No element to delete.");
            }
            else
            {
                head = head.Next;

                if (head == null)
                {
                    tail = null;
                }
            }
        }

        public void PrintList()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
    }
}