using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    /// <summary>
    /// WAP to replace all space in a string with %20.
    /// </summary>
    public class ReplaceSpace
    {
        public void ReplaceSpaceWithPercent20(string str)
        {
            Console.WriteLine("===========Replace Spacewith %20============");
            string[] arr = str.Select(x => x.ToString()).ToArray();
            int length = arr.Count();
            for (int i = 0; i < length; i++)
            {
                string ele = arr.ElementAt(i);
                if (string.IsNullOrWhiteSpace(ele))
                {
                    arr[i] = "%20";
                }
            }

            Console.WriteLine($"{str} replace with %20 is {string.Concat(arr)}");
            URLify(str.ToCharArray());

        }

        /// <summary>
        /// we have implementing this problem using char array,because string are immutable
        /// if we use string directly ,the function would have to return new copy of the string
        /// </summary>
        /// <param name="char_Str"></param>
        public void URLify(char[] char_Str)
        {
            int length = char_Str.Count();
            int countSpace = 0;
            for (int i = 0; i < length; i++)
            {
                int c = char_Str.ElementAt(i);
                if (c == 32) // here 32 is space ascii value
                {
                    countSpace++;
                }
            }

            int index = length + countSpace * 2;
            char[] temp = new char[index];
            for (int i = length-1; i >= 0; i--)
            {
                int c = char_Str.ElementAt(i);
                if (c == 32) // here 32 is space ascii value
                {
                    temp[index - 1] = '%';
                    temp[index - 2] = '2';
                    temp[index - 3] = '0';
                    index = index - 3;
                }
                else
                {
                    temp[index - 1] = char_Str[i];
                    index--;
                }
            }
            Console.WriteLine($"Space(32) replace with %20 is {string.Concat(temp)}");

        }
    }
}
