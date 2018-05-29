using ArraysandStrings;
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
            bool isLinkedListTest = false;
            bool isStringArrayTest = true;
            if (isLinkedListTest)
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
            }
            if (isStringArrayTest)
            {
                ShiftCharacterKpositions shiftCharacter = new ShiftCharacterKpositions();

                shiftCharacter.SiftByK("abnish",2);
            }
            Console.ReadKey();
        }
    }
}
