using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sList = new SinglyLinkedList();
            DoublyLinkList dList = new DoublyLinkList();
            CircularLinkList cList = new CircularLinkList();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                var nodeVal = rand.Next(10, 20);
                sList.AddNewNode(nodeVal.ToString());
                dList.AddNewNode(nodeVal.ToString());
                cList.AddNewNode(nodeVal.ToString());
            }
            sList.PrintAllNode();
            sList.ReverseNode();
            sList.RemoveDuplicateWithBuffer();
            // sList.RemoveDuplicateWithoutBuffer();
            Console.ReadKey();
        }
    }
}
