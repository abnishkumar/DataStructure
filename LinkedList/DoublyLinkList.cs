using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyLinkList
    {
        private DNode head = null;
        private DNode tail = null;

        public void AddNewNode(string data)
        {
            DNode newItem = new DNode(data);
            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                newItem.Prev = tail;
                tail.Next = newItem;
                tail = newItem;
            }

        }
    }
}
