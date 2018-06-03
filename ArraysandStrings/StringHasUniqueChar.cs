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
                    if (IsUniqueChars(str))
                    {
                        Console.Write("yes,unique chare");
                    }
                    return;
                }
                temp[i] = arrayString[i];

            }

            Console.WriteLine($"No Unique Characer {string.Concat(temp)}");
            Console.WriteLine();
            IsUniqueChar(str);
            bool isUniqueChar = IsUniqueChars(str);
            if (isUniqueChar)
            {
                Console.WriteLine("yes,unique chars");
            }
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

        /// <summary>
        /// we can reduce our space usages by a factor of eight by using bit vector
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsUniqueChars(String str)
        {

            /*
            checker is the bit array, it will have a 1 on the character index that
            has appeared before and a 0 if the character has not appeared, you
            can see this number initialized as 32 0 bits:
            00000000 00000000 00000000 00000000
             */
            int checker = 0;

            //loop through each String character
            for (int i = 0; i < str.Count(); ++i)
            {
                /*
                a through z in ASCII are charactets numbered 97 through 122, 26 characters total
                with this, you get a number between 0 and 25 to represent each character index
                0 for 'a' and 25 for 'z'

                renamed 'val' as 'characterIndex' to be more descriptive
                 */
                int characterIndex = str.ElementAt(i) - 'a'; //char 'a' would get 0 and char 'z' would get 26

                /*
                created a new variable to make things clearer 'singleBitOnPosition'

                It is used to calculate a number that represents the bit value of having that 
                character index as a 1 and the rest as a 0, this is achieved
                by getting the single digit 1 and shifting it to the left as many
                times as the character index requires
                e.g. character 'd'
                00000000 00000000 00000000 00000001
                Shift 3 spaces to the left (<<) because 'd' index is number 3
                1 shift: 00000000 00000000 00000000 00000010
                2 shift: 00000000 00000000 00000000 00000100
                3 shift: 00000000 00000000 00000000 00001000

                Therefore the number representing 'd' is
                00000000 00000000 00000000 00001000

                 */
                int singleBitOnPosition = 1 << characterIndex;

                /*
                This peforms an AND between the checker, which is the bit array
                containing everything that has been found before and the number
                representing the bit that will be turned on for this particular
                character. e.g.
                if we have already seen 'a', 'b' and 'd', checker will have:
                checker = 00000000 00000000 00000000 00001011
                And if we see 'b' again:
                'b' = 00000000 00000000 00000000 00000010

                it will do the following:
                00000000 00000000 00000000 00001011
                & (AND)
                00000000 00000000 00000000 00000010
                -----------------------------------
                00000000 00000000 00000000 00000010

                Since this number is different than '0' it means that the character
                was seen before, because on that character index we already have a 
                1 bit value
                 */
                if ((checker & singleBitOnPosition) > 0)
                {
                    return true;
                }

                /* 
                Remember that 
                checker |= singleBitOnPosition is the same as  
                checker = checker | singleBitOnPosition
                Sometimes it is easier to see it expanded like that.

                What this achieves is that it builds the checker to have the new 
                value it hasnt seen, by doing an OR between checker and the value 
                representing this character index as a 1. e.g.
                If the character is 'f' and the checker has seen 'g' and 'a', the 
                following will happen

                'f' = 00000000 00000000 00000000 00100000
                checker(seen 'a' and 'g' so far) = 00000000 00000000 00000000 01000001

                00000000 00000000 00000000 00100000
                | (OR)
                00000000 00000000 00000000 01000001
                -----------------------------------
                00000000 00000000 00000000 01100001

                Therefore getting a new checker as 00000000 00000000 00000000 01100001

                 */
                checker |= singleBitOnPosition;
            }
            return false;
        }
    }
}
