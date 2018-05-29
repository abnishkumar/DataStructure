using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        private Node head = null;
        private Node tail = null;

        public void AddNewNode(string data)
        {
            Node newItem = new Node(data);
            if (head == null)
            {
                head = newItem;
                tail = head;
                return;
            }
            tail.Next = newItem;
            tail = newItem;
        }

        public void PrintAllNode()
        {
            Node current = head;
            if (current == null) return;
            while (current.Next != null)
            {
                Console.Write(current.ToString());
                current = current.Next;
            }
            Console.Write("Node(" + current.Data + ")");
        }

        public void ReverseNode()
        {
            if (head == null) return;
            Node current = head;
            Node newItem = null;

            while (current != null)
            {
                Node tmp = current.Next;
                current.Next = newItem;
                newItem = current;
                current = tmp;
            }
            head = newItem;
            Console.WriteLine();
            PrintAllNode();
        }

        public void RemoveDuplicateWithoutBuffer()
        {
            if (head != null)
            {
                HashSet<string> set = new HashSet<string>();
                Node current = head;
                Node newItem = null;
                while (current != null)
                {
                    if (set.Contains(current.Data))
                    {
                        newItem.Next = current.Next;
                    }
                    else
                    {

                        set.Add(current.Data);
                        newItem = current;
                    }
                    current = current.Next;

                }

                Console.WriteLine();
                PrintAllNode();
            }
        }

        public void RemoveDuplicateWithBuffer()
        {
            if (head == null) return;
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }

            Console.WriteLine();
            PrintAllNode();
        }

    }
}
