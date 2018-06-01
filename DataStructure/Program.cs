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

                shiftCharacter.SiftByK("abnish", 2);

                StringHasUniqueChar stringHasUniqueChar = new StringHasUniqueChar();
                stringHasUniqueChar.StringHasUniqueCharacter("aabnish");

                CheckPermutation checkPermutation = new CheckPermutation();
                checkPermutation.CheckStringPermutation("abnish", "shabnI");
                ReplaceSpace replaceSpace = new ReplaceSpace();
                replaceSpace.ReplaceSpaceWithPercent20("abnish kumar choudhary   ");

                OneAwayString oneAwayString = new OneAwayString();
                oneAwayString.CheckOneAwayString("abnish", "abnis");
                oneAwayString.CheckOneAwayString("abnish", "abnish");
                oneAwayString.CheckOneAwayString("abnish", "sanjeet");

            }
            Console.ReadKey();
        }
    }
}
