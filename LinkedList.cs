using System;
using System.Collections.Generic;
using System.Text;

namespace UpdatedTechQuestionsPractice
{
    class LinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // method to add a new node at the end of a list
        public void AddNode(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        
        // method to reverse list
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void DeleteNode()
        {

        }

        // method to print list data
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }


    }
}
