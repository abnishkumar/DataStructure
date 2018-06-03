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
                CheckTwoStringHaveIdenticalChar(firstStr, secondStr);
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
            CheckTwoStringHaveIdenticalChar(firstStr, secondStr);

            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firrstStr"></param>
        /// <param name="secondStr"></param>
        public void CheckTwoStringHaveIdenticalChar(string firrstStr, string secondStr)
        {
            Console.WriteLine("===========Check String Identical/permutation============");

            if (firrstStr.Count() != secondStr.Count())
            {
                Console.WriteLine("String is not Identical");
                return;
            }
            int[] letters = new int[128]; // Assumption(always check by interviewer size of char set,so i assume the char set is ASCII.)

            char[] s_array = firrstStr.ToCharArray();

            // now we count number of each char in firstStr

            foreach (var item in s_array)
            {
                letters[item]++;
            }

            // now we loop thru secondStr and decrease count of each char from secondStr. 
            for (int i = 0; i < secondStr.Count(); i++)
            {
                int c = secondStr.ElementAt(i);
                letters[c]--;
                if (letters[c] < 0)
                {
                    Console.WriteLine("String is not Identical char.");
                    return;
                }
            }

            Console.WriteLine("String is Identical.");
        }
    }
}
