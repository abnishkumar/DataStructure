using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    /// <summary>
    /// Implement a algorithm to determine if a string has all unique charcters. What if you can not use additional data structure.
    /// </summary>
    public class StringHasUniqueChar
    {

        /// <summary>
        /// here we use additional data structure as array
        /// </summary>
        /// <param name="str"></param>
        public void StringHasUniqueCharacter(string str)
        {
            Console.WriteLine("=============unique string sol-1===========");
            char[] arrayString = str.ToCharArray();
            int length = arrayString.Count();
            char[] temp = new char[length];
            for (int i = 0; i < length; i++)
            {
                if (temp.Contains(arrayString[i]))
                {
                    Console.WriteLine($"Unique charactr Found!! {str}");
                    Console.WriteLine();
                    IsUniqueChar(str);
                    return;
                }
                temp[i] = arrayString[i];

            }
            
            Console.WriteLine($"No Unique Characer {string.Concat(temp)}");
            Console.WriteLine();
            IsUniqueChar(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        public void IsUniqueChar(string str)
        {
            Console.WriteLine("=============unique string sol-2===========");
            int length = str.Length;
            // we will assume for simplicity the character set is ASCII,if assumption is not valid we need to increase the storage size.
            if (length > 128)
            {
                Console.WriteLine("String is more than 128 Char!!");
            }
            bool[] char_set = new bool[128];

            for (int i = 0; i < length; i++)
            {
                int val = str.ElementAt(i);
                if (char_set[val])
                {
                    
                    Console.WriteLine("Already Found this char in string");
                    Console.WriteLine();
                    return;
                }
                char_set[val] = true;
            }
            Console.WriteLine();
            Console.WriteLine("All Char is Unique!!");
        }
    }
}
