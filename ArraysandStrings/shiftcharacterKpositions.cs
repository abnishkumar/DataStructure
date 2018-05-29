using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    public class ShiftCharacterKpositions
    {
        /// <summary>
        /// Given a string S of length N, shift each character of the string by K positions to the right, where K<=N.
        /// </summary>
        /// <param name="origionalData"></param>
        /// <param name="siftedCharFromCurrentPosition"></param>
        public void SiftByK(string str,int siftedCharFromCurrentPosition)
        {
            var origionalData = str.ToCharArray().Select(c => c.ToString()).ToArray();
            var origionalDataLength = origionalData.Count();

            string[] temp = new string[origionalDataLength];
            for (int i = 0; i < origionalDataLength; i++)
            {
                var position = (i + siftedCharFromCurrentPosition) % origionalDataLength;
                temp[position] = origionalData[i];
            }

            Console.WriteLine(string.Concat(temp));
        }
    }
}
