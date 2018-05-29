using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CircularLinkList
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
            }
            else
            {
                newItem.Next = head;
                tail.Next = newItem;
                tail = newItem;
            }
        }
    }
}
