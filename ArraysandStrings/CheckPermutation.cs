using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    /// <summary>
    /// Given two string ,write a method to decide if one is permutation of other.
    /// </summary>
    public class CheckPermutation
    {
        /// <summary>
        /// sort both  of the string and compare string ,we can achieve this.
        /// we assume that comparision is case sensitive
        /// </summary>
        /// <param name="firstStr"></param>
        /// <param name="secondStr"></param>
        public void CheckStringPermutation(string firstStr, string secondStr)
        {
            Console.WriteLine("===========Check String permutation============");

            if (firstStr.Length != secondStr.Length)
            {
                Console.WriteLine("first String is not permutation of other!!");
                return;
            }
            char[] firstCharSet = firstStr.ToCharArray();
            char[] secondCharSet = secondStr.ToCharArray();
            Array.Sort(firstCharSet);
            Array.Sort(secondCharSet);
            string newFirstStr = new string(firstCharSet);
            string newSecodStr = new string(secondCharSet);
            if (newFirstStr.Equals(newSecodStr))
            {
                Console.WriteLine("first String is permutation of other!!");

            }
            else
            {
                Console.WriteLine("first String is not permutation of other!!");

            }
            Console.WriteLine();
        }
    }
}
